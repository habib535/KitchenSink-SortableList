using Starcounter;
using System;

namespace KitchenSink
{
    [Database]
    public class Person
    {
        public string FirstName;
        public string LastName;
        public Int64 SortOrder;
    }
    partial class SortableListPage : Json
    {
        protected override void OnData()
        {
            base.OnData();

            RefreshPersonList();
        }

        public void RefreshPersonList()
        {
            var persons = Db.SQL<Person>("SELECT p FROM Person p ORDER BY SortOrder");
            this.PersonList.Data = persons;
        }

        [SortableListPage_json.PersonList]
        partial class PersonObj : Json, IBound<Person>
        {
            public SortableListPage ParentPage
            {
                get
                {
                    return this.Parent.Parent as SortableListPage;
                }
            }
            void Handle(Input.MoveUp Action)
            {
                //can only move up if it is not the first row
                if (this.SortOrder > 1)
                {
                    //swap SortOrder values, execute as an atomic operation
                    Db.Transact(() => 
                    {
                        var previousPerson = Db.SQL<Person>("SELECT p FROM Person p WHERE SortOrder = ?", (this.SortOrder - 1)).First;
                        previousPerson.SortOrder = this.SortOrder;
                        this.SortOrder = this.SortOrder - 1;
                    });
                    //refresh table binding
                    this.ParentPage.RefreshPersonList();
                }
            }

            void Handle(Input.MoveDown Action)
            {
                var maxSortOrder = Db.SlowSQL<Int64>("SELECT MAX(SortOrder) FROM Person p").First;
                //can only move down if it is not the last row
                if (this.SortOrder < maxSortOrder)
                {
                    //swap SortOrder values, execute as an atomic operation
                    Db.Transact(() =>
                    {
                        var nextPerson = Db.SQL<Person>("SELECT p FROM Person p WHERE SortOrder = ?", (this.SortOrder + 1)).First;
                        nextPerson.SortOrder = this.SortOrder;
                        this.SortOrder = this.SortOrder + 1;
                    });
                    //refresh table binding
                    this.ParentPage.RefreshPersonList();
                }
            }

            void Handle(Input.ItemDropped Action)
            {
                var person = this;
            }
        }
    }
}