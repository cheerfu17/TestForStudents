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
    class Theme1 : MainWin
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
        public Theme1(Label _lb, RadioButton _b1, RadioButton _b2 ,RadioButton _b3, RadioButton _b4, int _flag, Button _b)
        {
            
            lb = _lb;
            b1 = _b1;
            b2 = _b2;
            b3 = _b3;
            b4 = _b4;
            flag = _flag;
            b = _b;
            

            //загрузка вопроса
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
            lb.Text = "1. Какой тип данных используется для создания целочисленных переменных?";
            b1.Text = "int";
            b2.Text = "char";
            b3.Text = "bool";
            b4.Text = "string";
            rightAnswer = 1;
        }
        public void Qes2()
        {
            lb.Text = "2. Какой тип данных используется для создания строковой переменной?";
            b1.Text = "char";
            b2.Text = "int";
            b3.Text = "string";
            b4.Text = "double";
            rightAnswer = 3;
        }
        public void Qes3()
        {
            lb.Text = "3. Выберите правильный синтаксис инициализации переменной:";
            b1.Text = "[Название переменной] [Тип данных] = [Значение переменной] ";
            b2.Text = "[Тип данных] [Название переменной] = [Значение переменной]";
            b3.Text = "[Значение переменной] = [Тип данных] [Название переменной]";
            b4.Text = "[Название переменной] = [Значение переменной]";
            rightAnswer = 2;
        }
        public void Qes4()
        {
            lb.Text = "4. Что представляет из себя переменная с типом string?";
            b1.Text = "Массив символов";
            b2.Text = "Массив чисел";
            b3.Text = "Массив слов";
            b4.Text = "Переменная которая хранит числа";
            rightAnswer = 1;
        }
        public void Qes5()
        {
            lb.Text = "5. Выберите логический тип данных";
            b1.Text = "int";
            b2.Text = "bool";
            b3.Text = "string";
            b4.Text = "char";
            rightAnswer = 2;
        }
        public void Qes6()
        {
            lb.Text = "6. Char это _________ тип данных";
            b1.Text = "Строковый";
            b2.Text = "Числовой";
            b3.Text = "Логический";
            b4.Text = "Символьный";
            rightAnswer = 4;
        }
        public void Qes7()
        {
            lb.Text = "7. Для создания переменной с плавающей точкой двойной точности используется тип – ";
            b1.Text = "int";
            b2.Text = "string";
            b3.Text = "double";
            b4.Text = "float";
            rightAnswer = 3;
        }
        public void Qes8()
        {
            lb.Text = "8. Для создания переменной с плавающей точкой используется";
            b1.Text = "chat";
            b2.Text = "float";
            b3.Text = "int";
            b4.Text = "long";
            rightAnswer = 2;
        }

        public void Qes9()
        {
            lb.Text = "9. Сколько байт памяти выделяется под переменную с типом int?";
            b1.Text = "1";
            b2.Text = "4";
            b3.Text = "2";
            b4.Text = "8";
            rightAnswer = 2;
        }

        public void Qes10()
        {
            lb.Text = "10. Какая ошибка допущена в этой строке \"string number = 1; \"?";
            b1.Text = "Неправильно указано имя переменной";
            b2.Text = "Нарушен порядок слов при инициализации";
            b3.Text = "Не правильно указано значение переменной";
            b4.Text = "При инициализации используется несуществующий тип данных";
            b.Text = "Закончить тест";
            rightAnswer = 3;
        }

    }
}
