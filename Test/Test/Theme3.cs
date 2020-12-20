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
    class Theme3 : MainWin
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
        public Theme3(Label _lb, RadioButton _rB1, RadioButton _rB2, RadioButton _rB3, RadioButton _rB4, CheckBox _chB1, CheckBox _chB2, CheckBox _chB3, CheckBox _chB4, int _flag, Button _b)
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
            lb.Text = "1. Структура данных, хранящая набор значений, идентифицируемых по индексу или набору индексов, принимающих целые значения из некоторого заданного непрерывного диапазона называется: ";
            rB1.Text = "Массивом";
            rB2.Text = "Диапазоном";
            rB3.Text = "Коллекция ";
            rB4.Text = "Нет верного ответа";
            rightAnswer = 1;
        }
        public void Qes2()
        {
            lb.Text = "2. Выберите верное определение одномерного массива: ";
            rB1.Text = "int[,] nums2 = new int[4] { 1, 2, 3, 5 };";
            rB2.Text = "int[] nums = new int[4]{ 1, 2, 3, 5, 5, 1 };";
            rB3.Text = "int[] nums2 = new int[4] { 1, 2, 3, 5 };";
            rB4.Text = "int[,] nums = new int[];";
            rightAnswer = 3;
        }
        public void Qes3()
        {
            lb.Text = "3. Выберите верное определение двумерного массива:";
            rB1.Text = "int[,] nums2 = new int[4] { 1, 2, 3, 5 };";
            rB2.Text = "int[] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };";
            rB3.Text = "int[] nums2 = new int[4] { 1, 2, 3, 5 };";
            rB4.Text = "int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };";
            rightAnswer = 4;
        }
        public void Qes4()
        {
            lb.Text = "4. Для определения размера массива используется метод:";
            rB1.Text = "Length()";
            rB2.Text = "Сount()";
            rB3.Text = "getLenght()";
            rB4.Text = "Нет верного ответа";
            rightAnswer = 1;
        }
        public void Qes5()
        {
            lb.Text = "5. Существует ли конструкция \" Массив масиивов\"";
            rB1.Text = "Не существует";
            rB2.Text = "Существует";
            rB3.Text = "Существует в рамках других языков";
            rB4.Text = "Нет верных ответов";

            rightAnswer = 2;
        }
        public void Qes6()
        {
            lb.Text = "6. Для сортировки массива существует метод под названием: ";
            rB1.Text = "Length()";
            rB2.Text = "Sort()";
            rB3.Text = "FindAll()";
            rB4.Text = "Нет верного ответа";
            rightAnswer = 2;
        }

        public void Qes7()
        {
            lb.Text = "7. Для поиска всех элементов удовлетворяющих условию используется метод: ";
            rB1.Text = "Length()";
            rB2.Text = "Count()";
            rB3.Text = "FindAll()";
            rB4.Text = "Нет верного ответа";
            rightAnswer = 3;
        }

        public void Qes8()
        {
            lb.Text = "8. Для поиска одного элемента который подходит под условие используется метод: ";
            rB1.Text = "FindAll()";
            rB2.Text = "Count()";
            rB3.Text = "Find()";
            rB4.Text = "Нет верного ответа";
            rightAnswer = 3;
        }

        public void Qes9()
        {
            lb.Text = "9. Для обращения массива в другую сторону используется метод: ";
            rB1.Text = "Reverse()";
            rB2.Text = "Count()";
            rB3.Text = "getLenght()";
            rB4.Text = "Нет верного ответа";
            rightAnswer = 1;
        }

        public void Qes10()
        {
            lb.Text = "10. Метод _______ возвращает индекс элемента";
            rB1.Text = "FindAll()";
            rB2.Text = "IndexOf()";
            rB3.Text = "Find()";
            rB4.Text = "Нет верного ответа";
            rightAnswer = 2;
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
