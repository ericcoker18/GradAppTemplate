using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.ApiModels
{
    public class UserModel
    {
        public ICollection<UserModel> Champions { get; set; }
    }
}
