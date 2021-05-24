using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Core.Models;
using App.Core.Services;

namespace App.Infrastructure.Data
{
    
        public class LaneRepository : ILaneRepository
        {
            private readonly AppDbContext _dbContext;
            public LaneRepository(AppDbContext appDbContext)
            {
                _dbContext = appDbContext;
            }

        public LaneService Add(LaneService newlane)
        {
          
        }

        public LaneService Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LaneService> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public LaneService Update(LaneService newlane)
        {
            throw new NotImplementedException();
        }
    }
}
