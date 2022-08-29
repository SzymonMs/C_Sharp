namespace Kalkulator
{
    public partial class Form1 : Form
    {
        string liczbaPierwsza,liczbaDruga;
        char znak = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
        }

        private void bWynik_Click(object sender, EventArgs e)
        {
            switch (znak)
            {
                case ('+'):
                    tbWynik.Text = (int.Parse(liczbaPierwsza)+int.Parse(liczbaDruga)).ToString();
                    break;
                case ('-'):
                    tbWynik.Text = (int.Parse(liczbaPierwsza) - int.Parse(liczbaDruga)).ToString();
                    break;
                case ('*'):
                    tbWynik.Text = (int.Parse(liczbaPierwsza) * int.Parse(liczbaDruga)).ToString();
                    break;
                case ('/'):
                    tbWynik.Text = (double.Parse(liczbaPierwsza) / double.Parse(liczbaDruga)).ToString();
                    break;
            }
            liczbaPierwsza = "";
            liczbaDruga = "";
            znak = ' ';
        }

        private void bMnozenie_Click(object sender, EventArgs e)
        {
            znak = '*';
            tbWynik.Text = "";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void bDzielenie_Click(object sender, EventArgs e)
        {
            znak = '/';
            tbWynik.Text = "";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        private void bOdejmowanie_Click(object sender, EventArgs e)
        {
            znak = '-';
            tbWynik.Text = "";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }

        private void bDodawanie_Click(object sender, EventArgs e)
        {
            znak = '+';
            tbWynik.Text = "";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }
        private void Dzialanie(int liczba)
        {
            if(znak == ' ')
            {
                liczbaPierwsza += liczba;
                tbWynik.Text = liczbaPierwsza;
            }
            else
            {
                liczbaDruga += liczba;
                tbWynik.Text = liczbaDruga;
            }

        }
    }
}