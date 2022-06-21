namespace PapyKostFinal
{
    public partial class OwnerSet : Form
    {
        public OwnerSet()
        {
            InitializeComponent();
        }
        public OwnerSet(string fkOwner)
            : this()
        {
            {
                textBox1.Text = fkOwner;
            }
        }
        private void OwnerSet_Load(object sender, EventArgs e)
        {
            dataOwners db = new dataOwners();
            string[][] data = db.ShowData();
            foreach (string[] row in data)
            {
                if (row[1] == textBox1.Text)
                {
                    tabelKost.Rows.Add(row[0], row[1] = textBox1.Text, row[2], row[3], row[4], row[5], row[6]);
                }
            }
        }
        private void ClearData()
        {
            boxId.Text = "";
            boxNama.Text = "";
            boxHarga.Text = "";
            boxLokasi.Text = "";
            boxKetersediaan.Text = "";
            boxKeterangan.Text = "";
        }
        private void tabelKost_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            boxId.Text = tabelKost.Rows[e.RowIndex].Cells[0].Value.ToString();
            boxNama.Text = tabelKost.Rows[e.RowIndex].Cells[2].Value.ToString();
            boxHarga.Text = tabelKost.Rows[e.RowIndex].Cells[3].Value.ToString();
            boxLokasi.Text = tabelKost.Rows[e.RowIndex].Cells[4].Value.ToString();
            boxKetersediaan.Text = tabelKost.Rows[e.RowIndex].Cells[5].Value.ToString();
            boxKeterangan.Text = tabelKost.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (boxNama.Text == "" && boxHarga.Text == "" && boxLokasi.Text == "" && boxKetersediaan.Text == "" && boxKeterangan.Text == "")
                {
                    MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataOwners db = new dataOwners();
                    string result = db.InsertData(Convert.ToInt32(textBox1.Text), boxNama.Text, Convert.ToInt32(boxHarga.Text), boxLokasi.Text, Convert.ToInt32(boxKetersediaan.Text), boxKeterangan.Text);
                    MessageBox.Show(result, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabelKost.Rows.Clear();
                    OwnerSet_Load(sender, e);
                    ClearData();
                }
            }
            catch
            {
                MessageBox.Show("Nama kost tidak boleh sama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (boxNama.Text == "" && boxHarga.Text == "" && boxLokasi.Text == "" && boxKetersediaan.Text == "" && boxKeterangan.Text == "")
                {
                    MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataOwners db = new dataOwners();
                    string result = db.UpdateData(Convert.ToInt32(boxId.Text), Convert.ToInt32(textBox1.Text), boxNama.Text, Convert.ToInt32(boxHarga.Text), boxLokasi.Text, Convert.ToInt32(boxKetersediaan.Text), boxKeterangan.Text);
                    MessageBox.Show(result, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabelKost.Rows.Clear();
                    OwnerSet_Load(sender, e);
                    ClearData();
                }
            }
            catch
            {
                MessageBox.Show("Nama Kost tidak boleh sama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dataOwners db = new dataOwners();
                db.deleteTransaksi(Convert.ToInt32(boxId.Text));
                string result = db.DeleteData(Convert.ToInt32(boxId.Text));
                MessageBox.Show(result, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabelKost.Rows.Clear();
                OwnerSet_Load(sender, e);
                ClearData();
            }
            catch
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            this.Close();
            Transaksi formTransaksi = new Transaksi(textBox1.Text);
            formTransaksi.Show();
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
