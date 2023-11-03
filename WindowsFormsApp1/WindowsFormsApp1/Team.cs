using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Team
    {
        public string name { get; set; } // 팀명
        public int win { get; set; } // 승
        public int draw { get; set; } // 무
        public int lose { get; set; } // 패

        static public List<Team> teams = new List<Team>(); // 전체 팀 리스트

        public Team(string name, int win, int draw, int lose)
        {
            this.name = name;
            this.win = win;
            this.draw = draw;
            this.lose = lose;

            teams.Add(this);
        }
    }
}

