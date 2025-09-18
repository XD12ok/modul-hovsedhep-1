using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdul_HOVSEDEP_18_9_2025
{
    public partial class TableSeating : UserControl
    {
        public TableSeating()
        {
            InitializeComponent();
        }

        private void TableSeating_Load(object sender, EventArgs e)
        {

        }

        //private void LoadTable()
        //{
        //    try
        //    {
        //        string connStr = ConfigurationManager.ConnectionStrings["My_conn"].ConnectionString;

        //        using (SqlConnection conn = new SqlConnection(connStr))
        //        {
        //            conn.Open();

        //            string query = @"SELECT t.TableID, t.Name, t.Capacity, tr.TransactionID, tr.CustomerName, tr.Status
        //                            FROM RestaurantTables t
        //                            LEFT JOIN Transactions tr 
        //                            ON t.TableID = tr.TableID 
        //                            AND tr.Status IN ('Ongoing');";

        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                var reader = cmd.ExecuteReader();

        //                while (reader.Read())
        //                {
        //                    int tableId = reader.GetInt32(0);
        //                    object customerObj = reader.IsDBNull(4) ? null : reader.GetString(4);

        //                    bool occupied = customerObj != null;
        //                    string customer = occupied ? (string)customerObj : "";

        //                    foreach (Control c in pnlButton.Controls)
        //                    {
        //                        if (c is Button btn && btn.Tag != null && (int)btn.Tag == tableId)
        //                        {
        //                            btn.BackColor = occupied ? Color.Yellow : Color.LightGray;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error" + ex.Message);
        //    }
        //}
        //private void Table_Load(object sender, EventArgs e)
        //{
        //    A1.Tag = 1;
        //    A2.Tag = 2;
        //    A3.Tag = 3;
        //    A4.Tag = 4;
        //    B1.Tag = 5;
        //    B2.Tag = 6;
        //    C1.Tag = 7;
        //    C2.Tag = 8;

        //    foreach (Control c in pnlButton.Controls)
        //    {
        //        if (c is Button btn && btn.Tag != null)
        //        {
        //            btn.Click += TableButton_Click;
        //        }
        //    }

        //    LoadTable();
        //}

    }
}
