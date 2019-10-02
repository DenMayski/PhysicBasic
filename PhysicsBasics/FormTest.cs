using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsBasics
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ClearTest();                                        //Очищаем тесты и оценку
            TestRoGV trgv = new TestRoGV();                     //Экземпляр теста
            int TestInRowCount = pTest.Width / trgv.Width;      //Количество тестов помещающихся в строку
            int nud = Int32.Parse(tsMenu.Items["nud"].Text);    //Значение из NumericUpDown
            int Rows = nud / TestInRowCount;                    //Количество полноценных строк
            int count = 1, i = 0;                               //Номер теста и номер строки

            for (; i < Rows; i++)
                for (int j = 0; j < TestInRowCount; j++, count++)
                    AddTest(i, j, count);                       //Отображаем полные строки с тестами

            for (int j = 0; j < nud - Rows * TestInRowCount; j++, count++)
                AddTest(i, j, count);                           //Отображаем последнюю строку с тестами
        }

        private void AddTest(int i, int j, int count)
        {
            if (((ToolStripComboBox)(tsMenu.Items["cbType"])).SelectedIndex == 0)
                //Добавляем тест на панель
                pTest.Controls.Add(new TestRoGV(count));
            else
                //Добавляем тест на панель
                pTest.Controls.Add(new TestMG(count));
            //Перемещаем тест на новую позицию исходя из его ширины, высоты и номера строки/столбца
            pTest.Controls[pTest.Controls.Count - 1].Location =
                new Point(pTest.Controls[pTest.Controls.Count - 1].Size.Width * j + j * 10,
                    pTest.Controls[pTest.Controls.Count - 1].Size.Height * i + i * 5);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTest();            //Очищаем тесты и оценку
        }

        private void ClearTest()
        {
            pTest.Controls.Clear(); //Очищаем панель
            lblRes.Text = "";       //Очищаем оценку
        }

        private void IncNum(bool right, ref int num)    //Метод на увеличение числа правильных ответов   
        {
            if (right)              //Если тест решен правильно
                num++;              //Увеличиваем количество правильных ответов на 1
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            int rightAnsw = 0;                                  //Количество правильных ответов

            foreach (UserControl t in pTest.Controls)           //Перебираем все тесты на форме
                t.Focus();      //Ставим фокус на тест, чтобы при переходе на следующий тест 
                                //Res = False если не решен или решен не верно

            tsMenu.Focus();     //Сброс фокуса с последнего элемента

            //Если выбран тест по Арихмедовой силе, то перебрать циклом формы типа TestRoGV 
            if (((ToolStripComboBox)tsMenu.Items["cbType"]).SelectedIndex == 0)
                foreach (TestRoGV test in pTest.Controls)
                    IncNum(test.Res, ref rightAnsw);        //Вызываем функцию подсчета правильных ответов
            //иначе перебрать циклом формы тип TestMG
            else
                foreach (TestMG test in pTest.Controls)
                    IncNum(test.Res, ref rightAnsw);        //Вызываем функцию подсчета правильных ответов

            double pers = (double)(rightAnsw) /             //Процент выполненной работы
                Int32.Parse(tsMenu.Items["nud"].Text) * 100;

            lblRes.Text = "Оценка - ";

            if (pers < 60)                                  //Если процент < 60 - Плохо
                lblRes.Text += "Плохо";
            else if (pers < 80)                                 //Если 60 < процент < 80 - Удовлетворительно
                lblRes.Text += "Удовлетворительно";
            else if (pers < 100)                                //Если 80 < процент < 100 - Хорошо
                lblRes.Text += "Хорошо";
            else                                                //Если процент == 100 - Отлично
                lblRes.Text += "Отлично";
        }



        private void FormTest_Load(object sender, EventArgs e)
        {
            //Создаем объект NumericUpDown и описываем его
            NumericUpDown nud = new NumericUpDown();
            nud.Maximum = 20;       //Максимум 20
            nud.Minimum = 1;        //Минимум 1

            //Добавлем nud на ToolStrip и описываем его 
            ToolStripControlHost tsch = new ToolStripControlHost(nud);  //Создаем объект
            tsch.Name = "nud";                      //Даем имя nud
            tsch.Margin = new Padding(20, 0, 0, 0); //Отступ слева 20
            tsMenu.Items.Add(tsch);                 //Добавляем nud на ToolStrip

            //Создаем кнопки очистить и завершить тест на ToolStrip и описываем
            ToolStripButton btn = new ToolStripButton();    //Создаем кнопку ОЧИСТИТЬ
            btn.Name = "btnClear";                  //Задаем имя кнопке
            btn.Margin = new Padding(20, 0, 0, 0);     //Отступ слева 20
            btn.BackColor = Color.Pink;             //Цвет кнопки розовый
            btn.Text = "Очистить";                  //Текст на кнопке
            btn.Click += btnClear_Click;            //Добавляем событие очистки на нажатие
            tsMenu.Items.Add(btn);                  //Добавляем кнопку на ToolStrip


            btn = new ToolStripButton();            //Создаем кнопку ЗАВЕРШИТЬ
            btn.Name = "btnFinal";                  //Задаем имя кнопке
            btn.Text = "Завершить тестирование";    //Текст на кнопке
            btn.Margin = new Padding(20, 0, 0, 0);     //Отступ слева 20
            btn.BackColor = Color.Red;              //Цвет кнопки красный
            btn.Click += btnFinal_Click;            //Добавляем событие проверки теста на нажатие
            tsMenu.Items.Add(btn);                  //Добавляем кнопку на ToolStrip

            ToolStripComboBox cb = new ToolStripComboBox(); //Создаем ComboBox    
            cb.Name = "cbType";                     //Задаем имя ComboBox
            cb.Size = new Size(145, 22);            //Задаем размер ComboBox
            cb.Items.Add("Сила архимеда");          //Добавляем пункт
            cb.Items.Add("Сила тяжести");           //Добавляем пункт
            cb.SelectedIndex = 0;                   //Устанавливаем выбранным пункт 0
            cb.Font = tsMenu.Font;                  //Выставляем шрифт как у меню
            cb.Margin = new Padding(20, 0, 0, 0);   //Отступ слева 20
            cb.DropDownStyle = ComboBoxStyle.DropDownList;  //Выпадающий список и нельзя редактировать
            tsMenu.Items.Add(cb);                   //Добавляем ComboBox на ToolStrip
        }
    }
}