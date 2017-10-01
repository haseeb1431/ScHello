using Haseeb.Models;
using Starcounter;

namespace Haseeb.ViewModel
{
    partial class FranchiseDetails : Json
    {
        void Handle(Input.CreateFranchiseTrigger action)
        {
            new Franchise()
            {
                FranchiseName = this.FranchiseName
            };
        }
    }
}
