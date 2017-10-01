using ScHello.Modul;
using ScHello.ViewModel;
using Starcounter;

namespace ScHello
{
    partial class PersonJson : Json
    {
        public string FullName => $"{FirstName} {LastNameOld}";
        public string NameAfterMarriage => $"{FirstName} {LastName}";


        static PersonJson()
        {
            //When binding the view-model with properties of database classes, the types have to be specified
            DefaultTemplate.Expenses.ElementType.InstanceType = typeof(ExpenseJson);
        }
        void Handle(Input.SaveTrigger action)
        {

            //commits the current state of the view-model 
            //to the database so that the data is accessible from other transactions.
            Transaction.Commit();
        }
        void Handle(Input.NewExpenseTrigger action)
        {
            new Expense()
            {
                Spender = this.Data as Person,
                Amount = 1
            };
        }

        void Handle(Input.CancelTrigger action)
        {
            Transaction.Rollback();
        }

        void Handle(Input.DeleteAllTrigger action)
        {
            Db.SQL("DELETE FROM Expense WHERE Spender = ?", this.Data);
            this.Expenses.Clear();
        }
    }
}
