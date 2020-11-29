﻿using System;
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
    class Theme5 : MainWin
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
            lb.Text = "Из приведенных ниже высказываний укажите истинное:";
            b1.Text = "модификатор (спецификатор) protected определяет доступность вложенного класса коду производных классов ";
            b2.Text = "модификатор (спецификатор) protected определяет, где доступен не вложенный класс или любой другой не вложенный тип ";
            b3.Text = "модификатор (спецификатор) protected определяет доступность любого члена класса в производных классах только в пределах включающей его сборки";
            b4.Text = "модификатор (спецификатор) protected нельзя применять к событиям";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes2()
        {
            lb.Text = "Из приведенных ниже высказываний укажите истинное:";
            b3.Text = "модификатор (спецификатор) internal определяет доступность класса в пределах включающей его сборки ";
            b2.Text = "для определения доступности члена класса в других сборках необходимо указать модификатор (спецификатор) extern";
            b1.Text = " модификатор (спецификатор) internal определяет доступность любого члена класса во внешних сборках ";
            b4.Text = " модификатор (спецификатор) internal нельзя применять к событиям ";
            //номер правильного ответа
            rightAnswer = 3;
        }
        public void Qes3()
        {
            lb.Text = "Из приведенных ниже высказываний укажите истинное:";
            b1.Text = "модификатор (спецификатор) protected internal определяет, где доступен не вложенный тип ";
            b2.Text = "модификатор (спецификатор) protected internal определяет доступность любого члена класса любому коду включающей его сборки или коду производных классов в любых сборках ";
            b3.Text = "модификатор (спецификатор) protected internal определяет доступность любого члена класса только коду производных классов внешних сборок";
            b4.Text = "модификатор (спецификатор) protected internal определяет доступность вложенного класса любому коду включающей его сборки или коду производных классов в любых сборках ";
            //номер правильного ответа
            rightAnswer = 4;
        }
        public void Qes4()
        {
            lb.Text = "Определяемый программистом тип может быть";
            b1.Text = "файлом ";
            b2.Text = "структурой ";
            b3.Text = "указателем ";
            b4.Text = "многомерным массивом ";
            //номер правильного ответа
            rightAnswer = 2;
        }
        public void Qes5()
        {
            lb.Text = "Определяемый программистом тип может быть";
            b1.Text = "классом ";
            b2.Text = "одномерным массивом";
            b3.Text = "строкой символов ";
            b4.Text = "событием ";
            //номер правильного ответа
            rightAnswer = 1;
        }
        public void Qes6()
        {
            lb.Text = "Определяемый программистом тип может быть";
            b1.Text = "cписком ";
            b2.Text = "cтеком ";
            b3.Text = "очередью ";
            b4.Text = "интерфейсом ";
            //номер правильного ответа
            rightAnswer = 4;
        }
        public void Qes7()
        {
            lb.Text = "Из приведенных ниже высказываний укажите истинное высказывание:";
            b1.Text = "если метод описывается вне класса, то в классе должен быть указан его прототип ";
            b2.Text = " если метод не возвращает значение, то он должен иметь модификатор (спецификатор) virtual ";
            b3.Text = "для вызова метода можно не создавать экземпляр (объект) класса только в том случае, если метод вызывается внутри класса ";
            b4.Text = "метод может иметь пустое тело ";
            //номер правильного ответа
            rightAnswer = 4;
        }
        public void Qes8()
        {
            lb.Text = "В заголовке определяемого не вложенного типа программист может указать доступность типа";
            b1.Text = "с помощью модификатора override";
            b2.Text = "с помощью модификатора private ";
            b3.Text = "по умолчанию";
            b4.Text = "с помощью модификатора new ";
            //номер правильного ответа
            rightAnswer = 3;
        }

        public void Qes9()
        {
            lb.Text = "В заголовке определяемого не вложенного типа программист может указать доступность типа с помощью модификатора:";
            b1.Text = "static ";
            b2.Text = "private ";
            b3.Text = "protected";
            b4.Text = " internal ";
            //номер правильного ответа
            rightAnswer = 4;
        }

        public void Qes10()
        {
            lb.Text = "Программист определил тип как: class MyOut {} Тип MyOut будет доступен";
            b1.Text = "из любого класса внутри компоновочного блока, в котором MyOut определен ";
            b2.Text = "из любого класса любого компоновочного блока";
            b3.Text = "только из классов с модификатором public";
            b4.Text = "только из классов, у которых доступность указана по умолчанию";
            //номер правильного ответа
            rightAnswer = 1;

            b.Text = "Закончить тест";

        }

    }
}
