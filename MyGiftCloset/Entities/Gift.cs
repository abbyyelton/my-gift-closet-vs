using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyGiftCloset.Entities
{
    public class Gift
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        [StringLength(200)]
        public string StoreLink { get; set; }
        public Recipient Recipient { get; set; }
        public Holiday Holiday { get; set; }
        public string Notes { get; set; }
        public bool Purchased { get; set; }
        public bool Wrapped { get; set; }
    }
}