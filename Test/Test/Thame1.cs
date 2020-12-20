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
        public int[] arrRightAnswer = new int[4] {42,42,42,42};
        


        //конструктор класса для принятия ссылок на объекты, так с ними можно будет работать
        public Theme1(Label _lb, RadioButton _rB1, RadioButton _rB2 ,RadioButton _rB3, RadioButton _rB4, CheckBox _chB1, CheckBox _chB2, CheckBox _chB3, CheckBox _chB4, int _flag, Button _b)
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
            hideCheckBox();
            lb.Text = "1. Какой тип данных используется для создания целочисленных переменных?";
            rB1.Text = "int";
            rB2.Text = "char";
            rB3.Text = "bool";
            rB4.Text = "string";
            rightAnswer = 1;
            
            
        }
        public void Qes2()
        {
            lb.Text = "2. Какой тип данных используется для создания строковой переменной?";
            rB1.Text = "char";
            rB2.Text = "int";
            rB3.Text = "string";
            rB4.Text = "double";
            rightAnswer = 3;
        }
        public void Qes3()
        {
            lb.Text = "3. Выберите правильный синтаксис инициализации переменной:";
            rB1.Text = "[Название переменной] [Тип данных] = [Значение переменной] ";
            rB2.Text = "[Тип данных] [Название переменной] = [Значение переменной]";
            rB3.Text = "[Значение переменной] = [Тип данных] [Название переменной]";
            rB4.Text = "[Название переменной] = [Значение переменной]";
            rightAnswer = 2;
        }
        public void Qes4()
        {
            lb.Text = "4. Что представляет из себя переменная с типом string?";
            rB1.Text = "Массив символов";
            rB2.Text = "Массив чисел";
            rB3.Text = "Массив слов";
            rB4.Text = "Переменная которая хранит числа";
            rightAnswer = 1;
        }
        public void Qes5()
        {
            lb.Text = "5. Выберите логический тип данных";
            rB1.Text = "int";
            rB2.Text = "bool";
            rB3.Text = "string";
            rB4.Text = "char";
            rightAnswer = 2;
        }
        public void Qes6()
        {
            lb.Text = "6. Char это _________ тип данных";
            rB1.Text = "Строковый";
            rB2.Text = "Числовой";
            rB3.Text = "Логический";
            rB4.Text = "Символьный";
            rightAnswer = 4;
        }
        public void Qes7()
        {
            lb.Text = "7. Для создания переменной с плавающей точкой двойной точности используется тип – ";
            rB1.Text = "int";
            rB2.Text = "string";
            rB3.Text = "double";
            rB4.Text = "float";
            rightAnswer = 3;
        }
        public void Qes8()
        {
            hideRadioButton();
            showCheckBox();
            lb.Text = "8. Для создания переменной с плавающей точкой используется";
            chB1.Text = "double";
            chB2.Text = "float";
            chB3.Text = "decimal";
            chB4.Text = "long";
            setRightAnswer(1, 1, 1, 0);
        }

        public void Qes9()
        {
            showRadioButton();
            hideCheckBox();
            lb.Text = "9. Сколько байт памяти выделяется под переменную с типом int?";
            rB1.Text = "1";
            rB2.Text = "4";
            rB3.Text = "2";
            rB4.Text = "8";
            rightAnswer = 2;
        }

        public void Qes10()
        {
            lb.Text = "10. Какая ошибка допущена в этой строке \"string number = 1; \"?";
            rB1.Text = "Неправильно указано имя переменной";
            rB2.Text = "Нарушен порядок слов при инициализации";
            rB3.Text = "Не правильно указано значение переменной";
            rB4.Text = "При инициализации используется несуществующий тип данных";
            b.Text = "Закончить тест";
            rightAnswer = 3;
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
