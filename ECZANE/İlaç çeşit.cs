using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECZANE
{
    public partial class İlaç_çeşitfrm : Form
    {
        public string constr= "Server=DESKTOP-PGSMO74; database=ECZANE;integrated security=true;";

        public İlaç_çeşitfrm()
        {
            InitializeComponent();
        }
        void grdtazele()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string sondurum = "select*from İlac_cesit order by İlac_ID desc";
            SqlDataAdapter sdp = new SqlDataAdapter(sondurum, con);
            DataTable dt = new DataTable();
            sdp.Fill(dt);
            dgilac.DataSource = dt;
            con.Close();
        }
      

        private void ekleado_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string strkomut = "insert into İlac_cesit (İlac_adı,İlac_turu,İlac_fiyat,Total_ilacs)" +
                "values(@vİlac_Adı,@vİlac_turu,@vİlac_fiyat,@vTotal_ilacs)";
            SqlCommand komutekle = new SqlCommand(strkomut, con);

            komutekle.Parameters.AddWithValue("@vİlac_adı", txtilacadı.Text);
            komutekle.Parameters.AddWithValue("@vİlac_turu", txtilacturu.Text);
            komutekle.Parameters.AddWithValue("@vİlac_fiyat", txtilacfiyat.Text);
            komutekle.Parameters.AddWithValue("@vTotal_ilacs", txt_totalilac.Text);

            komutekle.ExecuteNonQuery();
            con.Close();
            grdtazele();
               
        }

        private void ekleadosp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spilacekle";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@vİlac_adı", txtilacadı.Text);
            cmd.Parameters.AddWithValue("@vİlac_turu", txtilacturu.Text);
            cmd.Parameters.AddWithValue("@vİlac_fiyat", txtilacfiyat.Text);
            cmd.Parameters.AddWithValue("@vTotal_ilacs", txt_totalilac.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            grdtazele();
        }

        private void silado_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand komutsil = new SqlCommand();
            komutsil.Connection = con;
            komutsil.CommandText = "delete from İlac_cesit where İlac_ID=" + Convert.ToInt32(dgilac.CurrentRow.Cells[0].Value);
            komutsil.ExecuteNonQuery();
            con.Close();
            grdtazele();
            

                
        }

        private void İlaç_çeşitfrm_Load(object sender, EventArgs e)
        {
            grdtazele();
        }

        private void siladosp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spilacsil";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@vİlac_ID",Convert.ToInt32( txtilacıd.Text));
            cmd.Parameters.AddWithValue("@vİlac_adı", txtilacadı.Text);
            cmd.Parameters.AddWithValue("@vİlac_turu", txtilacturu.Text);
            cmd.Parameters.AddWithValue("@vİlac_fiyat", txtilacfiyat.Text);
            cmd.Parameters.AddWithValue("@vTotal_ilacs", txt_totalilac.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            grdtazele();


        }
    }
}
