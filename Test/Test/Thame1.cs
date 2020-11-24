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
    class Thame1 : Form1
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
        public Thame1(Label _lb, RadioButton _b1, RadioButton _b2 ,RadioButton _b3, RadioButton _b4, int _flag, Button _b)
        {
            
            lb = _lb;
            b1 = _b1;
            b2 = _b2;
            b3 = _b3;
            b4 = _b4;
            flag = _flag;
            b = _b;
            

            //загрузка нужного вопроса
            switch(flag)
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
            }


        }

        /*Сами вопросы. Функции изменяют тест на форме и записывают в данные класса правильный ответ, потом этот ответ можно будет достать из других классов 
        P.S знаю что названия методов нужно писать с маленькой буквы, лень изменять :/ */
        public void Qes1()
        {
            lb.Text = "question1";
            b1.Text = "answer1";
            b2.Text = "answer2";
            b3.Text = "answer3";
            b4.Text = "answer4";
            rightAnswer = 2;
        }
        public void Qes2()
        {
            lb.Text = "question2";
            b1.Text = "answer1";
            b2.Text = "answer2";
            b3.Text = "answer3";
            b4.Text = "answer4";
            rightAnswer = 2;
        }
        public void Qes3()
        {
            lb.Text = "question3";
            b1.Text = "answer1";
            b2.Text = "answer2";
            b3.Text = "answer3";
            b4.Text = "answer4";
            rightAnswer = 2;
        }
        public void Qes4()
        {
            lb.Text = "question4";
            b1.Text = "answer1";
            b2.Text = "answer2";
            b3.Text = "answer3";
            b4.Text = "answer4";
            rightAnswer = 2;
        }
        public void Qes5()
        {
            lb.Text = "question5";
            b1.Text = "answer1";
            b2.Text = "answer2";
            b3.Text = "answer3";
            b4.Text = "answer4";
            b.Text = "Закончить тест";
            rightAnswer = 2;
        }

    }
}
