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
    public partial class FrmSzerzo : Form
    {
        public string ConnectionString { private get; set; }
        public FrmSzerzo()
        {
            ConnectionString = "Server = (localdb)\\MSSQLLocalDB;" +
                               "Database = idezetek;";
            InitializeComponent();

            this.Icon = Properties.Resources.author;

        }

        //Másik form megynitása a formon található elemekkel együtt.
        
        //Más formok átadáasa esetén a Propertiesben a Modifiers publicba kell tenni.
        //(pl.: textbox).
        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
            => new FrmSzerzoLista(this).ShowDialog();

        private void frmSzerzo_Load(object sender, EventArgs e)
        {

        }
       
        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Nem lehet üres a test box 
            if (String.IsNullOrEmpty(t_nev.Text))
            {
                MessageBox.Show("A név mező nem lehet ürés");
            }
            else
            {
                
                using (var c = new SqlConnection(ConnectionString))
                {
                    // adatfelvétele úggy hogy a max ID+1 mivel új adat kerül fel
                    if (String.IsNullOrEmpty(t_id.Text))
                    {
                        c.Open();
                        var r1 = new SqlCommand(
                            "SELECT MAX(szerzoID) FROM szerzo; ", c);
                        int max = Convert.ToInt32(r1.ExecuteScalar()) + 1;
                        
                        var r2 = new SqlCommand(
                            "INSERT INTO szerzo(szerzoID, nev) VALUES " +
                            $"('{max}','{t_nev.Text}') ", c).ExecuteReader();
                        MessageBox.Show("Sikeres mentés!");
                        t_id.Text = Convert.ToString(max);
                    }
                    else 
                    {
                        // Adat modosítása
                        c.Open();
                        var r3 = new SqlCommand(
                            $"UPDATE szerzo SET nev = '{t_nev.Text}' " +
                            $"WHERE szerzoID = {t_id.Text} ", c).ExecuteReader();
                        MessageBox.Show("Sikeres modosítás!");
                    }
                }
            }
           
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Adattörlés a DB-ből egy yes or no textboxal
            DialogResult dialogResult = MessageBox.Show("Biztosan törli az állomány?", "Törlés",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    var r4 = new SqlCommand(
                        $"DELETE FROM szerzo " +
                        $"WHERE szerzoID = {t_id.Text} ", c).ExecuteReader();
                    MessageBox.Show("Álomány törölve!");
                    t_id.Clear();
                    t_nev.Clear();
                }
            }
           
        }

        //Gomb disable, ha nincs a textboxban adat.
        private void t_nev_TextChanged(object sender, EventArgs e)
        {
            bt_torles.Enabled = !string.IsNullOrWhiteSpace(t_nev.Text);
        }
        //Textbox-ok kitakarítása.
        private void üresŰrlapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t_id.Clear();
            t_nev.Clear();
        }
    }
}
