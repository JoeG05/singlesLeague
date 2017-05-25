using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SinglesLeague
{
    
    public partial class scoreBoard : Form
    {
        Player a = new Player();
        Player h = new Player();
        int game;
        int s;

        public scoreBoard()
        {
            InitializeComponent();
        }

        public void InitializeComponent(string players, int start, int week)
        {
            textBoxHomeScore.Focus();
        }
        public scoreBoard(string players, int start, int week)
        {
            InitializeComponent();
            string[] lines = Regex.Split(players, "@");

            s = start;

            string away = lines[0];
            string home = lines[1];
            away = away.Trim(' ');
            home = home.Trim(' ');

            a.setInitial(away, home, week);
            h.setInitial(home, away, week);

            textBoxAwayName.Text = away;
            textBoxHomeName.Text = home;
            

            game = 1;
            labelLeg.Text = game.ToString();
            
            

        }

        private void textBoxAwayScore_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                updateAway(textBoxAwayScore.Text);
            }
            
        }

        private void buttonAway_Click(object sender, EventArgs e)
        {
            updateAway(textBoxAwayScore.Text);
        }

        private void textBoxHomeScore_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                updateHome(textBoxHomeScore.Text);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            
            updateHome(textBoxHomeScore.Text);
        }

        private void updateAway(string x)
        {
            int score;
            int scored;
            int temp;

            Int32.TryParse(labelAwayScore.Text, out score);
            Int32.TryParse(x, out scored);

            if (scored < 0 || scored > 180)
                return;

            temp = score - scored;
            int outs;
            Int32.TryParse(comboBoxOut.Text, out outs);
            int darts;
            Int32.TryParse(comboBoxThrown.Text, out darts);

            if (temp < 2 && temp !=0)
            {
                a.turn(game, 0, darts);
                a.outThrow(outs);
                
            }

            else
            {
                score = score - scored;
                breakdownA(scored);

                if (a.checkDarts(game) < 9)
                {
                    a.p9(scored);
                }

                if (score == 0)
                {
                    a.turn(game, scored, darts);
                    a.takeout[game] = scored;
                    a.outThrow(outs);
                    a.outHit();
                    a.win();
                    h.lose();
                    a.outshot(scored, game);
                    if (s == 1) s++;
                    else s = 1;
                    if (game == 11) endMatch();
                    else reset();
                    score = 501;
                }
                else
                {
                    a.turn(game, scored, darts);
                    a.outThrow(outs);
                    
                }

                
            }

            
            textBoxAwayScore.Text = "";
            labelAwayScore.Text = score.ToString();
            comboBoxOut.Text = "0";
            textBoxHomeScore.Focus();
        }

        private void updateHome(string x)
        {
            int score;
            int scored;
            int temp;

            Int32.TryParse(labelHomeScore.Text, out score);
            Int32.TryParse(x, out scored);

            if (scored < 0 || scored > 180)
                return;

            temp = score - scored;
            int outs;
            Int32.TryParse(comboBoxOut.Text, out outs);
            int darts;
            Int32.TryParse(comboBoxThrown.Text, out darts);

            if (temp < 2 && temp != 0)
            {
                h.turn(game, 0, darts);
                h.outThrow(outs);
            }

            else
            {
                score = score - scored;
                breakdownH(scored);

                if (h.checkDarts(game) < 9)
                    h.p9(scored);

                if (score == 0)
                {
                    h.turn(game, scored, darts);
                    h.takeout[game] = scored;
                    h.outThrow(outs);
                    h.outHit();
                    h.win();
                    a.lose();
                    h.outshot(scored, game);
                    if (s == 1) s++;
                    else s = 1;
                    if (game == 11) endMatch();
                    else reset();
                    score = 501;
                }
                else
                {
                    h.turn(game, scored, darts);
                    h.outThrow(outs);
                }
            }

            textBoxHomeScore.Text = "";
            labelHomeScore.Text = score.ToString();
            comboBoxOut.Text = "0";
            textBoxAwayScore.Focus();
        }

        private void reset()
        {
            game++;
            labelLeg.Text = game.ToString();
            labelAwayScore.Text = "501";
            labelHomeScore.Text = "501";
           
            return;
        }

        private void breakdownA(int score)
        {
            if (score >= 95)                 a.addAllstars(score);
            if (score <= 30)                 a.p30();
            if (score >= 80 && score < 95)   a.p80();
            if (score >= 95 && score < 140)  a.p95();
            if (score >= 140 && score < 180) a.p140();
            if (score == 180)                a.p180();
        }

        private void breakdownH(int score)
        {
            if (score >= 95)                 h.addAllstars(score);
            if (score <= 30)                 h.p30();
            if (score >= 80 && score < 95)   h.p80();
            if (score >= 95 && score < 140)  h.p95();
            if (score >= 140 && score < 180) h.p140();
            if (score == 180)                h.p180();
        }

        

        public void endMatch()
        {
            
            
            System.IO.StreamWriter logA = new System.IO.StreamWriter(@"log-" + a.player + "(" + a.week + ").txt");
            System.IO.StreamWriter logH = new System.IO.StreamWriter(@"log-" + h.player + "(" + h.week + ").txt");

            for (int i = 1; i < 12; i++)
            {
                a.totalDarts += a.darts[i];
                a.totalScored += a.scored[i];
                h.totalDarts += h.darts[i];
                h.totalScored += h.scored[i];
                if (a.darts[i] < a.bestleg)
                    a.bestleg = a.darts[i];
                if (h.darts[i] < h.bestleg)
                    h.bestleg = h.darts[i];
                if (a.takeout[i] > a.highout)
                    a.highout = a.takeout[i];
                if (h.takeout[i] > h.highout)
                    h.highout = h.takeout[i];
            }

            logA.WriteLine(a.week);
            logA.WriteLine("{0} vs {1}", a.player, a.opponent);
            logA.WriteLine("{0} - {1}", a.w, a.l);
            logA.WriteLine("First 9: {0}", a.first9 / 3);
            logA.WriteLine("Allstars: {0}", a.allstars);
            logA.WriteLine("<30: {0}", a.thirty);
            logA.WriteLine("80+: {0}", a.eighty);
            logA.WriteLine("95+: {0}", a.ninety5);
            logA.WriteLine("140+: {0}", a.ton40);
            logA.WriteLine("180: {0}", a.ton80);
            if (a.outthrown == 0)
                logA.WriteLine("0%");
            else
                logA.WriteLine("{0}%", a.outhit / a.outthrown * 100.0);
            logA.WriteLine(a.totalScored);
            logA.WriteLine(a.totalDarts);
            logA.WriteLine("Avg: {0}", (a.totalScored / a.totalDarts) * 3.0);
            logA.WriteLine("Best Leg: {0}", a.bestleg);
            logA.WriteLine("High Out: {0}", a.highout);

            logH.WriteLine(a.week);
            logH.WriteLine("{0} vs {1}", h.player, h.opponent);
            logH.WriteLine("{0} - {1}", h.w, h.l);
            logH.WriteLine("First 9: {0}", h.first9 / 3);
            logH.WriteLine("Allstars: {0}", h.allstars);
            logH.WriteLine("<30: {0}", h.thirty);
            logH.WriteLine("80+: {0}", h.eighty);
            logH.WriteLine("95+: {0}", h.ninety5);
            logH.WriteLine("140+: {0}", h.ton40);
            logH.WriteLine("180: {0}", h.ton80);
            if (h.outthrown == 0)
                logH.WriteLine("0%");
            else
                logH.WriteLine("{0}%", h.outhit / h.outthrown * 100.0);
            logH.WriteLine(h.totalScored);
            logH.WriteLine(h.totalDarts);
            logH.WriteLine("Avg: {0}", (h.totalScored / h.totalDarts) * 3.0);
            logH.WriteLine("Best Leg: {0}", h.bestleg);
            logH.WriteLine("High Out: {0}", h.highout);

            logA.Close();
            logH.Close();

            sql s = new sql();
            string q;
            q = string.Format(
                "INSERT INTO abstats (week, player, opponent, w, l, first9, allstars, " +
                 "thirty, eighty, ninety5, ton40, ton80, outthrown, outhit, highout, " +
                 "bestleg, darts1, darts2, darts3, darts4, darts5, darts6, darts7, " +
                 "darts8, darts9, darts10, darts11, dartstotal, score1, score2, score3, score4, " +
                 "score5, score6, score7, score8, score9, score10, score11, scoretotal, user) VALUES " +
                 "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', " +
                 "'{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', " +
                 "'{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', " +
                 "'{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}', '{38}')",
                a.week, a.player, a.opponent, a.w, a.l, a.first9, a.allstars, a.thirty, a.ninety5,
                a.ton40, a.ton80, a.outthrown, a.outhit, a.highout, a.bestleg,
                a.darts[1], a.darts[2], a.darts[3], a.darts[4], a.darts[5], a.darts[6],
                a.darts[7], a.darts[8], a.darts[9], a.darts[10], a.darts[11], a.totalDarts, a.scored[1],
                a.scored[2], a.scored[3], a.scored[4], a.scored[5], a.scored[6], a.scored[7],
                a.scored[8], a.scored[9], a.scored[10], a.scored[11], a.totalScored, a.user
                );
            s.Insert(q);

            q = string.Format(
                "INSERT INTO abstats (week, player, opponent, w, l, first9, allstars, " +
                 "thirty, eighty, ninety5, ton40, ton80, outthrown, outhit, highout, " +
                 "bestleg, darts1, darts2, darts3, darts4, darts5, darts6, darts7, " +
                 "darts8, darts9, darts10, darts11, dartstotal, score1, score2, score3, score4, " +
                 "score5, score6, score7, score8, score9, score10, score11, scoretotal, user) VALUES " +
                 "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', " +
                 "'{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', " +
                 "'{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', " +
                 "'{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}', '{38}, {39}, {40}')",
                h.week, h.player, h.opponent, h.w, h.l, h.first9, h.allstars, h.thirty, h.ninety5,
                h.ton40, h.ton80, h.outthrown, h.outhit, h.highout, h.bestleg,
                h.darts[1], h.darts[2], h.darts[3], h.darts[4], h.darts[5], h.darts[6],
                h.darts[7], h.darts[8], h.darts[9], h.darts[10], h.darts[11], h.totalDarts, h.scored[1],
                h.scored[2], h.scored[3], h.scored[4], h.scored[5], h.scored[6], h.scored[7],
                h.scored[8], h.scored[9], h.scored[10], h.scored[11], h.totalScored, h.user
                );
            s.Insert(q);

            MessageBox.Show("Ending");
            this.Close();

        }
    }
}
