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
    class Theme3 : Form1
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
        public Theme3(Label _lb, RadioButton _b1, RadioButton _b2, RadioButton _b3, RadioButton _b4, int _flag, Button _b)
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

        /*Сами вопросы. Функции изменяют тест на форме и записывают в данные класса правильный ответ, потом этот ответ можно будет достать из других классов 
        P.S знаю что названия методов нужно писать с маленькой буквы, лень изменять :/ */
        public void Qes1()
        {
            lb.Text = "Структура данных, хранящая набор значений, идентифицируемых по индексу или набору индексов, принимающих целые значения из некоторого заданного непрерывного диапазона называется: ";
            b1.Text = "Массивом";
            b2.Text = "Диапазоном";
            b3.Text = "Коллекция ";
            b4.Text = "Нет верного ответа";
            rightAnswer = 1;
        }
        public void Qes2()
        {
            lb.Text = "Выберите верное определение одномерного массива: ";
            b1.Text = "int[,] nums2 = new int[4] { 1, 2, 3, 5 };";
            b2.Text = "int[] nums = new int[4]{ 1, 2, 3, 5, 5, 1 };";
            b3.Text = "int[] nums2 = new int[4] { 1, 2, 3, 5 };";
            b4.Text = "int[,] nums = new int[];";
            rightAnswer = 3;
        }
        public void Qes3()
        {
            lb.Text = "Выберите верное определение двумерного массива:";
            b1.Text = "int[,] nums2 = new int[4] { 1, 2, 3, 5 };";
            b2.Text = "int[] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };";
            b3.Text = "int[] nums2 = new int[4] { 1, 2, 3, 5 };";
            b4.Text = "int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };";
            rightAnswer = 4;
        }
        public void Qes4()
        {
            lb.Text = "Для определения размера массива используется метод:";
            b1.Text = "Length()";
            b2.Text = "Сount()";
            b3.Text = "getLenght()";
            b4.Text = "Нет верного ответа";
            rightAnswer = 1;
        }
        public void Qes5()
        {
            lb.Text = "Существует ли конструкция \" Массив масиивов\"";
            b1.Text = "Не существует";
            b2.Text = "Существует";
            b3.Text = "Существует в рамках других языков";
            b4.Text = "Нет верных ответов";

            rightAnswer = 2;
        }
        public void Qes6()
        {
            lb.Text = "Для сортировки массива существует метод под названием: ";
            b1.Text = "Length()";
            b2.Text = "Sort()";
            b3.Text = "FindAll()";
            b4.Text = "Нет верного ответа";
            rightAnswer = 2;
        }

        public void Qes7()
        {
            lb.Text = "Для поиска всех элементов удовлетворяющих условию используется метод: ";
            b1.Text = "Length()";
            b2.Text = "Count()";
            b3.Text = "FindAll()";
            b4.Text = "Нет верного ответа";
            rightAnswer = 3;
        }

        public void Qes8()
        {
            lb.Text = "Для поиска одного элемента который подходит под условие используется метод: ";
            b1.Text = "FindAll()";
            b2.Text = "Count()";
            b3.Text = "Find()";
            b4.Text = "Нет верного ответа";
            rightAnswer = 3;
        }

        public void Qes9()
        {
            lb.Text = "Для обращения массива в другую сторону используется метод: ";
            b1.Text = "Reverse()";
            b2.Text = "Count()";
            b3.Text = "getLenght()";
            b4.Text = "Нет верного ответа";
            rightAnswer = 1;
        }

        public void Qes10()
        {
            lb.Text = "Метод _______ возвращает индекс элемента";
            b1.Text = "FindAll()";
            b2.Text = "IndexOf()";
            b3.Text = "Find()";
            b4.Text = "Нет верного ответа";
            rightAnswer = 2;
            b.Text = "Закончить тест";
        }
    }
}
