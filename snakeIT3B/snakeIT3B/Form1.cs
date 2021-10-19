using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakeIT3B
{
    public partial class Form1 : Form
    {
        PictureBox had1;
        List<PictureBox> pcasHada1;
        double rychlost1;
        double smer1;
        PictureBox had2;
        Timer timer;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            VytvorHady();
            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                smer1 += 0.1;
            }
            else if (e.KeyCode == Keys.D)
            {
                smer1 -= 0.1;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pcasHada1.Add(had1);

            had1 = new PictureBox();
            had1.Size = new Size(10, 10);
            var zmenaX = rychlost1 * Math.Cos(smer1);
            var zmenaY = rychlost1 * -Math.Sin(smer1);
            had1.Location = new Point(pcasHada1.Last().Location.X + Convert.ToInt32(zmenaX), pcasHada1.Last().Location.Y + Convert.ToInt32(zmenaY));
            had1.BackColor = Color.Yellow;
            this.Controls.Add(had1);

            
        }

        private void VytvorHady()
        {
            pcasHada1 = new List<PictureBox>();
            smer1 = 0;
            rychlost1 = 2;
            had1 = new PictureBox();
            had1.Size = new Size(10, 10);
            had1.Location = new Point(10, 10);
            had1.BackColor = Color.Yellow;
            this.Controls.Add(had1);

            had2 = new PictureBox();
            had2.Size = new Size(10, 10);
            had2.Location = new Point(ClientSize.Width-60, 10);
            had2.BackColor = Color.Red;
            this.Controls.Add(had2);
        }

    }
}
