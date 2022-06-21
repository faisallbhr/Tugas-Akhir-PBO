using Npgsql;
namespace PapyKostFinal
{
    public abstract class dbHelper
    {
        protected NpgsqlConnection connection;
        internal dbHelper()
        {
            string connectionString = "Server=localhost;Database=papykost;Username=postgres;Password=sembuarang121";
            connection = new NpgsqlConnection(connectionString);
        }
    }
  
    public class dataOwners : dbHelper
    {
        public string[][] checkOwner()
        {
            List<string[]> data = new List<string[]>();
            string query = "select * from owners";
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            NpgsqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id_owner = dataReader.GetInt32(0);
                string nama = dataReader.GetString(1);
                string username = dataReader.GetString(2);
                string pw = dataReader.GetString(3);
                data.Add(new string[] { Convert.ToString(id_owner), nama, username, pw });
            }
            connection.Close();
            return data.ToArray();
        }
        public string[][] ShowData()
        {
            List<string[]> data = new List<string[]>();
            string query = "select * from kost";
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            NpgsqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id_kost = dataReader.GetInt32(0);
                int id_owner = dataReader.GetInt32(1);
                string nama = dataReader.GetString(2);
                int harga = dataReader.GetInt32(3);
                string lokasi = dataReader.GetString(4);
                int ketersediaan = dataReader.GetInt32(5);
                string keterangan = dataReader.GetString(6);
                data.Add(new string[] {Convert.ToString(id_kost), Convert.ToString(id_owner), nama, Convert.ToString(harga), lokasi, Convert.ToString(ketersediaan), keterangan });
            }
            connection.Close();
            return data.ToArray();
        }
        public string InsertData(int id_owner, string nama, int harga, string lokasi, int ketersediaan, string keterangan)
        {
            string query = "insert into kost(id_owner, nama, harga, lokasi, ketersediaan, keterangan) values (@id_owner, @nama, @harga, @lokasi, @ketersediaan, @keterangan)";
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id_owner", id_owner);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@lokasi", lokasi);
            cmd.Parameters.AddWithValue("@ketersediaan", ketersediaan);
            cmd.Parameters.AddWithValue("@keterangan", keterangan);
            cmd.ExecuteNonQuery();
            connection.Close();
            return "Data berhasil ditambahkan";
        }
        public string UpdateData(int id_kost, int id_owner, string nama, int harga, string lokasi, int ketersediaan, string keterangan)
        {
            string query = "update kost set id_owner = @id_owner, nama = @nama, harga = @harga, lokasi = @lokasi, ketersediaan = @ketersediaan, keterangan = @keterangan where id_kost = @id_kost";
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id_kost", id_kost);
            cmd.Parameters.AddWithValue("@id_owner", id_owner);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@lokasi", lokasi);
            cmd.Parameters.AddWithValue("@ketersediaan", ketersediaan);
            cmd.Parameters.AddWithValue("@keterangan", keterangan);
            cmd.ExecuteNonQuery();
            connection.Close();
            return "Data berhasil diubah";
        }
        public string DeleteData(int id_kost)
        {
            string query = "delete from kost where id_kost = @id_kost";
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id_kost", id_kost);
            cmd.ExecuteNonQuery();
            connection.Close();
            return "Data berhasil dihapus";
        }
        public string[][] showTransaksi()
        {
            List<string[]> data = new List<string[]>();
            string query = "select tr.id_transaksi, c.nama, k.nama, tr.jumlah_kamar, tr.lama_sewa, tr.tgl, k.id_owner from transaksi tr join kost k on tr.id_kost = k.id_kost join customers c on tr.id_customer = c.id_customer";
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int id_transaksi = dataReader.GetInt32(0);
                string nama_customer = dataReader.GetString(1);
                string nama_kost = dataReader.GetString(2);
                int jumlah_kamar = dataReader.GetInt32(3);
                int lama_sewa = dataReader.GetInt32(4);
                DateTime tgl = dataReader.GetDateTime(5);
                int id_owner = dataReader.GetInt32(6);
                data.Add(new string[] { Convert.ToString(id_transaksi), nama_customer, nama_kost, Convert.ToString(jumlah_kamar), Convert.ToString(lama_sewa), Convert.ToString(tgl), Convert.ToString(id_owner) });
            }
            connection.Close();
            return data.ToArray();
        }
        public string insertTransaksi(int id_customer, int id_kost, int jumlahKamar, int lamaSewa)
        {
            string query = "insert into transaksi (id_customer, id_kost, jumlah_kamar, lama_sewa, tgl) values (@id_customer, @id_kost, @jumlahKamar, @lamaSewa, now())";
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id_customer", id_customer);
            cmd.Parameters.AddWithValue("@id_kost", id_kost);
            cmd.Parameters.AddWithValue("@jumlahKamar", jumlahKamar);
            cmd.Parameters.AddWithValue("@lamaSewa", lamaSewa);
            cmd.ExecuteNonQuery();
            connection.Close();
            return "Transaksi berhasil";
        }
        public string deleteTransaksi(int id_kost)
        {
            string query = "delete from transaksi where id_kost = @id_kost";
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id_kost", id_kost);
            cmd.ExecuteNonQuery();
            connection.Close();
            return "Transaksi berhasil dihapus";
        }
    }
    public class dataCustomers : dbHelper
    {
        public string insertCustomer(string nama, string username, string pw, string noHp, string alamat, string kelamin)
        {
            string query = "insert into customers (nama, username, pw, noHp, alamat, kelamin) values (@nama, @username, @pw, @noHp, @alamat, @kelamin)";
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pw", pw);
            cmd.Parameters.AddWithValue("@noHp", noHp);
            cmd.Parameters.AddWithValue("@alamat", alamat);
            cmd.Parameters.AddWithValue("@kelamin", kelamin);
            cmd.ExecuteNonQuery();
            connection.Close();
            return "Register berhasil";
        }
        public string[][] checkCustomer()
        {
            List<string[]> data = new List<string[]>();
            string query = "select * from customers";
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            NpgsqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id_customer = dataReader.GetInt32(0);
                string nama = dataReader.GetString(1);
                string username = dataReader.GetString(2);
                string pw = dataReader.GetString(3);
                data.Add(new string[] { Convert.ToString(id_customer), nama, username, pw });
            }
            connection.Close();
            return data.ToArray();
        }
        public string hubOwner(int id_owner)
        {
            string query = "select * from owners where id_owner = @id_owner";
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id_owner", id_owner);
            NpgsqlDataReader dataReader = cmd.ExecuteReader();
            string nohp = "";
            while (dataReader.Read())
            {
                nohp = dataReader.GetString(4);
            }
            connection.Close();
            return nohp;
        }
        public string[][] showTransaksi()
        {
            List<string[]> data = new List<string[]>();
            string query = "select o.nama, ko.nama, tr.jumlah_kamar, tr.lama_sewa, ko.lokasi, o.nohp, tr.tgl, tr.id_customer from kost ko join transaksi tr on tr.id_kost = ko.id_kost join owners o on o.id_owner = ko.id_owner";
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string nama_owner = dataReader.GetString(0);
                string nama_kost = dataReader.GetString(1);
                int jumlah_kamar = dataReader.GetInt32(2);
                int lama_sewa = dataReader.GetInt32(3);
                string lokasi = dataReader.GetString(4);
                string nohp = dataReader.GetString(5);
                DateTime tgl = dataReader.GetDateTime(6);
                int id_customer = dataReader.GetInt32(7);
                data.Add(new string[] { nama_owner, nama_kost, Convert.ToString(jumlah_kamar), Convert.ToString(lama_sewa), lokasi, nohp, Convert.ToString(tgl), Convert.ToString(id_customer) });
            }
            connection.Close();
            return data.ToArray();
        }
    }
}
