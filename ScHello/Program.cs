using System;
using Starcounter;
using System.Linq;
using ScHello.Modul;

namespace ScHello
{

   

    class Program
    {

        static void Main()
        {
            

            Db.Transact(() =>
            {
                var person = Db.SQL<Person>("SELECT p FROM Person p");
                if (person.Count() == 0)
                {
                    new Person
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        LastNameOld = "Test"
                    };
                }
            });


            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/ScHello", () =>
            {
                //we have binded the viewmodel with long running transaction to save things magically
                return Db.Scope(() =>
                {
                    Session.Ensure();

                    var person = Db.SQL<Person>("SELECT p FROM Person p").FirstOrDefault();
                    return new PersonJson { Data = person };
                });


            });
        }
    }
}