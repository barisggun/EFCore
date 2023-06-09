using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml;

namespace _01_EntityMappingKavrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //DAPPER OPEN
            SqlConnection cn = new SqlConnection("server=LAPTOP-TKFJC4RO\\SQLEXPRESS;database=Northwind;Trusted_Connection=true;");

            string sql = "select * from dbo.Categories";

            SqlCommand cmd = new SqlCommand(sql, cn);

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("CategoryId", typeof(int));
            dataTable.Columns.Add("CategoryName", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));

            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataTable.Rows.Add(reader["CategoryId"], reader["CategoryName"], reader["Description"]);
            }

            cn.Close();

            List<Category> categories = new List<Category>();

            //Mapping Kavram�
            foreach (DataRow row in dataTable.Rows)
            {
                Category category = new Category();

                category.CategoryId = Convert.ToInt32(row["CategoryId"].ToString());
                category.CategoryName = row["CategoryName"].ToString();
                category.Description = row["Description"].ToString();
            

            }
            //DAPPER CLOSE--


            //LINQ OPEN 

        }
    }
}

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
}