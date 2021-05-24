using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Core.Models;
using App.Core.Services;

namespace App.Infrastructure.Data
{
    public class ChampionRepository:IChampionRepository
    {
        private readonly AppDbContext _dbContext;
        public ChampionRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public Champion Add(Champion newChampion)
        {
            _dbContext.Champions.Add(newChampion);
            _dbContext.SaveChanges();
            return newChampion;
        }

        public Champion Get(int id)
        {
           return _dbContext.Champions.FirstOrDefault(p => p.Id == id);
            
        }

        public IEnumerable<Champion> GetAll()
        {
          return  _dbContext.Champions.ToList();
        }

        public void Remove(int id)
        {
            Champion champion = _dbContext.Champions.Find(id);
            _dbContext.Champions.Remove(champion);
            _dbContext.SaveChanges();

        }

        public Champion Update(Champion Updatedchampion)
        {
            var currentchampion = _dbContext.Champions.Find(Updatedchampion.Id);
            _dbContext.Champions.Update(currentchampion);
            _dbContext.SaveChanges();
            return Updatedchampion;
        }
    }
}
