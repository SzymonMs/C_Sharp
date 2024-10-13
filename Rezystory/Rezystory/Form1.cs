namespace Rezystory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();




        }
        string omegaUpper = "\u03A9";
        string plusMinus = "\u00B1";
        float[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        float[] multipliers = { 0, 1, 2, 3, 4, 5, 6, 7, -1, -2 };
        float[] tolerances = { 1, 2, 0.5f, 0.25f, 0.1f, 0.05f, 5, 10, 20 };
        float[] ppms = { 100, 50, 15, 25, 10, 5 };
        string[] strip_12_colors = { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Gray", "White" };
        string[] strip_3_colors = { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Gold", "Silver" };
        string[] strip_4_colors = { "Brown", "Red", "Green", "Blue", "Indigo", "Gray", "Gold", "Silver", "No color" };
        string[] strip_6_colors = { "Brown", "Red", "Orange", "Yellow", "Blue", "Indigo" };


        private void PicturBoxColorChange(PictureBox pix, string txt)
        {
            switch (txt)
            {

                case "Black":
                    pix.BackColor = Color.Black; break;
                case "Brown":
                    pix.BackColor = Color.SaddleBrown; break;
                case "Red":
                    pix.BackColor = Color.Red; break;
                case "Orange":
                    pix.BackColor = Color.Coral; break;
                case "Green":
                    pix.BackColor = Color.Green; break;
                case "Blue":
                    pix.BackColor = Color.Blue; break;
                case "Indigo":
                    pix.BackColor = Color.Indigo; break;
                case "White":
                    pix.BackColor = Color.White; break;
                case "Gray":
                    pix.BackColor = Color.Gray; break;
                case "Silver":
                    pix.BackColor = Color.Silver; break;
                case "Gold":
                    pix.BackColor = Color.Gold; break;
                case "Yellow":
                    pix.BackColor = Color.Yellow; break;
                case "No color":
                    pix.BackColor = Color.AliceBlue; break;
                default:
                    pix.BackColor = Color.DodgerBlue; break;
            }
        }
        private float returnValueFromColor(string text, float[] values, string[] colors)
        {
            float val = 0.0f;
            if (values.Length == colors.Length)
            {

                for (int i = 0; i < colors.Length; i++)
                {
                    if (text == colors[i])
                    {

                        val = values[i];
                    }
                }
            }
            return val;
        }

        private void color_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicturBoxColorChange(pictureBox1, color_1.SelectedItem.ToString());
        }
        private void color_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicturBoxColorChange(pictureBox2, color_2.SelectedItem.ToString());
        }
        private void color_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicturBoxColorChange(pictureBox3, color_3.SelectedItem.ToString());
        }
        private void color_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicturBoxColorChange(pictureBox4, color_4.SelectedItem.ToString());
        }
        private void color_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicturBoxColorChange(pictureBox5, color_5.SelectedItem.ToString());
        }
        private void color_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicturBoxColorChange(pictureBox6, color_6.SelectedItem.ToString());
        }

        private void calculation_Click(object sender, EventArgs e)
        {

            float digit1 = returnValueFromColor(color_1.SelectedItem.ToString(), digits, strip_12_colors);
            float digit2 = returnValueFromColor(color_2.SelectedItem.ToString(), digits, strip_12_colors);
            float multiplier = returnValueFromColor(color_3.SelectedItem.ToString(), multipliers, strip_3_colors);
            float tolerance = returnValueFromColor(color_4.SelectedItem.ToString(), tolerances, strip_4_colors);


            if (numberOfStrips.SelectedItem.ToString() == "4")
            {
                double newValue = Math.Round((digit1 * 10 + digit2) * Math.Pow(10, multiplier), 3);
                if (newValue < 1000)
                {
                    resistance.Text = newValue.ToString() + omegaUpper + " " + plusMinus + tolerance.ToString() + "%";
                }
                else if (newValue >= 1000 && newValue < 1000000)
                {
                    newValue = newValue / 1000.0f;
                    resistance.Text = newValue.ToString() + "k" + omegaUpper + " " + plusMinus + tolerance.ToString() + "%";
                }
                else if (newValue >= 1000000)
                {
                    newValue = newValue / 1000000.0f;
                    resistance.Text = newValue.ToString() + "M" + omegaUpper + " " + plusMinus + tolerance.ToString() + "%";
                }
            }
            if (numberOfStrips.SelectedItem.ToString() == "5")
            {
                float digit3 = returnValueFromColor(color_5.SelectedItem.ToString(), digits, strip_12_colors);
                double newValue = Math.Round((digit1 * 100 + digit2 * 10 + digit3) * Math.Pow(10, multiplier), 3);
                if (newValue < 1000)
                {
                    resistance.Text = newValue.ToString() + omegaUpper + " " + plusMinus + tolerance.ToString() + "%";
                }
                else if (newValue >= 1000 && newValue < 1000000)
                {
                    newValue = newValue / 1000.0f;
                    resistance.Text = newValue.ToString() + "k" + omegaUpper + " " + plusMinus + tolerance.ToString() + "%";
                }
                else if (newValue >= 1000000)
                {
                    newValue = newValue / 1000000.0f;
                    resistance.Text = newValue.ToString() + "M" + omegaUpper + " " + plusMinus + tolerance.ToString() + "%";
                }

            }
            if (numberOfStrips.SelectedItem.ToString() == "6")
            {
                float digit3 = returnValueFromColor(color_5.SelectedItem.ToString(), digits, strip_12_colors);
                float ppm = returnValueFromColor(color_6.SelectedItem.ToString(), ppms, strip_6_colors);
                double newValue = Math.Round((digit1 * 100 + digit2 * 10 + digit3) * Math.Pow(10, multiplier), 3);
                if (newValue < 1000)
                {
                    resistance.Text = newValue.ToString() + omegaUpper + " " + plusMinus + tolerance.ToString() + "%" + ppm.ToString() + "ppm";
                }
                else if (newValue >= 1000 && newValue < 1000000)
                {
                    newValue = newValue / 1000.0f;
                    resistance.Text = newValue.ToString() + "k" + omegaUpper + " " + plusMinus + tolerance.ToString() + "%" + ppm.ToString() + "ppm";
                }
                else if (newValue >= 1000000)
                {
                    newValue = newValue / 1000000.0f;
                    resistance.Text = newValue.ToString() + "M" + omegaUpper + " " + plusMinus + tolerance.ToString() + "% " + ppm.ToString() + "ppm";
                }

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numberOfStrips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numberOfStrips.SelectedItem.ToString() == "4")
            {
                color_5.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                color_6.Visible = false;
                color_5_txt.Visible = false;
                color_6_txt.Visible = false;
            }
            if (numberOfStrips.SelectedItem.ToString() == "5")
            {
                color_5.Visible = true;
                color_6.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                color_5_txt.Visible = true;
                color_6_txt.Visible = false;
            }
            if (numberOfStrips.SelectedItem.ToString() == "6")
            {
                color_5.Visible = true;
                color_6.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                color_5_txt.Visible = true;
                color_6_txt.Visible = true;
            }
        }
    }
}