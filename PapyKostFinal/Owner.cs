namespace PapyKostFinal
{
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            dataOwners db = new dataOwners();
            string username = usernameBox.Text;
            string pw = pwBox.Text;
            string[][] datas = db.checkOwner();
            int fkOwner = 0;
            bool success = false;
            foreach (string[] data in datas)
            {
                if (usernameBox.Text == data[2] && pwBox.Text == data[3])
                {
                    success = true;
                    fkOwner = Convert.ToInt32(data[0]);
                }
            }
            textBox1.Text = fkOwner.ToString();
            if (success)
            {
                OwnerSet ownerForm = new OwnerSet(textBox1.Text);
                this.Close();
                ownerForm.Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameBox.Text = "";
                pwBox.Text = "";
            }
        }

        private void backBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
