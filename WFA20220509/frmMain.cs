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
    public partial class FrmMain : Form
    {
        //Csatlakozás az adatbázishoz. 
        public string ConnectionString { private get; set; }
        public FrmMain()
        {
            ConnectionString = "Server = (localdb)\\MSSQLLocalDB;" +
                               "Database = idezetek;";
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            datum();
        }

        private void datum()
        {
            // Aktuális dátum
            ldatum.Text = DateTime.Now.ToString("yyyy. MMM dd.");
            a();
        }
        private void a() 
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                //Adatbázis egy tábla tartalmának megszámlálása.
                c.Open();
                var r1 = new SqlCommand(
                    "SELECT Count(*) " +
                    "FROM idezet ", c);
                int count = Convert.ToInt32(r1.ExecuteScalar());
                lcount.Text = "Idézetek száma: " + count;

                //DB random szöveg lekérdezése.
                var r2 = new SqlCommand(
                    "SELECT top 1 CONCAT(i.szoveg,'\n(',f.cim,' ',sz.nev,')' ) " +
                    "FROM idezet i LEFT JOIN forras f ON i.forrasID = f.forrasID " +
                    "LEFT JOIN szerzo sz ON f.szerzoID = sz.szerzoID " +
                    "order by newid(); ", c);  
                    string szoveg = Convert.ToString(r2.ExecuteScalar());
                label_idezet.Text = szoveg;

                //DB egy elem tipus count-olása
                var r3 = new SqlCommand(
                    "SELECT t.megnevezes, COUNT(i.idezetID) " +
                    "FROM tema t LEFT JOIN utalas u ON t.temaID = u.temaID " +
                    "LEFT JOIN idezet i ON u.idezetID = i.idezetID " +
                    "GROUP BY t.megnevezes " +
                    "ORDER BY t.megnevezes; ", c).ExecuteReader();
                while (r3.Read()) 
                {
                    dgv1.Rows.Add(
                       r3[0],
                       r3[1]
                        );
                }
                r3.Close();
                
                //DB egy elem tipus count-olása. Ha egy érték 0 akkor ne jelenjen meg.
                var r4 = new SqlCommand(
                    "SELECT sz.nev, COUNT(i.forrasID) " +
                    "FROM szerzo sz LEFT JOIN forras f ON sz.szerzoID = f.szerzoID " +
                    "LEFT JOIN idezet i ON f.forrasID = i.forrasID " +
                    "GROUP BY sz.nev " +
                    "HAVING COUNT(i.forrasID) > 0 " +
                    "ORDER BY sz.nev; ", c).ExecuteReader();
                while (r4.Read())
                {
                    dgv2.Rows.Add(
                       r4[0],
                       r4[1]
                        );
                }
                r4.Close();
            }
            
        }
        //DGV frissítése
        private void dgvsrefresh()
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r3 = new SqlCommand(
                   "SELECT t.megnevezes, COUNT(i.idezetID) " +
                   "FROM tema t LEFT JOIN utalas u ON t.temaID = u.temaID " +
                   "LEFT JOIN idezet i ON u.idezetID = i.idezetID " +
                   "GROUP BY t.megnevezes " +
                   "ORDER BY t.megnevezes; ", c).ExecuteReader();
                while (r3.Read())
                {
                    dgv1.Rows.Add(
                       r3[0],
                       r3[1]
                        );
                }
                r3.Close();

                var r4 = new SqlCommand(
                    "SELECT sz.nev, COUNT(i.forrasID) " +
                    "FROM szerzo sz LEFT JOIN forras f ON sz.szerzoID = f.szerzoID " +
                    "LEFT JOIN idezet i ON f.forrasID = i.forrasID " +
                    "GROUP BY sz.nev " +
                    "HAVING COUNT(i.forrasID) > 0 " +
                    "ORDER BY sz.nev; ", c).ExecuteReader();
                while (r4.Read())
                {
                    dgv2.Rows.Add(
                       r4[0],
                       r4[1]
                        );
                }
            }
        }


        //Másik form ablak megnyitása.
        private void szerzőToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSzerzo f = new FrmSzerzo();
            f.Show();
        }

    }
}
