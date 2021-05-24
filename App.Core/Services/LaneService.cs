using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Services
{
    public class LaneService : ILaneRepository
    {
        private readonly ILaneRepository _laneService;

        public LaneService(ILaneRepository laneService)
        {
            _laneService = laneService;
        }

        public LaneService Add(LaneService newlane)
        {
            return _laneService.Add(newlane);
        }

        public LaneService Get(int id)
        {
            return _laneService.Get(id);
        }

        public IEnumerable<LaneService> GetAll()
        {
            return _laneService.GetAll();
        }

        public void Remove(int id)
        {
            _laneService.Remove(id);
        }

        public LaneService Update(LaneService newlane)
        {
            return _laneService.Update(newlane);
        }
    }
}
