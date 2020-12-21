using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Data.SqlClient;

namespace Test
{
    public partial class MainWin : Form
    {
        public string filePath = "";
        string curFile = Directory.GetCurrentDirectory() + @"\score.txt";

        //названия тем
        public string[] themes = { "1. Переменные и типы данных", "2. Циклы", "3. Массивы", "4. Операторы и выражения", "5. ООП" };

        public MainWin()
        {
            //создание нового файла если его не существует в папке с exe файлом
            if (File.Exists(curFile) == false)
            {
                File.AppendAllText("score.txt", "");
                Thread.Sleep(2000);


            }
            filePath = curFile;

            InitializeComponent();
            DataUpdate();
        }

        //запуск выбранного пользователем теста, пока только один
        private void button1_Click(object sender, EventArgs e)
        {
            Test1 t1 = new Test1(listBox1, listBox2, filePath);
            Test2 t2 = new Test2(listBox1, listBox2, filePath);
            Test3 t3 = new Test3(listBox1, listBox2, filePath);
            Test4 t4 = new Test4(listBox1, listBox2, filePath);
            Test5 t5 = new Test5(listBox1, listBox2, filePath);
            //берет значение индекса активной строки в listbox, потом используется для выбора темы
            int nTest = listBox1.SelectedIndex + 1;


            switch (nTest)
            {
                case 1:
                    t1.Show();
                    break;
                case 2:
                    t2.Show();
                    break;
                case 3:
                    t3.Show();
                    break;
                case 4:
                    t4.Show();
                    break;
                case 5:
                    t5.Show();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, "");
            listBox2.Items.Clear();
        }
        private SqlConnection conn = new SqlConnection(@"Data Source=desktop-tmsua1o;Initial Catalog=studenttest;Integrated Security=True");
        private SqlDataAdapter sda = null;
        private DataTable dt = null;
        private SqlCommand comm = new SqlCommand();
        public void DataUpdate()
        {
            //импорт строк из файла в массив
            string[] readText = File.ReadAllLines(filePath);
            //запись тем в listbox
            listBox1.Items.Clear();
            listBox1.Items.AddRange(themes);
            //запись результатов в listbox
            listBox2.Items.Clear();
            listBox2.Items.AddRange(readText);

            //devbuild edit. добавляем интеграцию резульятов в бд.
            conn = new SqlConnection(@"Data Source=desktop-tmsua1o;Initial Catalog=studenttest;Integrated Security=True");
            conn.Open();
            comm = new SqlCommand("INSERT INTO ResultForm (UserName, Result, ResultDate)" +
                    "VALUES (@Title, @Date, @Author, @Summary)", conn);
            comm.Parameters.Add(new SqlParameter("UserName", textBox1.Text));
            comm.Parameters.Add(new SqlParameter("Result", listBox2));
            comm.Parameters.Add(new SqlParameter("ResultDate", DateTime.Today));

            //comm.ExecuteNonQuery();
            conn.Close();
           


        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //секция "О приложении"
            About about = new About();
            about.Show();
        }

        private void CreatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Секция "Создатели"
            Creators creators = new Creators();
            creators.Show();
        }
        public static class Logged
        {
            public static string login = "";
        }
        public void button3_Click(object sender, EventArgs e)
        {
            LoginForm devbuild = new LoginForm(this.textBox1);
            button1.Enabled = false;
            button2.Enabled = false;
            devbuild.ShowDialog();

            if (textBox1.Text != "admin")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            
        }
   
        
        private void MainWin_Load(object sender, EventArgs e)
        {
            //devbuil edit. Добавляем инактив до авторзации(на загрузке)
            button1.Enabled = false;
            button2.Enabled = false;
            textBox1.Visible = false;

            
        }

        private void дополнительноToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void просмотретьРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResDataGrid log = new ResDataGrid();
            log.Show();
        }
    }
}
