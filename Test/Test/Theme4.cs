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
    class Theme4 : MainWin
    {

        Label lb;
        RadioButton rB1;
        RadioButton rB2;
        RadioButton rB3;
        RadioButton rB4;


        CheckBox chB1;
        CheckBox chB2;
        CheckBox chB3;
        CheckBox chB4;


        Button b;

        int flag = 0;
        public int rightAnswer;
        public int[] arrRightAnswer = new int[4] { 42, 42, 42, 42 };

        //конструктор класса для принятия ссылок на объекты, так с ними можно будет работать
        public Theme4(Label _lb, RadioButton _rB1, RadioButton _rB2, RadioButton _rB3, RadioButton _rB4, CheckBox _chB1, CheckBox _chB2, CheckBox _chB3, CheckBox _chB4, int _flag, Button _b)
        {

            lb = _lb;

            rB1 = _rB1;
            rB2 = _rB2;
            rB3 = _rB3;
            rB4 = _rB4;

            chB1 = _chB1;
            chB2 = _chB2;
            chB3 = _chB3;
            chB4 = _chB4;

            flag = _flag;
            b = _b;


            //загрузка вопроса
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
            hideCheckBox();
            lb.Text = "1. Выберите оператор сравнения:";
            rB1.Text = "?";
            rB2.Text = "!=";
            rB3.Text = "++";
            rB4.Text = "/";
            //номер правильного ответа
            rightAnswer = 2;
        }
        public void Qes2()
        {
            lb.Text = "2. Оператор if является:";
            rB1.Text = "Условным оператором";
            rB2.Text = "Оператором равенства";
            rB3.Text = "Условным оператором";
            rB4.Text = "Оператором присвоения";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes3()
        {
            lb.Text = "3. Результат работы фрагмента программы:\nchar a, b, c;\na = 'b'; b = 'c'; c = a;\nConsole.WriteLine({0}{1}{2}{3}, a, b, c, 'c');";
            rB1.Text = "abba";
            rB2.Text = "abcc";
            rB3.Text = "bcbc";
            rB4.Text = "bcac";
            rightAnswer = 3;
        }
        public void Qes4()
        {
            lb.Text = "4. Выберите оператор присвоения:";
            rB1.Text = "==";
            rB2.Text = "+";
            rB3.Text = "=";
            rB4.Text = "!=";
            //номер правильного ответа
            rightAnswer = 3;
        }
        public void Qes5()
        {
            lb.Text = "5. Оператор логического исключения ИЛИ";
            rB1.Text = "^";
            rB2.Text = "||";
            rB3.Text = "&";
            rB4.Text = "!";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes6()
        {
            lb.Text = "6. Значение выражения 13 % 2 / 4 равно:";
            rB1.Text = "1";
            rB2.Text = "5";
            rB3.Text = "0.25";
            rB4.Text = "4.5";
            //номер правильного ответа
            rightAnswer = 3;
        }
        public void Qes7()
        {
            lb.Text = "7. Знак плюс в выражении a += 1 является __________ оператором:";
            rB1.Text = "Унарным";
            rB2.Text = "Бинарным";
            rB3.Text = "Тринарным";
            rB4.Text = "Сравнивающим";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes8()
        {
            lb.Text = "8. Выберите оператор для остановки цикла";
            rB1.Text = "stop";
            rB2.Text = "pause";
            rB3.Text = "break";
            rB4.Text = "continue";
            //номер правильного ответа
            rightAnswer = 3;
        }

        public void Qes9()
        {
            lb.Text = "9. Выберите оператор выбора";
            rB1.Text = "if";
            rB2.Text = "switch";
            rB3.Text = "else";
            rB4.Text = "=";
            //номер правильного ответа
            rightAnswer = 2;
        }

        public void Qes10()
        {
            lb.Text = "10. Данный оператор ? : является ";
            rB1.Text = "унарным";
            rB2.Text = "бинарным";
            rB3.Text = "тринарным";
            rB4.Text = "такого оператора не сущестует";
            //номер правильного ответа
            rightAnswer = 3;

            b.Text = "Закончить тест";

        }

        public void showRadioButton()
        {
            rB1.Show();
            rB2.Show();
            rB3.Show();
            rB4.Show();
        }

        public void hideRadioButton()
        {
            rB1.Hide();
            rB2.Hide();
            rB3.Hide();
            rB4.Hide();
        }

        public void showCheckBox()
        {
            chB1.Show();
            chB2.Show();
            chB3.Show();
            chB4.Show();
        }

        public void hideCheckBox()
        {
            chB1.Hide();
            chB2.Hide();
            chB3.Hide();
            chB4.Hide();
        }

        public void setRightAnswer(int a1, int a2, int a3, int a4)
        {
            arrRightAnswer[0] = a1;
            arrRightAnswer[1] = a2;
            arrRightAnswer[2] = a3;
            arrRightAnswer[3] = a4;

        }

    }
}
