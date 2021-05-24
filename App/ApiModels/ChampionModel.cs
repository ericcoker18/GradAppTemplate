using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.ApiModels
{
    public class ChampionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Rank { get; set; }

        public int LaneId { get; set; }
        public string Lane { get; set; }

        public string UserId { get; set; }
        public string User { get; set; }

    }
}
