using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_Windows_From
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source=ZULFAAA;database=CRUD prodiTI;User ID=sa;Password=zulfa138");
        private void button1_Click(object sender, EventArgs e)
        {
            String NamaLengkap = txtNm.Text,
                Nim = txtNim.Text,
                Kelas = txtKls.Text,
                Angkatan = txtAng.Text,
                JenisKelamin = txtAng.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("exec BU '" + NamaLengkap + "','" + Nim + "','" + Kelas + "','" + Angkatan + "','" + JenisKelamin + "','");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sukses ");
            GetList();


        }
        void GetList()
        {
            SqlCommand cmd = new SqlCommand("exec ListData", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
