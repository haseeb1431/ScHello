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
        }
    }
}
