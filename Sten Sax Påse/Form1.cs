namespace Sten_Sax_Påse
{
    public partial class Form1 : Form
    {

//Variabler till att beräkna vem som vinner
        int ROCK = 0;
        int PAPER = 1;
        int SCISSORS = 2;

        int wins = 0;
        int losses = 0;
        int ties = 0;

        int choice = -1;

        public Form1()
        {
            InitializeComponent();
        }

// Bestämmer värdet på choice variabeln 
       private void button1_Click(object sender, EventArgs e)
        {
            choice = ROCK;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            choice = PAPER;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            choice = SCISSORS;
        }
        private void button4_Click(object sender, EventArgs e)
        {
// Ger en slumpmässigt värde till motståndaren
            int opponent = Random.Shared.Next(ROCK, SCISSORS + 1);

            if ( opponent == ROCK) 
            { 
                label1.Text = "Rock" ; 
            }
            else if ( opponent == PAPER) 
            {
                label1.Text = "Paper";
            }
            else if ( opponent == SCISSORS) 
            {
                label1.Text = "Scissors";
            }


            if (opponent == ROCK && choice == PAPER)
            {
                wins++;
            }
            else if ( opponent == PAPER && choice == SCISSORS)
            {
                wins++;
            }
            else if ( opponent == SCISSORS && choice == ROCK) 
            {
                wins++;
            }

            label2.Text = "Wins: " + wins.ToString();

            if (opponent == ROCK && choice == ROCK)
            {
                ties++;
            }
            else if (opponent == PAPER && choice == PAPER)
            {
                ties++;
            }
            else if (opponent == SCISSORS && choice == SCISSORS)
            {
                ties++;
            }
            
            label3.Text = "Ties: " + ties.ToString();

            if (opponent == ROCK && choice == SCISSORS)
            {
                losses++;
            }
            else if (opponent == PAPER && choice == ROCK)
            {
                losses++;
            }
            else if (opponent == SCISSORS && choice == PAPER)
            {
                losses++;
            }

            label4.Text = "Losses: " + losses.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
