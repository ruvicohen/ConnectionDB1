using Microsoft.Data.SqlClient;
using System.Data;

namespace ConnectionDB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDB();
        }
        string conectionString;
        public void LoadDB()
        {

            conectionString = "Server = DESKTOP-6ECC91R;Initial catalog=Demo; User Id=sa; Password = 1234;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(conectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from table1", conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
