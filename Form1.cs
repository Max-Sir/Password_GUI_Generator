using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Password_GUI_Generator
{
    public partial class Form1 : Form
    {
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //Создаём новый экземпляр генератора псевдослучайных чисел
            Random rnd = new Random();
            //Перемещаем кнопку на случайную позицию
            button1.Location = new Point(
                rnd.Next(0, this.Width - 50),
                rnd.Next(0, this.Height - 50));
        }

        private readonly string _all = str();

        string GenRandomString(string Alphabet, int Length)
        {
            Random rnd = new Random();
            string x = "";
            for (int i = 0; i < Length; i++)
            {
                var Position = rnd.Next(0, Alphabet.Length - 1);
                x += Alphabet[Position];
            }


            return x;
        }

        public void check()
        {
            if (textBox1.Text == "")
            {
                button1.Text = @"gen password";
            }
        }

        public Form1()
        {
            InitializeComponent();
            textBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = @"Hello";
            textBox1.Text = GenRandomString(_all, _x);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Text = @"Your password is " + textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = @"Hail!!!";
            textBox1.Text = "";
            check();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string bt = button1.Text;
            button1.Visible = false;
            checkBox1.Text = @"Show";
            string text = textBox1.Text;
            if (checkBox1.Checked == true)
            {
                textBox1.Hide();
                checkBox1.Text = @"Show";
                //  textBox1.Show();

            }

            //    button1.Text = GenRandomString(_all,15);
            //  System.Threading.Thread.Sleep(1000);
            button1.Text = @"";
            if (checkBox1.Checked != true)
            {
                button1.Visible = true;
                textBox1.Show();
                checkBox1.Text = @"Hide";

            }

            button1.Text = bt;

            textBox1.Text = text;
        }
public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        private void Form1_Load(object sender, EventArgs e)
        {
            WMP.URL = @"sound.mp3";// файл музыкальный
              WMP.settings.volume = 100; // меняя значение можно регулировать громкость
              WMP.controls.play(); // Старт
                                   ////  WMP.controls.stop(); // Стоп
                                   ////  WMP.close();
                                   //////for(var i=0;i<5;i++)
                                   //////{ SystemSounds.Beep.Play();}
                                   ///
                                   var appSettings = Properties.Settings.Default;
                                   if (appSettings.FirstStartup)
                                   {
                                       MessageBox.Show(@"Дисклеймер:
    запомни, чтобы закрыть это приложение нужно
    снять его в Task Manager
    если нажимать на крестик >15 раз то есть вероятность
    перегрузить оперативку!");

                                       appSettings.FirstStartup = false;
                                       appSettings.Save();
                                   }
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Show();
            if (!checkBox2.Checked)
            {
                textBox2.Hide();
            }
        }

        public static int _x = 15;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //_x = (textBox2.Text != "") ? int.Parse(textBox2.Text) :
            //    (textBox2.Text == "") ? 0 : int.Parse(textBox2.Text + "\b");

            _x = (textBox2.Text=="")?0:int.Parse(textBox2.Text);
        }


        const int maximum = 1000;

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar==(char) Keys.Back/*|| e.KeyChar == ',' || e.KeyChar == '.'*/)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            //Создаём новый экземпляр генератора псевдослучайных чисел
            Random rnd = new Random();
            //Перемещаем кнопку на случайную позицию
            button1.Location = new Point(
                rnd.Next(0, this.Width - 50),
                rnd.Next(0, this.Height - 50));
            SystemSounds.Beep.Play();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
            //Создаём новый экземпляр генератора псевдослучайных чисел
            Random rnd = new Random();
            //Перемещаем кнопку на случайную позицию
            textBox1.Location = new Point(
                rnd.Next(0, this.Width - 50),
                rnd.Next(0, this.Height - 50));
           // SystemSounds.Beep.Play();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ////Создаём новый экземпляр генератора псевдослучайных чисел
            //Random rnd = new Random();
            ////Перемещаем кнопку на случайную позицию
            //button1.Location = new Point(
            //    rnd.Next(0, this.Width - 50),
            //    rnd.Next(0, this.Height - 50));


        }

        public static int _n = 2;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            // if (textBox2.Text == @"1111")
            // {
            //Application.Exit();
           // Application.Run(new Form1());
            //this.Close();
            // }
            for (int i = 0; i < _n; i++)
            {
                Form1 f2 = new Form1();
                f2.Show();
            }

            _n*= 2;

            //   this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
        }

        Random r = new Random();
        private void Form1_Click(object sender, EventArgs e)
        {
            int red = r.Next(255);
            int green = r.Next(255);
            int blue = r.Next(255);
            Color color = Color.FromArgb(red, green, blue);
            this.BackColor = color;
            this.Text = "R: " + red + " G: " + green + " B: " + blue;
        }

        //public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //// символ - число
        //    bool isNumber = char.IsNumber(e.KeyChar);
        //    //if (isNumber)
        //    //{
        //    //    // текстовое поле, на котором сработало событие
        //    //    TextBox tb = sender as TextBox;
        //    //    // Если введёное число в сочетании с текущим текстом в поле
        //    //    // болььше или равно максимальному, запрещаем вводить
        //    //    e.Handled = int.Parse(tb.Text + e.KeyChar.ToString()) >= maximum;
        //    //}
        //   // else
        //        // запрещаем ввод любого не числа и не управляющего символа (tab, del, backspace и т.п.)
        //        e.Handled = !(isNumber || char.IsControl(e.KeyChar));
        //}

        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if ((e.KeyChar >= '1' && e.KeyChar <= '9') /*|| e.KeyChar == ',' || e.KeyChar == '.'*/)
        //    {
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}