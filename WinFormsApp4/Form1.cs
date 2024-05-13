namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        Game game = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Bet(1, button1, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.Bet(2, button2, label1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.Bet(3, button3, label1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.Bet(4, button4, label1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            game.Bet(5, button5, label1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            game.Bet(6, button6, label1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            game.Start(label1, pictureBox1, pictureBox2, pictureBox3);
            game.Clear(button1, button2, button3, button4, button5, button6);
        }
    }
}
