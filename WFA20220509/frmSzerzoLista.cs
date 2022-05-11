using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA20220509
{
    public partial class FrmSzerzoLista : Form
    {
       
        public string ConnectionString { private get; set; }

        // A másik formból kapott elemek deklarálása.
        private FrmSzerzo FrmSzerzo { get; set; } = null;
        public FrmSzerzoLista(FrmSzerzo frmSzerzo)
        {
            FrmSzerzo = frmSzerzo;
            ConnectionString = "Server = (localdb)\\MSSQLLocalDB;" +
                               "Database = idezetek;";
            InitializeComponent();
            this.Icon = Properties.Resources.author;
        }

        

        private void frmSzerzoLista_Load(object sender, EventArgs e)
        {
            dgvload();
        }
        // DGV kiírása egy kereső textbox-al
        private void dgvload() 
        {
            dgv.Rows.Clear();
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand(
                   "SELECT szerzoID, nev " +
                   "FROM szerzo " +
                   $"WHERE nev LIKE '%{t_nev.Text}%' " +
                   "ORDER BY szerzoID; ", c).ExecuteReader();
                while (r.Read())
                {
                    dgv.Rows.Add(
                       r[0],
                       r[1]
                        );
                }
                r.Close();
            }
        }

        private void t_nev_TextChanged(object sender, EventArgs e)
        {
            dgvload();
        }

        //dgv elemeinek átadása a textbox-nak.
        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FrmSzerzo.t_id.Text = dgv[0, e.RowIndex].Value.ToString();
            FrmSzerzo.t_nev.Text = dgv[1, e.RowIndex].Value.ToString();
            this.Close();
        }

    }
}
