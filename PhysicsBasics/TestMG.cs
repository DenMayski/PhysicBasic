using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsBasics
{
    public partial class TestMG : UserControl
    {
        //Глобальная переменная отвечает за то что тест решен Верно/Неверно
        public bool Res = false;

        double M;                                       //Глобальная переменныая хранит Массу объекта
        const double G = 9.81;                          //Глобальная константа Коэффициент силы тяжести
        double answ;                                    //Глобальная переменная хранит ответ на тест

        public TestMG()
        {
            InitializeComponent();
        }

        //Конструктор с параметром, N - номер задания
        public TestMG(int N) : this()
        {
            lblTest.Text = "Задание - " + N.ToString(); //Выводим номер теста
        }

        //Загрузка теста
        private void TestMG_Load(object sender, EventArgs e)
        {
            var rnd = new Random((int)DateTime.Now.Ticks);  //Случайное число

            M = Math.Round(rnd.NextDouble() * 501,2);
            lblMValue.Text = M.ToString() + " кг";

            answ = Math.Round(M * G, 2, MidpointRounding.AwayFromZero);
            //lblAnsw.Text = Math.Round(answ, 2, MidpointRounding.AwayFromZero).ToString();    
        }

        //При потере фокуса у ответа теста
        private void tbF_Leave(object sender, EventArgs e)
        {
            tbF.ReadOnly = true;                            //Поле ввода ответа становится недоступно
            tbF.ForeColor = Color.White;                    //Цвет текста - белый
            double Forse;                                //Результат из поля ввода
            if (Double.TryParse(tbF.Text, out Forse))    //Если поле ввода можно преобразовать к числу
                                                            //Res = Сравнение Результата из поля 
                Res = Math.Round(Forse, 2, MidpointRounding.AwayFromZero) == answ;  //и правильного ответа

            tbF.BackColor = Res ? Color.Green               //Если ответ правильный то цвет поля зеленый 
                : Color.Red;                                        //иначе красный
            lblAnsw.Text = Res ? "Правильно!" :             //Если ответ правильный то поздравления
                    String.Format("Вы ошиблись.\nПравильный ответ\n{0}Н",
                    answ);                         //Иначе вывод правильного ответа
        }
    }
}
