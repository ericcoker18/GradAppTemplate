using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace App.Core.Models
{
    public class Champion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int Id { get; set; }
       public string Name { get; set; }
        public string Description { get; set; }
        public string Rank { get; set; }

        public int LaneId { get; set; }
        public Lane Lane { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
        

        

    }
}
