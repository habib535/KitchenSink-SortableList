using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenSink
{
    static class PersonTestData
    {
        public static bool Exists()
        {
            var exists = Db.SQL<Person>("SELECT p FROM Person p FETCH ?", 1).First;
            if (exists == null)
            {
                return false;
            }
            return true;
        }

        public static void Create()
        {
            Db.Transact(() =>
            {
                var person1 = new Person()
                {
                    FirstName = "Habib",
                    LastName = "Ullah",
                    SortOrder = 1
                };

                var person2 = new Person()
                {
                    FirstName = "Mohsin",
                    LastName = "Mehmood",
                    SortOrder = 2
                };

                var person3 = new Person()
                {
                    FirstName = "Rahul",
                    LastName = "Sharma",
                    SortOrder = 3
                };

                var person4 = new Person()
                {
                    FirstName = "Mark",
                    LastName = "Avallone",
                    SortOrder = 4
                };

                var person5 = new Person()
                {
                    FirstName = "Brian",
                    LastName = "Kelley",
                    SortOrder = 5
                };

                var person6 = new Person()
                {
                    FirstName = "Ulfat",
                    LastName = "Hussain",
                    SortOrder = 6
                };
            });
        }
    }
}
