using Haseeb.Models;
using Starcounter;

namespace Haseeb.ViewModel
{
    partial class CorporationJson : Json
    {

        public QueryResultRows<Corporation> AllCorporation => Db.SQL<Corporation>("SELECT c FROM Corporation c ");

        static CorporationJson()
        {
            
            //DefaultTemplate Franchises.ElementType.InstanceType = typeof(FranchiseDetailsJson);
        }
        
        void Handle(Input.CreateCorpTrigger action)
        {
            //Get the View data and create a new Corporation. 
            //TODO: Check if already exist so let's not create it
            var corp = new Corporation()
            {
                CorpName = this.CorpName
            };

            //Create the corporation and save respective changes
            Transaction.Commit();
        }

        void Handle(Input.CreateFranchiseTrigger action)
        {
            new Franchise()
            {
                FranchiseName = this.FranchiseName,
                //TODO: how to get the current Item in the collection
                Owner = this.AllCorporation.First
            };

            Transaction.Commit();
        }
    }
}
