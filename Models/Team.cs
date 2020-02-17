using System;
using System.Collections.Generic;

namespace CAP2.Models
{
    public class Team
    {
        public int TeamID {get; set;} //PK

        
        public List<Client> Clients {get;set;} //navigation 

    }
}