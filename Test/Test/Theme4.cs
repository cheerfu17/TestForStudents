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
        RadioButton b1;
        RadioButton b2;
        RadioButton b3;
        RadioButton b4;
        Button b;

        int flag = 0;
        public int rightAnswer;


        //конструктор класса для принятия ссылок на объекты, так с ними можно будет работать
        public Theme4(Label _lb, RadioButton _b1, RadioButton _b2, RadioButton _b3, RadioButton _b4, int _flag, Button _b)
        {

            lb = _lb;
            b1 = _b1;
            b2 = _b2;
            b3 = _b3;
            b4 = _b4;
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
            lb.Text = "1. Выберите оператор сравнения:";
            b1.Text = "?";
            b2.Text = "!=";
            b3.Text = "++";
            b4.Text = "/";
            //номер правильного ответа
            rightAnswer = 2;
        }
        public void Qes2()
        {
            lb.Text = "2. Оператор if является:";
            b1.Text = "Условным оператором";
            b2.Text = "Оператором равенства";
            b3.Text = "Условным оператором";
            b4.Text = "Оператором присвоения";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes3()
        {
            lb.Text = "3. Результат работы фрагмента программы:\nchar a, b, c;\na = 'b'; b = 'c'; c = a;\nConsole.WriteLine({0}{1}{2}{3}, a, b, c, 'c');";
            b1.Text = "abba";
            b2.Text = "abcc";
            b3.Text = "bcbc";
            b4.Text = "bcac";
            rightAnswer = 3;
        }
        public void Qes4()
        {
            lb.Text = "4. Выберите оператор присвоения:";
            b1.Text = "==";
            b2.Text = "+";
            b3.Text = "=";
            b4.Text = "!=";
            //номер правильного ответа
            rightAnswer = 3;
        }
        public void Qes5()
        {
            lb.Text = "5. Оператор логического исключения ИЛИ";
            b1.Text = "^";
            b2.Text = "||";
            b3.Text = "&";
            b4.Text = "!";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes6()
        {
            lb.Text = "6. Значение выражения 13 % 2 / 4 равно:";
            b1.Text = "1";
            b2.Text = "5";
            b3.Text = "0.25";
            b4.Text = "4.5";
            //номер правильного ответа
            rightAnswer = 3;
        }
        public void Qes7()
        {
            lb.Text = "7. Знак плюс в выражении a += 1 является __________ оператором:";
            b1.Text = "Унарным";
            b2.Text = "Бинарным";
            b3.Text = "Тринарным";
            b4.Text = "Сравнивающим";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes8()
        {
            lb.Text = "8. Выберите оператор для остановки цикла";
            b1.Text = "stop";
            b2.Text = "pause";
            b3.Text = "break";
            b4.Text = "continue";
            //номер правильного ответа
            rightAnswer = 3;
        }

        public void Qes9()
        {
            lb.Text = "9. Выберите оператор выбора";
            b1.Text = "if";
            b2.Text = "switch";
            b3.Text = "else";
            b4.Text = "=";
            //номер правильного ответа
            rightAnswer = 2;
        }

        public void Qes10()
        {
            lb.Text = "10. Данный оператор ? : является ";
            b1.Text = "унарным";
            b2.Text = "бинарным";
            b3.Text = "тринарным";
            b4.Text = "такого оператора не сущестует";
            //номер правильного ответа
            rightAnswer = 3;

            b.Text = "Закончить тест";

        }

    }
}
