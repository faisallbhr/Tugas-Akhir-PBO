namespace PapyKostFinal
{
    public partial class Kost : Form
    {
        public Kost()
        {
            InitializeComponent();
            
        }
        public Kost(string fkCustomer)
            : this()
        {
            {
                idCustomer.Text = fkCustomer;
            }
        }
        private void Kost_Load(object sender, EventArgs e)
        {
            dataOwners db = new dataOwners();
            string[][] data = db.ShowData();
            foreach (string[] row in data)
            {
                tabelKost.Rows.Add(row);
            }
        }
        private void tabelKost_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            boxId.Text = tabelKost.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = tabelKost.Rows[e.RowIndex].Cells[1].Value.ToString();
            boxNama.Text = tabelKost.Rows[e.RowIndex].Cells[2].Value.ToString();
            boxHarga.Text = tabelKost.Rows[e.RowIndex].Cells[3].Value.ToString();
            boxLokasi.Text = tabelKost.Rows[e.RowIndex].Cells[4].Value.ToString();
            boxKetersediaan.Text = tabelKost.Rows[e.RowIndex].Cells[5].Value.ToString();
            boxKeterangan.Text = tabelKost.Rows[e.RowIndex].Cells[6].Value.ToString();    
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

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(boxKetersediaan.Text) >= Convert.ToInt32(jmlhSewaKamar.Text))
            {
                int total = Convert.ToInt32(boxHarga.Text) * Convert.ToInt32(lamaSewa.Text) * Convert.ToInt32(jmlhSewaKamar.Text); 
                if (Convert.ToInt32(uangCust.Text) >= total)
                {
                    dataOwners db = new dataOwners();
                    int sisaKamar = Convert.ToInt32(boxKetersediaan.Text) - Convert.ToInt32(jmlhSewaKamar.Text);
                    db.UpdateData(Convert.ToInt32(boxId.Text), Convert.ToInt32(textBox1.Text), boxNama.Text, Convert.ToInt32(boxHarga.Text), boxLokasi.Text, Convert.ToInt32(sisaKamar), boxKeterangan.Text);
                    int kembalian = Convert.ToInt32(uangCust.Text) - total;

                    dataCustomers db2 = new dataCustomers();
                    string hubungi = db2.hubOwner(Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("Selamat pembayaran anda telah berhasil" + "\nKembalian : " + kembalian + "\nSilahkan hubungi : " + hubungi, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.insertTransaksi(Convert.ToInt32(idCustomer.Text), Convert.ToInt32(boxId.Text), Convert.ToInt32(jmlhSewaKamar.Text), Convert.ToInt32(lamaSewa.Text));
                    tabelKost.Rows.Clear();
                    Kost_Load(sender, e);
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Uang tidak cukup", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kamar yang dipesan tidak mencukupi", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            jmlhSewaKamar.Text = "";
            lamaSewa.Text = "";
            totalBayar.Text = "";
            uangCust.Text = "";

        }

        private void lamaSewa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int total = Convert.ToInt32(boxHarga.Text) * Convert.ToInt32(lamaSewa.Text) * Convert.ToInt32(jmlhSewaKamar.Text);
                totalBayar.Text = total.ToString();
            }
            catch 
            {
                totalBayar.Text = "";
            }
        }

        private void jmlhSewaKamar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int total = Convert.ToInt32(boxHarga.Text) * Convert.ToInt32(lamaSewa.Text) * Convert.ToInt32(jmlhSewaKamar.Text);
                totalBayar.Text = total.ToString();
            }
            catch
            {
                totalBayar.Text = "";
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            this.Close();
            RiwayatTransaksi rt = new RiwayatTransaksi(idCustomer.Text);
            rt.Show();
        }
    }
}
