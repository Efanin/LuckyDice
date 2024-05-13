using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class Game
    {
        private int money = 50;
        private int[] bets = new int[6];
        private int[] win = new int[3];
        public void Bet(int index, Button button, Label label)
        {
            bets[index-1]++;
            money--;
            button.Text = bets[index-1].ToString();
            label.Text = money.ToString();
        }
        public void Start(Label label,params PictureBox[] picture)
        {
            for(int i=0;i<win.Length;i++)
            {
                win[i] = new Random().Next(6);
                picture[i].Image = Dice(win[i]);
            }
            for (int i = 0; i < win.Length; i++)
            {
                money += bets[win[i]] * 2;
            }
            label.Text = money.ToString();
        }
        public void Clear(params Button[] button)
        {
            for(int i=0;i< button.Length;i++)
            {
                button[i].Text = "0";
                bets[i] = 0;
            }
        }
        private Bitmap Dice(int index)
        {
            return index switch
            {
                0 => Resource1._1,
                1 => Resource1._2,
                2 => Resource1._3,
                3 => Resource1._4,
                4 => Resource1._5,
                5 => Resource1._6
            };
        }
    }
}
