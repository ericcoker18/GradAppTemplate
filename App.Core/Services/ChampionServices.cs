using System;
using System.Collections.Generic;
using System.Text;
using App.Core.Models;

namespace App.Core.Services
{
    class ChampionServices : IChampionRepository {
        private readonly IChampionRepository _championRepository;

            public ChampionServices(IChampionRepository championService)
        {
            _championRepository = championService;
        }

        public Champion Add(Champion newChampion)
        {
            return _championRepository.Add(newChampion);
        }

        public Champion Get(int id)
        {
           return _championRepository.Get(id);
        }

        public IEnumerable<Champion> GetAll()
        {
            return _championRepository.GetAll();
        }

        public void Remove(int id)
        {
            _championRepository.Remove(id);
            
        }

        public Champion Update(Champion updatedChampion)
        {
            return _championRepository.Update(updatedChampion);
        }
    }   
}

