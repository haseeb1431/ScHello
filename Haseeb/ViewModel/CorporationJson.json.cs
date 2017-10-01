using Haseeb.Models;
using Starcounter;

namespace Haseeb.ViewModel
{
    partial class CorporationJson : Json
    {
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
    }
}
