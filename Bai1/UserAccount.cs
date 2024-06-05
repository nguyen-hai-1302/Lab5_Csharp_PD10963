using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class UserAccount
    {
        public string name;
        public int rank;
        public float winRate;
        public string type;
        public int skin;
        public UserAccount(string Name, int Rank, float WinRate, string Type, int Skin)
        {
            name = Name;
            rank = Rank;
            winRate = WinRate;
            type = Type;
            skin = Skin;
        }
    }
}
