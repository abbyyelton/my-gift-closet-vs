using MyGiftCloset.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyGiftCloset
{
    internal class DatabaseInitializer : DropCreateDatabaseAlways<MyGiftClosetEntities>
    {
        protected override void Seed(MyGiftClosetEntities database)
        {
            var christmas = new Holiday()
            {
                Name = "Christmas"
            };
            var birthday = new Holiday()
            {
                Name = "Birthday"
            };
            var mom = new Recipient()
            {
                Name = "mom"
            };
            var dad = new Recipient()
            {
                Name = "dad"
            };

            database.Gifts.Add(new Gift()
            {
                Name = "Dress",
                Recipient = mom,
                Holiday = christmas

            });
            database.Gifts.Add(new Gift()
            {
                Name = "T-shirt",
                Recipient = dad,
                Holiday = birthday

            });
            database.Gifts.Add(new Gift()
            {
                Name = "Tickets",
                Recipient = mom,
                Holiday = christmas

            });

            database.SaveChanges();
        }
    }
}