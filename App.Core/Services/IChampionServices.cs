using System;
using System.Collections.Generic;
using System.Text;
using App.Core.Models;

namespace App.Core.Services
{
    public interface IChampionServices
    {
      public Champion Get(int id);
      public IEnumerable<Champion> GetAll();
      public  Champion Add(Champion champion);
      public  Champion Update(Champion champion);
      public void Remove(int id);
    }
}
