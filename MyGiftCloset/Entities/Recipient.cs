using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyGiftCloset.Entities
{
    public class Recipient
    {
        public Recipient()
        {
            Gifts = new List<Gift>();
        }

        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }

        ICollection<Gift> Gifts { get; set; }
    }
}