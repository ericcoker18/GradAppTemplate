using System;
using System.Collections.Generic;
using System.Text;
using App.Core.Models;

namespace App.Core.Services
{
    public interface IChampionRepository
    {
        public Champion Get(int id);
        public IEnumerable<Champion> GetAll();
        public Champion Add(Champion newChampion);
        public Champion Update(Champion updatedChampion);
        public void Remove(int id);
    }
}
