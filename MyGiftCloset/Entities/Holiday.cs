using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyGiftCloset.Entities
{
    public class Holiday
    {
        public Holiday()
        {
            Gifts = new List<Gift>();
        }

        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public ICollection<Gift> Gifts { get; set; }
    }
}