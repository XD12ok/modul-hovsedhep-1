using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdul_HOVSEDEP_18_9_2025
{
    public partial class HistoryUC : UserControl
    {
        public HistoryUC()
        {
            InitializeComponent();
        }

        private void HistoryUC_Load(object sender, EventArgs e)
        {
            LoadTransaction();
            LoadOrder();
        }

        private void LoadTransaction()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["My_conn"].ConnectionString))
            {
                conn.Open();
                string query = @"SELECT
                                t.TransactionID,
                                t.*,
                                rt.Name AS TableName,
                                od.Price
                                FROM Transactions t
                                INNER JOIN RestaurantTables rt
                                ON t.TableID = rt.TableID
                                INNER JOIN Orders o
                                ON t.TransactionID = o.TransactionID
                                INNER JOIN OrderDetails od
                                ON o.OrderID = od.OrderID;";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTrans.DataSource = dt;
                dgvTrans.Columns["TransactionID1"].Visible = false;
                dgvTrans.Columns["TableID"].Visible = false;
                dgvTrans.Columns["Status"].Visible = false;
            }
        }

        private void LoadOrder()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["My_conn"].ConnectionString))
            {
                conn.Open();
                string query = @"SELECT
                                t.TransactionID,
                                o,OrderTime,
                                o.OrderID,
                                o.EmployeeID,
                                e.Name,
                                od.Quantity
                                FROM 
                                Orders o INNER JOIN Transactions t
                                ON t.TransactionID = o.TransactionID
                                INNER JOIN OrderDetails od
                                ON o.OrderID = od.OrderID
                                INNER JOIN Orders o ON o.OrderDetailID = od.OrderID
                                ;";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOrder.DataSource = dt;
                //    dgvOrder.Columns["TransactionID1"].Visible = false;
                //    dgvOrder.Columns["TableID"].Visible = false;
                //    dgvOrder.Columns["Status"].Visible = false;
                //}
            }

        }
    }
}
