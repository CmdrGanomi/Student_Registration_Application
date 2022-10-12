namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int month = 1; month <= 12; month++)
            {
                comboMonth.Items.Add(month.ToString());
            }

            for (int year = 1900; year <= 2022; year++)
            {
                comboYear.Items.Add(year.ToString());
            }

            for (int day = 1; day < 32; day++)
            {
                comboDay.Items.Add(day.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName = lastNameBox.Text;
            string firstName = firstNameBox.Text;
            string middleName = middleNameBox.Text;
            string male = radMale.Text;
            string female = radFemale.Text;

            int day = int.Parse(comboDay.Text);
            int month = int.Parse(comboMonth.Text);
            int year = int.Parse(comboYear.Text);

            if (radMale.Checked == true)
            {
                MessageBox.Show("Student name: " + firstName + " " + middleName + " " + lastName + "\nGender: " + male + "\nDate of Birth: " + day + "/" + month + "/" + year);
            }
            else
            {
                MessageBox.Show("Student name: " + firstName + " " + middleName + " " + lastName + "\nGender: " + female + "\nDate of Birth: " + day + "/" + month + "/" + year);
            }
        }
    }
}