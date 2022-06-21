namespace PapyKostFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            dataCustomers db = new dataCustomers();
            string[][] datas = db.checkCustomer();
            int fkCustomer = 0;
            bool success = false;
            foreach (string[] data in datas)
            {
                if (usernameBox.Text == data[2] && pwBox.Text == data[3])
                {
                    success = true;
                    fkCustomer += Convert.ToInt32(data[0]);
                }
                
            }
            textBox1.Text = fkCustomer.ToString();
            if (success)
            {
                Kost kostForm = new Kost(textBox1.Text);
                this.Close();
                kostForm.Show();
                
            }
            else
            {
                MessageBox.Show("Username atau password salah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameBox.Text = "";
                pwBox.Text = "";
            }
        }

        private void loginAsOwner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Owner ownerForm = new Owner();
            ownerForm.Show();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Register registerForm = new Register();
            registerForm.Show();
        }
    }
}