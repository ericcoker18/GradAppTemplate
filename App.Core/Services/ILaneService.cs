using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Services
{
    public interface ILaneService
    {
        public LaneService Get(int id);
        public IEnumerable<LaneService> GetAll();
        public LaneService Add(LaneService newlane);
        public LaneService Update(LaneService newlane);
        public void Remove(int id);
    }
}
