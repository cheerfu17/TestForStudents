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
    class Theme2 : MainWin
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
        public int[] arrRightAnswer = new int[4];


        //конструктор класса для принятия ссылок на объекты, так с ними можно будет работать
        public Theme2(Label _lb, RadioButton _rB1, RadioButton _rB2, RadioButton _rB3, RadioButton _rB4, CheckBox _chB1, CheckBox _chB2, CheckBox _chB3, CheckBox _chB4, int _flag, Button _b)
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
            lb.Text = "1. Что такое цикл?";
            rB1.Text = "Конструкция котороя позволяет многократно выполнять набор определенных команд";
            rB2.Text = "Конструкция котороя производит операции над числами";
            rB3.Text = "Оператор условной конструкции";
            rB4.Text = "Последовательность команд";
            rightAnswer = 1;
        }
        public void Qes2()
        {
            lb.Text = "2. Выберите верную конструкцию цикла с предусловием";
            rB1.Text = "do{}while(условие);";
            rB2.Text = "while(условие) {};";
            rB3.Text = "for(;;){}";
            rB4.Text = "Нет верного ответа";
            rightAnswer = 2;
        }
        public void Qes3()
        {
            lb.Text = "3. Что представляет из себя цикл for";
            rB1.Text = "Цикл с предусловием";
            rB2.Text = "Цикл с постусловием";
            rB3.Text = "Цикл с счетчиком и условием";
            rB4.Text = "Цикл для перебора значений в списках\\массивах";
            rightAnswer = 3;
        }
        public void Qes4()
        {
            lb.Text = "4. Выберите рузультат выполнения следующй программы int a = 0; for(int i = 0; i < 10; i++) {a = i+2} Console.WriteLine(\"a\");";
            rB1.Text = "11";
            rB2.Text = "10";
            rB3.Text = "9";
            rB4.Text = "12";
            rightAnswer = 1;
        }
        public void Qes5()
        {
            lb.Text = "5. Выберите верную конструкцию цикла с постусловием";
            rB1.Text = "do{}while(условие);";
            rB2.Text = "while(условие) {};";
            rB3.Text = "for(;;){}";
            rB4.Text = "Нет верного ответа";
            rightAnswer = 1;

        }
        public void Qes6()
        {
            lb.Text = "6. Выберите верный способ задать бесконечный цикл";
            rB1.Text = "while(true) {}";
            rB2.Text = "do {} while(true);";
            rB3.Text = "for(;;) {}";
            rB4.Text = "Все варианты верны";
            rightAnswer = 4;
        }
        public void Qes7()
        {
            lb.Text = "7. Для того чтобы принудительно выйти из цикла используется оператор";
            rB1.Text = "continue";
            rB2.Text = "break";
            rB3.Text = "stop";
            rB4.Text = "exit";
            rightAnswer = 2;
        }
        public void Qes8()
        {
            lb.Text = "8. Для того чтобы принудительно перейти к следующей итерации цикла используется оператор";
            rB1.Text = "continue";
            rB2.Text = "break";
            rB3.Text = "stop";
            rB4.Text = "exit";
            rightAnswer = 1;
        }
        public void Qes9()
        {
            lb.Text = "9. Цикл для перебора значений во множествах называется";
            rB1.Text = "for";
            rB2.Text = "while";
            rB3.Text = "for each";
            rB4.Text = "do-while";
            rightAnswer = 3;
        }
        public void Qes10()
        {
            lb.Text = "10. Выберите верную конструкцию совместного цикла";
            rB1.Text = "do{}while(условие);";
            rB2.Text = "while(условие) {};";
            rB3.Text = "for(;;){}";
            rB4.Text = "foreach ([тип] [название переменной] in [множество] {} )";
            rightAnswer = 4;
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
