using Haseeb.Models;
using Haseeb.ViewModel;
using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haseeb.Configs
{
    public class RouteConfig
    {
        public void RegisterRoutes()
        {
            //Register the Html Middleware
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/HaseebFranchise/start", () =>
            {
                //we have binded the viewmodel with long running transaction to save things
                return Db.Scope(() =>
                {
                    Session.Ensure();

                    var corp = Db.SQL<Corporation>("SELECT c FROM Corporation c");//.FirstOrDefault();
                    return new CorporationJson { Data = corp };
                });

            });

            Handle.GET("/HaseebFranchise/franchise/{?}", (string ID) => {

                return Db.Scope(() => {

                    Session.Ensure();
                    
                    var franchise = DbHelper.FromID(DbHelper.Base64DecodeObjectID(ID)) as Franchise;

                    return new FranchiseDetailsJson { Data = franchise };
                    
                });

            });

            Handle.GET("/HaseebFranchise/resetData", () => {

                Db.Transact(() => {

                    Session.Ensure();
                    //Clear Existing Data
                    Db.SQL<Corporation>("DELETE FROM Corporation");
                    Db.SQL<Franchise>("DELETE FROM Franchise");
                    Db.SQL<TransactionInfo>("DELETE FROM TransactionInfo");

                    //add new Data
                    var rand = new Random();
                    var corp = new Corporation()
                    {
                        CorpName = "Adfenix"
                    };

                    var franchise = new Franchise()
                    {
                        FranchiseName = "Adfenix East",
                        Owner = corp
                    };
                    for (int i = 0; i < rand.Next(5,10); i++)
                    {
                        new TransactionInfo()
                        {
                            TransactionDate = new DateTime(2017, 10, 01+(5%2)),
                            Benificary = franchise,
                            Commission = rand.Next(100, 100000),
                            SalePrice = rand.Next(1000, 100000)
                        };
                    }

                    //adding 2nd Franchise
                    var franchise2 = new Franchise()
                    {
                        FranchiseName = "Adfenix West",
                        Owner = corp
                    };

                    for (int i = 0; i < rand.Next(5, 10); i++)
                    {
                        new TransactionInfo()
                        {
                            TransactionDate = new DateTime(2017, 09, 25 + (5 % 2)),
                            Benificary = franchise2,
                            Commission = rand.Next(100, 100000),
                            SalePrice = rand.Next(1000, 100000)
                        };
                    }
                    
                });

                return 200;
            });
        }
    }
}
