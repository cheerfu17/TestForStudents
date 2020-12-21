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

namespace Test
{
    public partial class ResDataGrid : Form
    {
        public ResDataGrid()
        {
            InitializeComponent();
        }


        private SqlConnection conn = null;
        private SqlDataAdapter sda = null;
        private DataTable dt = null;
        private SqlCommand comm = null;

        private void ResDataGrid_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=desktop-tmsua1o;Initial Catalog=studenttest;Integrated Security=True");
            comm = new SqlCommand("select UserName as [Имя пользователя], Result as [Результаты], ResultDate as [Дата результата] from ResultForm", conn);
            sda = new SqlDataAdapter(comm);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            

        }
    }
}
