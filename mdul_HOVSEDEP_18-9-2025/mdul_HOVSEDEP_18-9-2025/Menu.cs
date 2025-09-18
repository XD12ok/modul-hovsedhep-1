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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            loadMenu();
            LoadFilter();
        }

        private void loadMenu()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["My_conn"].ConnectionString))
            {
                conn.Open();
                string query = @"SELECT
                                 MenuItems.MenuItemID,
                                 MenuItems.Name,
                                 MenuItems.Price,
                                 MenuItems.Description,
                                 Categories.Name AS Category
                                 FROM MenuItems INNER JOIN Categories ON MenuItems.CategoryID = Categories.CategoryID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMenu.DataSource = dt;
            }
        }

        private void LoadFilter()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["My_conn"].ConnectionString)) 
            {
                conn.Open();
                string query = "SELECT * FROM Categories";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CmbCategory.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
        }

        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["My_conn"].ConnectionString))
            {
                string cmb = CmbCategory.Text.Trim();
                conn.Open();
                string querry = @"SELECT DISTINCT
                                  MenuItems.*,
                                  Categories.Name AS Category
                                  FROM MenuItems INNER JOIN Categories ON Menuitems.CategoryID = Categories.CategoryID WHERE Categories.Name LIKE @cmb";
                SqlDataAdapter da = new SqlDataAdapter(querry, conn);
                da.SelectCommand.Parameters.AddWithValue("@cmb", "%" + cmb + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                dgvMenu.DataSource= dt;
                dgvMenu.Columns["CategoryID"].Visible = false;
              
            }
        }

        

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["My_conn"].ConnectionString))
            {
                string src = SearchTxt.Text.Trim();
                conn.Open();
                string querry = @"SELECT DISTINCT
                                  MenuItems.*,
                                  Categories.Name AS Category
                                  FROM MenuItems INNER JOIN Categories ON Menuitems.CategoryID = Categories.CategoryID WHERE MenuItems.Name LIKE @src";
                SqlDataAdapter da = new SqlDataAdapter(querry, conn);
                da.SelectCommand.Parameters.AddWithValue("@src", "%" + src + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);


                dgvMenu.DataSource = dt;
                dgvMenu.Columns["CategoryID"].Visible = false;

            }
        }
    }
}
