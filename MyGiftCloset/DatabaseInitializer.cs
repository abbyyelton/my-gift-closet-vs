using MyGiftCloset.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyGiftCloset
{
    internal class DatabaseInitializer : DropCreateDatabaseIfModelChanges<MyGiftClosetEntities>
    {
        protected override void Seed(MyGiftClosetEntities database)
        {
            var christmas = new Holiday()
            {
                Name = "Christmas",
                Date = new DateTime(2017, 12, 25)
            };

            var birthday = new Holiday()
            {
                Name = "Birthday",
            };

            //database.Holidays.Add(new Holiday()
            //{
            //    Name = "Christmas",
            //    Date = new DateTime(2017, 12, 25)
            //});

            //database.Holidays.Add(new Holiday()
            //{
            //    Name = "Birthday",
            //});

            database.Holidays.Add(new Holiday()
            {
                Name = "Anniversary",
                Date = new DateTime(2017, 12, 25)
            });

            database.Holidays.Add(new Holiday()
            {
                Name = "Valentine's Day",
                Date = new DateTime(2017, 2, 14)
            });

            database.Holidays.Add(new Holiday()
            {
                Name = "Hanukkah",
                Date = new DateTime(2017, 12, 12)
            });

            var mom = new Recipient()
            {
                Name = "mom",
                Birthday = new DateTime(1948, 9, 9)
            };
            var dad = new Recipient()
            {
                Name = "dad",
                Birthday = new DateTime(1945, 3, 18)
            };

            database.Gifts.Add(new Gift()
            {
                Name = "Dress",
                Recipient = mom,
                Holiday = birthday

            });
            database.Gifts.Add(new Gift()
            {
                Name = "T-shirt",
                Recipient = dad,
                Holiday = christmas

            });
            database.Gifts.Add(new Gift()
            {
                Name = "Tickets",
                Recipient = mom,
                Holiday = birthday
            });

            database.SaveChanges();
        }
    }
}