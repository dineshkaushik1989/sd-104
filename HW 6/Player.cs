using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
   public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Wins { get; set; }
        public int GamePlayed { get; set; }
        public String Team { get; set; }


        public Player() { }
        public Player(string name)
        {
            this.Name = Name;
        }
    }
}


