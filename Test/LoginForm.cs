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
    public partial class LoginForm : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=desktop-tmsua1o;Initial Catalog=studenttest;Integrated Security=True");
        private SqlDataAdapter sda = null;
        private DataTable dt = null;
        private TextBox send;
        public LoginForm(TextBox tex)
        {
            send = tex;
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            bool succes = false;
            
            try
            {
                const string comm= "select * from UserForm, LoginForm where (UserName=@login and Password=@pass and UserID=UID)";
                SqlCommand auth = new SqlCommand(comm, conn);
                auth.Parameters.AddWithValue("@login", textBox1.Text);
                auth.Parameters.AddWithValue("@pass", textBox2.Text);
                conn.Open();

                using (var dataReader = auth.ExecuteReader())
                {
                    succes = dataReader.Read();
                    
                }
            }
            finally
            {
                conn.Close();
            }
            if (succes==true)
            {
                send.Text = textBox1.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверные логин или пароль");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
