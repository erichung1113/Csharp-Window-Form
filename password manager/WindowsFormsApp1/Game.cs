using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Game
    {
        private List<int>[] stacks = new List<int>[4];

        private int take, place;
        public Game(string[] input)
        {
            for (int i = 0; i < 4; i++) {
                stacks[i] = new List<int>();
                for (int j = 0; j < input[i].Count(); j += 2)
                {
                    stacks[i].Add(input[i][j] - '0');
                }
            }
        }
        public void MarkTake(int x) { take = x; }
        public void MarkPlace(int x) { place = x; }

        public bool canplace(int i)
        {
            return stacks[i].Count() < 4;
        }
        public bool cantake(int i)
        {
            return stacks[i].Count() > 0;
        }
        public void move()
        {
            stacks[place].Add(stacks[take].Last());
            stacks[take].RemoveAt(stacks[take].Count()-1);
        }
        public string output(int x)
        {
            string ans = "";
            for(int i = stacks[x].Count() - 1; i >= 0; i--)
            {
                if (ans.Count() != 0) ans += '\n';
                ans += stacks[x][i].ToString();
            }
            return ans;
        }
        public bool win()
        {
            for(int i = 0; i < 4; i++)
            {
                if (stacks[i].Count() != 3 && stacks[i].Count() != 0) return false;

                int pre = -1;
                foreach(int j in stacks[i])
                {
                    if (pre == -1) pre = j;
                    else if (pre != j) return false;
                }
            }
            return true;
        }
    }

}
