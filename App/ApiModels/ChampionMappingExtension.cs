using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Core.Models;

namespace App.ApiModels
{
    public static class ChampionMappingExtension
    {
    public static ChampionModel ToApiModel(this Champion champion)
        {
            return new ChampionModel
            {
                Id = champion.Id,
                Name = champion.Name,
                Description = champion.Description,
                Rank = champion.Rank,
                LaneId = champion.LaneId,
                UserId = champion.UserId,
                // Lane = champion.Lane.RoleName
            };
            
        }
        public static Champion ToDomainModel(this ChampionModel championModel)
        {
            return new Champion
            {
                Id = championModel.Id,
                Name = championModel.Name,
                Description = championModel.Description,
                Rank = championModel.Rank,
                LaneId = championModel.LaneId,
                UserId = championModel.UserId,
            };
            
        }
        public static IEnumerable<ChampionModel> ToApiModels(this IEnumerable<Champion> champions)
        {
            return champions.Select(a => a.ToApiModel());
        }

        public static IEnumerable<Champion> ToDomainModels(this IEnumerable<ChampionModel> championModels)
        {
            return championModels.Select(a => a.ToDomainModel());
        }

    }
}
