using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglesLeague
{
    class Player
    {
        public int week;
        public string player;
        public string opponent;
        public int w;
        public int l;
        public int first9;
        public int allstars;
        public int thirty;
        public int eighty;
        public int ninety5;
        public int ton40;
        public int ton80;
        public int outthrown;
        public int outhit;
        public int highout;
        public int bestleg;
        public int totalDarts;
        public int totalScored;
        public int[] darts;
        public int[] scored;
        public int[] takeout;
        public int user;

        public Player()
        {
            Initialize();
        }

        private void Initialize()
        {
            player = "";
            opponent = "";
            week = 0;
            w = 0;
            l = 0;
            first9 = 0;
            allstars = 0;
            thirty = 0;
            eighty = 0;
            ninety5 = 0;
            ton40 = 0;
            ton80 = 0;
            outthrown = 0;
            outhit = 0;
            highout = 0;
            bestleg = 100;
            totalDarts = 0;
            totalScored = 0;

            darts = new int[12];
            scored = new int[12];
            takeout = new int[12];

            for (int i = 0; i < 12; i++)
            {
                darts[i] = 0;
                scored[i] = 0;
                takeout[i] = 0;
            }


            user = 2;
        }

        public void win()
        {
            w++;
        }

        public void lose()
        {
            l++;
        }

        public void high(int x)
        {
            if (x > highout)
                highout = x;
        }

        public void best(int x)
        {
            if (x > bestleg)
                bestleg = x;
        }

        public void p30()
        {
            thirty++;
        }

        public void p80()
        {
            eighty++;
        }

        public void p95()
        {
            ninety5++;
        }

        public void p140()
        {
            ton40++;
        }

        public void p180()
        {
            ton80++;
        }

        public void turn(int game, int score, int thrown)
        {
            darts[game] += thrown;
            scored[game] += score;
        }

        public void setInitial(string play, string opp, int wk)
        {
            player = play;
            opponent = opp;
            week = wk;
        }

        public int checkDarts(int game)
        {
            return darts[game];
        }

        public void p9(int score)
        {
            first9 += score;
        }

        public void outThrow(int x)
        {
            outthrown += x;
        }

        public void outHit()
        {
            outhit++;
        }

        public void addAllstars(int x)
        {
            allstars += x;
        }

        public void outshot(int x, int game)
        {
            takeout[game] = x;
        }

        
    }
}
