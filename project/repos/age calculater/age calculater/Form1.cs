namespace age_calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentyear = Convert.ToInt32(textBox1.Text);
            int birthyear = Convert.ToInt32(textBox2.Text);

            int years = currentyear - birthyear;
            int month = years * 12;
            int weeks = month * 4;
            int days = weeks * 7;
            int hours = days * 24;
            int minutes = hours * 60;
            int seconds = minutes * 60;


            yrs.Text = years.ToString();
            mon.Text = month.ToString();
            wks.Text = weeks.ToString();
            dys.Text = days.ToString();
            hrs.Text = hours.ToString();
            min.Text = minutes.ToString();
            sec.Text = seconds.ToString();











        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
