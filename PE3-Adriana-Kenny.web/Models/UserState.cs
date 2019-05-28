using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PE3_Adriana_Kenny.web.Entities;

namespace PE3_Adriana_Kenny.web.Models
{
    public class UserState
    {
        public bool  IsLoggedIn { get; set; }
        public bool  IsAdmin { get; set; }
        public Client Client { get; set; }
    }
}
