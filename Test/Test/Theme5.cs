using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Test
{
    class Theme5 : Form1
    {

        Label lb;
        RadioButton b1;
        RadioButton b2;
        RadioButton b3;
        RadioButton b4;
        Button b;

        int flag = 0;
        public int rightAnswer;


        //конструктор класса для принятия ссылок на объекты, так с ними можно будет работать
        public Theme5(Label _lb, RadioButton _b1, RadioButton _b2, RadioButton _b3, RadioButton _b4, int _flag, Button _b)
        {

            lb = _lb;
            b1 = _b1;
            b2 = _b2;
            b3 = _b3;
            b4 = _b4;
            flag = _flag;
            b = _b;


            //загрузка нужного вопроса
            switch (flag)
            {
                case 1:
                    Qes1();
                    break;
                case 2:
                    Qes2();
                    break;
                case 3:
                    Qes3();
                    break;
                case 4:
                    Qes4();
                    break;
                case 5:
                    Qes5();
                    break;
                case 6:
                    Qes6();
                    break;
                case 7:
                    Qes7();
                    break;
                case 8:
                    Qes8();
                    break;
                case 9:
                    Qes9();
                    break;
                case 10:
                    Qes10();
                    break;
            }


        }

        //Сами вопросы. Функции изменяют тест на форме и записывают в данные класса правильный ответ, потом этот ответ можно будет достать из других классов 

        public void Qes1()
        {
            lb.Text = "Вопрос";
            b1.Text = "ответ";
            b2.Text = "ответ";
            b3.Text = "ответ";
            b4.Text = "ответ";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes2()
        {
            lb.Text = "Вопрос";
            b1.Text = "ответ";
            b2.Text = "ответ";
            b3.Text = "ответ";
            b4.Text = "ответ";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes3()
        {
            lb.Text = "Вопрос";
            b1.Text = "ответ";
            b2.Text = "ответ";
            b3.Text = "ответ";
            b4.Text = "ответ";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes4()
        {
            lb.Text = "Вопрос";
            b1.Text = "ответ";
            b2.Text = "ответ";
            b3.Text = "ответ";
            b4.Text = "ответ";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes5()
        {
            lb.Text = "Вопрос";
            b1.Text = "ответ";
            b2.Text = "ответ";
            b3.Text = "ответ";
            b4.Text = "ответ";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes6()
        {
            lb.Text = "Вопрос";
            b1.Text = "ответ";
            b2.Text = "ответ";
            b3.Text = "ответ";
            b4.Text = "ответ";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes7()
        {
            lb.Text = "Вопрос";
            b1.Text = "ответ";
            b2.Text = "ответ";
            b3.Text = "ответ";
            b4.Text = "ответ";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes8()
        {
            lb.Text = "Вопрос";
            b1.Text = "ответ";
            b2.Text = "ответ";
            b3.Text = "ответ";
            b4.Text = "ответ";
            //номер правильного ответа
            rightAnswer = 1;
        }

        public void Qes9()
        {
            lb.Text = "Вопрос";
            b1.Text = "ответ";
            b2.Text = "ответ";
            b3.Text = "ответ";
            b4.Text = "ответ";
            //номер правильного ответа
            rightAnswer = 1;
        }

        public void Qes10()
        {
            lb.Text = "Вопрос";
            b1.Text = "ответ";
            b2.Text = "ответ";
            b3.Text = "ответ";
            b4.Text = "ответ";
            //номер правильного ответа
            rightAnswer = 1;

            //это не трограть
            b.Text = "Закончить тест";

        }

    }
}
