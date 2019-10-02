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
    public partial class TestRoGV : UserControl
    {
        //Глобальная переменная отвечает за то что тест решен Верно/Неверно
        public bool Res = false;            
        
        double Ro, V;                                   //Глобальные переменные Плотность и Объем
        const double G = 9.81;                          //Глобальная константа Коэффициент силы тяжести
        double answ;                                    //Глобальная переменная хранит ответ на тест
        public TestRoGV()
        {
            InitializeComponent();
        }

        //Конструктор с параметром, N - номер задания
        public TestRoGV(int N) : this()
        {
            lblTest.Text = "Задание - " + N.ToString(); //Выводим номер теста
        }

        //Загрузка теста
        private void TestRoGV_Load(object sender, EventArgs e)  
        {
            var rnd = new Random((int)DateTime.Now.Ticks);  //Случайное число

            Ro = Math.Round(rnd.NextDouble() * 1000, 2);     //Случайная плотность
            lblRoValue.Text = Ro.ToString() + " кг/м^3";    //Выводим плотность

            V = Math.Round(rnd.NextDouble() * 50, 2);       //Случайный объем
            lblVValue.Text = V.ToString() + " м^3";         //Выводим объем
            answ = Math.Round(Ro * G * V, 2, MidpointRounding.AwayFromZero);
            //lblAnsw.Text = Math.Round(answ, 2, MidpointRounding.AwayFromZero).ToString();    
        }

        //При потере фокуса у ответа теста
        private void tbF_Leave(object sender, EventArgs e)
        {
            tbF.ReadOnly = true;                            //Поле ввода ответа становится недоступно
            tbF.ForeColor = Color.White;                    //Цвет текста - белый
            double ArhForse;                                //Результат из поля ввода
            if (Double.TryParse(tbF.Text, out ArhForse))    //Если поле ввода можно преобразовать к числу
                                                            //Res = Сравнение Результата из поля 
                Res = Math.Round(ArhForse, 2, MidpointRounding.AwayFromZero) ==
                    Math.Round(answ, 2, MidpointRounding.AwayFromZero);  //и правильного ответа

            tbF.BackColor = Res ? Color.Green               //Если ответ правильный то цвет поля зеленый 
                : Color.Red;                                        //иначе красный
            lblAnsw.Text = Res ? "Правильно!" :             //Если ответ правильный то поздравления
                    String.Format("Вы ошиблись.\nПравильный ответ\n{0}Н", 
                    answ);                         //Иначе вывод правильного ответа
        }
    }
}
