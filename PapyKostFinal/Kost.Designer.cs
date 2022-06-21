namespace PapyKostFinal
{
    partial class Kost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kost));
            this.tabelKost = new System.Windows.Forms.DataGridView();
            this.id_kost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketersediaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jmlhSewaKamar = new System.Windows.Forms.TextBox();
            this.lamaSewa = new System.Windows.Forms.TextBox();
            this.uangCust = new System.Windows.Forms.TextBox();
            this.btnBayar = new System.Windows.Forms.Button();
            this.boxId = new System.Windows.Forms.TextBox();
            this.boxKeterangan = new System.Windows.Forms.TextBox();
            this.boxKetersediaan = new System.Windows.Forms.TextBox();
            this.boxLokasi = new System.Windows.Forms.TextBox();
            this.boxHarga = new System.Windows.Forms.TextBox();
            this.boxNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalBayar = new System.Windows.Forms.TextBox();
            this.logout = new System.Windows.Forms.LinkLabel();
            this.idCustomer = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRiwayat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelKost)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelKost
            // 
            this.tabelKost.AllowUserToAddRows = false;
            this.tabelKost.AllowUserToDeleteRows = false;
            this.tabelKost.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.tabelKost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelKost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_kost,
            this.id_owner,
            this.nama,
            this.harga,
            this.lokasi,
            this.ketersediaan,
            this.keterangan});
            this.tabelKost.Location = new System.Drawing.Point(115, 227);
            this.tabelKost.Name = "tabelKost";
            this.tabelKost.ReadOnly = true;
            this.tabelKost.RowTemplate.Height = 25;
            this.tabelKost.Size = new System.Drawing.Size(565, 195);
            this.tabelKost.TabIndex = 20;
            this.tabelKost.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tabelKost_RowHeaderMouseClick);
            // 
            // id_kost
            // 
            this.id_kost.HeaderText = "ID Kost";
            this.id_kost.Name = "id_kost";
            this.id_kost.ReadOnly = true;
            this.id_kost.Visible = false;
            // 
            // id_owner
            // 
            this.id_owner.HeaderText = "ID Owner";
            this.id_owner.Name = "id_owner";
            this.id_owner.ReadOnly = true;
            this.id_owner.Visible = false;
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // harga
            // 
            this.harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.harga.HeaderText = "Harga";
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            // 
            // lokasi
            // 
            this.lokasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lokasi.HeaderText = "Lokasi";
            this.lokasi.Name = "lokasi";
            this.lokasi.ReadOnly = true;
            // 
            // ketersediaan
            // 
            this.ketersediaan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ketersediaan.HeaderText = "Ketersediaan";
            this.ketersediaan.Name = "ketersediaan";
            this.ketersediaan.ReadOnly = true;
            // 
            // keterangan
            // 
            this.keterangan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keterangan.HeaderText = "Keterangan";
            this.keterangan.Name = "keterangan";
            this.keterangan.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(115, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Jumlah Sewa Kamar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(115, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lama Sewa (/bln)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(417, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Masukkan Uang Anda";
            // 
            // jmlhSewaKamar
            // 
            this.jmlhSewaKamar.Location = new System.Drawing.Point(251, 108);
            this.jmlhSewaKamar.Name = "jmlhSewaKamar";
            this.jmlhSewaKamar.Size = new System.Drawing.Size(134, 23);
            this.jmlhSewaKamar.TabIndex = 0;
            this.jmlhSewaKamar.TextChanged += new System.EventHandler(this.jmlhSewaKamar_TextChanged);
            // 
            // lamaSewa
            // 
            this.lamaSewa.Location = new System.Drawing.Point(251, 140);
            this.lamaSewa.Name = "lamaSewa";
            this.lamaSewa.Size = new System.Drawing.Size(134, 23);
            this.lamaSewa.TabIndex = 1;
            this.lamaSewa.TextChanged += new System.EventHandler(this.lamaSewa_TextChanged);
            // 
            // uangCust
            // 
            this.uangCust.Location = new System.Drawing.Point(546, 111);
            this.uangCust.Name = "uangCust";
            this.uangCust.Size = new System.Drawing.Size(134, 23);
            this.uangCust.TabIndex = 3;
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBayar.Location = new System.Drawing.Point(605, 165);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(75, 23);
            this.btnBayar.TabIndex = 4;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(12, 415);
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(10, 23);
            this.boxId.TabIndex = 37;
            this.boxId.Visible = false;
            // 
            // boxKeterangan
            // 
            this.boxKeterangan.Location = new System.Drawing.Point(76, 415);
            this.boxKeterangan.Name = "boxKeterangan";
            this.boxKeterangan.Size = new System.Drawing.Size(10, 23);
            this.boxKeterangan.TabIndex = 36;
            this.boxKeterangan.Visible = false;
            // 
            // boxKetersediaan
            // 
            this.boxKetersediaan.Location = new System.Drawing.Point(92, 415);
            this.boxKetersediaan.Name = "boxKetersediaan";
            this.boxKetersediaan.Size = new System.Drawing.Size(10, 23);
            this.boxKetersediaan.TabIndex = 35;
            this.boxKetersediaan.Visible = false;
            // 
            // boxLokasi
            // 
            this.boxLokasi.Location = new System.Drawing.Point(60, 415);
            this.boxLokasi.Name = "boxLokasi";
            this.boxLokasi.Size = new System.Drawing.Size(10, 23);
            this.boxLokasi.TabIndex = 34;
            this.boxLokasi.Visible = false;
            // 
            // boxHarga
            // 
            this.boxHarga.Location = new System.Drawing.Point(44, 415);
            this.boxHarga.Name = "boxHarga";
            this.boxHarga.Size = new System.Drawing.Size(10, 23);
            this.boxHarga.TabIndex = 33;
            this.boxHarga.Visible = false;
            // 
            // boxNama
            // 
            this.boxNama.Location = new System.Drawing.Point(28, 415);
            this.boxNama.Name = "boxNama";
            this.boxNama.Size = new System.Drawing.Size(10, 23);
            this.boxNama.TabIndex = 32;
            this.boxNama.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(115, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Total Bayar";
            // 
            // totalBayar
            // 
            this.totalBayar.Location = new System.Drawing.Point(251, 170);
            this.totalBayar.Name = "totalBayar";
            this.totalBayar.Size = new System.Drawing.Size(134, 23);
            this.totalBayar.TabIndex = 2;
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Location = new System.Drawing.Point(727, 9);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(45, 15);
            this.logout.TabIndex = 39;
            this.logout.TabStop = true;
            this.logout.Text = "Logout";
            this.logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_LinkClicked);
            // 
            // idCustomer
            // 
            this.idCustomer.Location = new System.Drawing.Point(12, 386);
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.Size = new System.Drawing.Size(10, 23);
            this.idCustomer.TabIndex = 40;
            this.idCustomer.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 386);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 23);
            this.textBox1.TabIndex = 41;
            this.textBox1.Visible = false;
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRiwayat.Location = new System.Drawing.Point(546, 198);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(134, 23);
            this.btnRiwayat.TabIndex = 42;
            this.btnRiwayat.Text = "Riwayat Transaksi";
            this.btnRiwayat.UseVisualStyleBackColor = false;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // Kost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.idCustomer);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.totalBayar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxId);
            this.Controls.Add(this.boxKeterangan);
            this.Controls.Add(this.boxKetersediaan);
            this.Controls.Add(this.boxLokasi);
            this.Controls.Add(this.boxHarga);
            this.Controls.Add(this.boxNama);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.uangCust);
            this.Controls.Add(this.lamaSewa);
            this.Controls.Add(this.jmlhSewaKamar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabelKost);
            this.Name = "Kost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kost";
            this.Load += new System.EventHandler(this.Kost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelKost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tabelKost;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox jmlhSewaKamar;
        private TextBox lamaSewa;
        private TextBox uangCust;
        private Button btnBayar;
        private TextBox boxId;
        private TextBox boxKeterangan;
        private TextBox boxKetersediaan;
        private TextBox boxLokasi;
        private TextBox boxHarga;
        private TextBox boxNama;
        private Label label4;
        private TextBox totalBayar;
        private LinkLabel logout;
        private TextBox idCustomer;
        private DataGridViewTextBoxColumn id_kost;
        private DataGridViewTextBoxColumn id_owner;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn harga;
        private DataGridViewTextBoxColumn lokasi;
        private DataGridViewTextBoxColumn ketersediaan;
        private DataGridViewTextBoxColumn keterangan;
        private TextBox textBox1;
        private Button btnRiwayat;
    }
}