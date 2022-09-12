# Belajar C# Menggunakan Visual Studio

Pertemuan 3 | 12 September 2022

### Penjelasan Data Base

Database yang sudah dibuat diperlukan untuk membuat surat perjalanan dinas bagi para pegawai. Tabel yang ada seperti gambar berikut. 

![Untitled](Tugas%202%2055f2131e99aa47a89cb9698574a9d2b1/Untitled.png)

## Fitur yang akan digunakan

1. Login Admin
2. Menambahkan data pada pegawai (pada tabel pegawai)
3. Soon

## Fitur Login Admin

Pada percobaan login menggunakan visual studio.

```csharp
SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-3EQ7S2P;Initial Catalog=SuratPerjalananDinass;Integrated Security=True");
string query = "SELECT COUNT(*) FROM admins WHERE username='" + input_username.Text + "' AND password='" + input_password.Text + "'";
SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
DataTable dt = new DataTable(); //this is creating a virtual table  
sda.Fill(dt);
if (dt.Rows[0][0].ToString() == "1")
   { 
     this.Hide();
		}
 else
    {
		MessageBox.Show("Invalid username or password");
    }
```

![Untitled](Tugas%202%2055f2131e99aa47a89cb9698574a9d2b1/Untitled%201.png)

## Menambahkan data Pegawai

```csharp
private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-3EQ7S2P;Initial Catalog=SuratPerjalananDinass;Integrated Security=True");

            ;
            string nama = namaPegawai.Text;
            string nip = NIP.Text;
            string jabatan = Jabatan.Text;
            string golongan = Golongan.Text;
            string id = Inputid.Text;
            string query = "INSERT INTO PEGAWAI values ('" + id + "','" + nama + "','" + nip + "','"  + jabatan + "','" + golongan + "')";
            SqlCommand sda = new SqlCommand(query, sqlConnection);
            MySqlDataReader MyReader2;
            sqlConnection.Open();
            sda.ExecuteNonQuery();
            MessageBox.Show("Save Data");
}
```

![Gambaran Sederhana form input pegawai](Tugas%202%2055f2131e99aa47a89cb9698574a9d2b1/Untitled%202.png)

Gambaran Sederhana form input pegawai
