using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        //Удвоитель
        //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
        //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
        //в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
        //Вся логика игры должна быть реализована в классе с удвоителем.
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Game form = new Game();
            this.Visible = false;
            this.IsAccessible = false;
            form.Show(this);
        }
        
        //Угодай число
        //Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.  
        //a) Для ввода данных от человека используется элемент TextBox;
        //б) **Реализовать отдельную форму c TextBox для ввода числа.
        private void buttonGuessNumber_Click(object sender, EventArgs e)
        {
            GuessNumber form = new GuessNumber();
            this.Visible = false;
            this.IsAccessible = false;
            form.Show(this);
        }
    }
}
