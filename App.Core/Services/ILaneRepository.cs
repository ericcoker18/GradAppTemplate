using System;
using System.Collections.Generic;
using System.Text;
using App.Core.Models;

namespace App.Core.Services
{
    public interface ILaneRepository
    {
            public  LaneService Get(int id);
            public IEnumerable<LaneService> GetAll();
            public LaneService Add(LaneService newlane);
            public LaneService Update(LaneService newlane);
            public void Remove(int id);
        }
}
