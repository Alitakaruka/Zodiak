using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d;
            d = DateTime.Today;
            DateTime x = Convert.ToDateTime(maskedTextBox1.Text);
  
            DateTime  date = Convert.ToDateTime (maskedTextBox1.Text);
            int years = d.Year - date.Year;
            label2.Text = Convert.ToString(years);

            label4.Text =Convert.ToString (date.DayOfWeek);

            switch (label4.Text) {
                case "Monday":
                    label4.Text += "(Понедельник)";
                    break;
                case "Tuesday":
                    label4.Text += "(Вторник)";
                    break;
                case "Wednesday":
                    label4.Text += "(Среда)";
                    break;
                case "Thursday":
                    label4.Text += "(Четверг)";
                    break;
                case "Friday":
                    label4.Text += "(Пятница)";
                    break;
                case "Saturday":
                    label4.Text += "(Суббота)";
                    break;
                case "Sunday":
                    label4.Text += "(Высплюсенье)";
                        break;
                    default:
                    break;
            }

            DateTime vodolei = new DateTime(date.Year, 01, 20);   
            DateTime vodolei2 = new DateTime(date.Year, 02, 18);
            
            DateTime riba = new DateTime(date.Year, 02, 19);   
            DateTime riba2 = new DateTime(date.Year, 03, 20);   

            DateTime oven = new DateTime(date.Year, 03, 21);   
            DateTime oven2 = new DateTime(date.Year, 04, 19);

            DateTime telec = new DateTime(date.Year, 04, 20);
            DateTime telec2 = new DateTime(date.Year, 05, 20);

            DateTime twins = new DateTime(date.Year, 05, 21);
            DateTime twin2s = new DateTime(date.Year, 06, 21);

            DateTime rak = new DateTime(date.Year, 06, 22);
            DateTime rak2 = new DateTime(date.Year, 07, 22);

            DateTime lev = new DateTime(date.Year, 07, 23);
            DateTime lev2 = new DateTime(date.Year, 08, 22);

            DateTime deva = new DateTime(date.Year, 08, 23);
            DateTime deva2 = new DateTime(date.Year, 09, 22);

            DateTime vesi = new DateTime(date.Year, 09, 23);
            DateTime vesi2 = new DateTime(date.Year, 10, 22); 

            DateTime skorpion = new DateTime(date.Year, 10, 23);
            DateTime skorpion2 = new DateTime(date.Year, 11, 22);

            DateTime strelec = new DateTime(date.Year, 11, 23);
            DateTime strelec2 = new DateTime(date.Year, 12, 21);

            DateTime kozerog = new DateTime(date.Year, 11, 22);
            DateTime kozerog2 = new DateTime(date.Year-1, 01, 19);

            if (date == vodolei || date <= vodolei2)
            {
                label7.Text = "Водолей";
            }
            if (date == riba || date <= riba2)
            {
                label7.Text = "рыба";
            }
            if (date == oven || date <= oven2)
            {
                label7.Text = "Овен";
            }
            if (date == telec || date <= telec2)
            {
                label7.Text = "Телец";
            }
            if (date == twins || date <= twin2s)
            {
                label7.Text = "Близнецы";
            }
            if (date == rak || date <= rak2)
            {
                label7.Text = "Рак";
            }
            if (date == lev || date <= lev2)
            {
                label7.Text = "Лев";
            }
            if (date == deva || date <= deva2)
            {
                label7.Text = "Дева";
            }
            if (date == vesi || date <= vesi2)
            {
                label7.Text = "Весы";
            }
            if (date == skorpion || date <= skorpion2)
            {
                label7.Text = "Скорпион";
            }
            if (date == strelec || date <= strelec2)
            {
                label7.Text = "Стрелец";
            }
            if (date == kozerog || date <= kozerog2)
            {
                label7.Text = "Козерог";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
