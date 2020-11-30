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
        RadioButton b1;
        RadioButton b2;
        RadioButton b3;
        RadioButton b4;
        Button b;

        int flag = 0;
        public int rightAnswer;


        //конструктор класса для принятия ссылок на объекты, так с ними можно будет работать
        public Theme2(Label _lb, RadioButton _b1, RadioButton _b2, RadioButton _b3, RadioButton _b4, int _flag, Button _b)
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
            lb.Text = "1. Что такое цикл?";
            b1.Text = "Конструкция котороя позволяет многократно выполнять набор определенных команд";
            b2.Text = "Конструкция котороя производит операции над числами";
            b3.Text = "Оператор условной конструкции";
            b4.Text = "Последовательность команд";
            rightAnswer = 1;
        }
        public void Qes2()
        {
            lb.Text = "2. Выберите верную конструкцию цикла с предусловием";
            b1.Text = "do{}while(условие);";
            b2.Text = "while(условие) {};";
            b3.Text = "for(;;){}";
            b4.Text = "Нет верного ответа";
            rightAnswer = 2;
        }
        public void Qes3()
        {
            lb.Text = "3. Что представляет из себя цикл for";
            b1.Text = "Цикл с предусловием";
            b2.Text = "Цикл с постусловием";
            b3.Text = "Цикл с счетчиком и условием";
            b4.Text = "Цикл для перебора значений в списках\\массивах";
            rightAnswer = 3;
        }
        public void Qes4()
        {
            lb.Text = "4. Выберите рузультат выполнения следующй программы int a = 0; for(int i = 0; i < 10; i++) {a = i+2} Console.WriteLine(\"a\");";
            b1.Text = "11";
            b2.Text = "10";
            b3.Text = "9";
            b4.Text = "12";
            rightAnswer = 1;
        }
        public void Qes5()
        {
            lb.Text = "5. Выберите верную конструкцию цикла с постусловием";
            b1.Text = "do{}while(условие);";
            b2.Text = "while(условие) {};";
            b3.Text = "for(;;){}";
            b4.Text = "Нет верного ответа";
            rightAnswer = 1;

        }
        public void Qes6()
        {
            lb.Text = "6. Выберите верный способ задать бесконечный цикл";
            b1.Text = "while(true) {}";
            b2.Text = "do {} while(true);";
            b3.Text = "for(;;) {}";
            b4.Text = "Все варианты верны";
            rightAnswer = 4;
        }
        public void Qes7()
        {
            lb.Text = "7. Для того чтобы принудительно выйти из цикла используется оператор";
            b1.Text = "continue";
            b2.Text = "break";
            b3.Text = "stop";
            b4.Text = "exit";
            rightAnswer = 2;
        }
        public void Qes8()
        {
            lb.Text = "8. Для того чтобы принудительно перейти к следующей итерации цикла используется оператор";
            b1.Text = "continue";
            b2.Text = "break";
            b3.Text = "stop";
            b4.Text = "exit";
            rightAnswer = 1;
        }
        public void Qes9()
        {
            lb.Text = "9. Цикл для перебора значений во множествах называется";
            b1.Text = "for";
            b2.Text = "while";
            b3.Text = "for each";
            b4.Text = "do-while";
            rightAnswer = 3;
        }
        public void Qes10()
        {
            lb.Text = "10. Выберите верную конструкцию совместного цикла";
            b1.Text = "do{}while(условие);";
            b2.Text = "while(условие) {};";
            b3.Text = "for(;;){}";
            b4.Text = "foreach ([тип] [название переменной] in [множество] {} )";
            rightAnswer = 4;
            b.Text = "Закончить тест";
        }



    }
}
