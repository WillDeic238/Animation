using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Animation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics(); //Creates all of the drawing materials.

            SolidBrush blackBrush = new SolidBrush(Color.Black); //For Drawing all of the shapes/lines.
            Pen blackPen = new Pen(Color.Black);
            Pen blackPen2 = new Pen(Color.Black, 16);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen whitePen = new Pen(Color.White);
            SolidBrush GrayBrush = new SolidBrush(Color.DimGray);
            Pen grayPen = new Pen(Color.DimGray, 100);
            Pen grayPen2 = new Pen(Color.DimGray, 25);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Pen redPen = new Pen(Color.Red);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            Pen orangePen = new Pen(Color.Orange, 300);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Pen yellowPen = new Pen(Color.Yellow);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            Pen greenPen = new Pen(Color.Green);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Pen bluePen = new Pen(Color.Blue);
            SolidBrush purpleBrush = new SolidBrush(Color.Purple);
            Pen purplePen = new Pen(Color.Purple);
            Font drawFont = new Font ("Arial", 32, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);


            g.Clear(Color.Green); //Draws the background
            g.FillRectangle(GrayBrush, 250, 0, 525, 675);
 
            g.FillRectangle(redBrush, 200, 0, 50, 50); //draws red & white sidelines on left side
            g.FillRectangle(whiteBrush, 200, 50, 50, 50);
            g.FillRectangle(redBrush, 200, 100, 50, 50); 
            g.FillRectangle(whiteBrush, 200, 150, 50, 50);
            g.FillRectangle(redBrush, 200, 200, 50, 50);
            g.FillRectangle(whiteBrush, 200, 250, 50, 50);
            g.FillRectangle(redBrush, 200, 300, 50, 50);
            g.FillRectangle(whiteBrush, 200, 350, 50, 50);
            g.FillRectangle(redBrush, 200, 400, 50, 50);
            g.FillRectangle(whiteBrush, 200, 450, 50, 50);
            g.FillRectangle(redBrush, 200, 500, 50, 50);
            g.FillRectangle(whiteBrush, 200, 550, 50, 50);
            g.FillRectangle(redBrush, 200, 600, 50, 50);
            g.FillRectangle(whiteBrush, 200, 650, 50, 50);

            g.FillRectangle(redBrush, 775, 0, 50, 50);  // draws red & white sidelines on right side.
            g.FillRectangle(whiteBrush, 775, 50, 50, 50);
            g.FillRectangle(redBrush, 775, 100, 50, 50);
            g.FillRectangle(whiteBrush, 775, 150, 50, 50);
            g.FillRectangle(redBrush, 775, 200, 50, 50);
            g.FillRectangle(whiteBrush, 775, 250, 50, 50);
            g.FillRectangle(redBrush, 775, 300, 50, 50);
            g.FillRectangle(whiteBrush, 775, 350, 50, 50);
            g.FillRectangle(redBrush, 775, 400, 50, 50);
            g.FillRectangle(whiteBrush, 775, 450, 50, 50);
            g.FillRectangle(redBrush, 775, 500, 50, 50);
            g.FillRectangle(whiteBrush, 775, 550, 50, 50);
            g.FillRectangle(redBrush, 775, 600, 50, 50);
            g.FillRectangle(whiteBrush, 775, 650, 50, 50);

            g.FillRectangle(whiteBrush, 250, 100, 525, 50); //draws finish line
            g.FillRectangle(blackBrush, 250, 100, 25, 25);
            g.FillRectangle(blackBrush, 275, 125, 25, 25);
            g.FillRectangle(blackBrush, 300, 100, 25, 25);
            g.FillRectangle(blackBrush, 325, 125, 25, 25);
            g.FillRectangle(blackBrush, 350, 100, 25, 25);
            g.FillRectangle(blackBrush, 375, 125, 25, 25);
            g.FillRectangle(blackBrush, 400, 100, 25, 25);
            g.FillRectangle(blackBrush, 425, 125, 25, 25);
            g.FillRectangle(blackBrush, 450, 100, 25, 25);
            g.FillRectangle(blackBrush, 475, 125, 25, 25);
            g.FillRectangle(blackBrush, 500, 100, 25, 25);
            g.FillRectangle(blackBrush, 525, 125, 25, 25);
            g.FillRectangle(blackBrush, 550, 100, 25, 25);
            g.FillRectangle(blackBrush, 575, 125, 25, 25);
            g.FillRectangle(blackBrush, 600, 100, 25, 25);
            g.FillRectangle(blackBrush, 625, 125, 25, 25);
            g.FillRectangle(blackBrush, 650, 100, 25, 25);
            g.FillRectangle(blackBrush, 675, 125, 25, 25);
            g.FillRectangle(blackBrush, 700, 100, 25, 25);
            g.FillRectangle(blackBrush, 725, 125, 25, 25);
            g.FillRectangle(blackBrush, 750, 100, 25, 25);
            
            g.DrawString("Get Well Soon", drawFont, drawBrush, 360, 25); //title message saying get well soon
            
            g.FillRectangle(orangeBrush, 450, 250, 150, 100); //Draws Mclaren F1 Car
            g.DrawLine(grayPen, 450, 215, 650, 315);
            g.DrawLine(grayPen, 400, 300, 600, 200);
            g.DrawLine(grayPen2, 400, 340, 600, 340);
            g.FillRectangle(orangeBrush, 498, 325, 25, 50);
            g.DrawRectangle(blackPen,498, 325, 25, 50);
            g.FillRectangle(orangeBrush, 472, 360, 79, 175);
            g.DrawRectangle(blackPen2, 472, 360, 79, 175);
            g.DrawLine(blackPen2, 442, 375, 472, 375);
            g.DrawLine(blackPen2, 551, 375, 581, 375);
            g.DrawLine(blackPen2, 442, 500, 472, 500);
            g.DrawLine(blackPen2, 551, 500, 581, 500);
            g.FillRectangle(blackBrush, 425,350, 30, 50);
            g.FillRectangle(blackBrush, 569, 350, 30, 50);
            g.FillRectangle(blackBrush, 425, 477, 30, 50);
            g.FillRectangle(blackBrush, 569, 477, 30, 50);
            g.DrawLine(blackPen2, 490, 535, 490, 560);
            g.DrawLine(blackPen2, 535, 535, 535, 560);
            g.FillRectangle(orangeBrush, 470, 560, 85, 30);



        }

        private void Form1_Click(object sender, EventArgs e)
        {
       
            SoundPlayer player = new SoundPlayer(Properties.Resources.vroom); //Plays "vroom" sound 
            player.Play();

          
            int i = 1;
            while (i<=20)
            {
                i++;
                Graphics g = this.CreateGraphics(); //allows for all drawing materials for animation

                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Pen blackPen = new Pen(Color.Black);
                Pen blackPen2 = new Pen(Color.Black, 16);
                SolidBrush whiteBrush = new SolidBrush(Color.White);
                Pen whitePen = new Pen(Color.White);
                SolidBrush GrayBrush = new SolidBrush(Color.DimGray);
                Pen grayPen = new Pen(Color.DimGray, 100);
                Pen grayPen2 = new Pen(Color.DimGray, 25);
                SolidBrush redBrush = new SolidBrush(Color.Red);
                Pen redPen = new Pen(Color.Red);
                SolidBrush orangeBrush = new SolidBrush(Color.Orange);
                Pen orangePen = new Pen(Color.Orange, 300);
                SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
                Pen yellowPen = new Pen(Color.Yellow);
                SolidBrush greenBrush = new SolidBrush(Color.Green);
                Pen greenPen = new Pen(Color.Green);
                SolidBrush blueBrush = new SolidBrush(Color.Blue);
                Pen bluePen = new Pen(Color.Blue);
                SolidBrush purpleBrush = new SolidBrush(Color.Purple);
                Pen purplePen = new Pen(Color.Purple);
                Font drawFont = new Font("Arial", 32, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                
                Graphics g2 = this.CreateGraphics();
                g2.Clear(Color.Green);
                g2.FillRectangle(GrayBrush, 250, 0, 525, 675);
                g2.FillRectangle(redBrush, 200, 0, 50, 50);

                g2.FillRectangle(whiteBrush, 200, 50, 50, 50);
                g2.FillRectangle(redBrush, 200, 100, 50, 50);
                g2.FillRectangle(whiteBrush, 200, 150, 50, 50);
                g2.FillRectangle(redBrush, 200, 200, 50, 50);
                g2.FillRectangle(whiteBrush, 200, 250, 50, 50);
                g2.FillRectangle(redBrush, 200, 300, 50, 50);
                g2.FillRectangle(whiteBrush, 200, 350, 50, 50);
                g2.FillRectangle(redBrush, 200, 400, 50, 50);
                g2.FillRectangle(whiteBrush, 200, 450, 50, 50);
                g2.FillRectangle(redBrush, 200, 500, 50, 50);
                g2.FillRectangle(whiteBrush, 200, 550, 50, 50);
                g2.FillRectangle(redBrush, 200, 600, 50, 50);
                g2.FillRectangle(whiteBrush, 200, 650, 50, 50);

                g2.FillRectangle(redBrush, 775, 0, 50, 50);
                g2.FillRectangle(whiteBrush, 775, 50, 50, 50);
                g2.FillRectangle(redBrush, 775, 100, 50, 50);
                g2.FillRectangle(whiteBrush, 775, 150, 50, 50);
                g2.FillRectangle(redBrush, 775, 200, 50, 50);
                g2.FillRectangle(whiteBrush, 775, 250, 50, 50);
                g2.FillRectangle(redBrush, 775, 300, 50, 50);
                g2.FillRectangle(whiteBrush, 775, 350, 50, 50);
                g2.FillRectangle(redBrush, 775, 400, 50, 50);
                g2.FillRectangle(whiteBrush, 775, 450, 50, 50);
                g2.FillRectangle(redBrush, 775, 500, 50, 50);
                g2.FillRectangle(whiteBrush, 775, 550, 50, 50);
                g2.FillRectangle(redBrush, 775, 600, 50, 50);
                g2.FillRectangle(whiteBrush, 775, 650, 50, 50);

                g2.FillRectangle(whiteBrush, 250, 100 + 10 * i, 525, 50); // animation makes the finish line move as a car crosses it
                g2.FillRectangle(blackBrush, 250, 100 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 275, 125 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 300, 100 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 325, 125 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 350, 100 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 375, 125 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 400, 100 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 425, 125 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 450, 100 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 475, 125 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 500, 100 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 525, 125 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 550, 100 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 575, 125 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 600, 100 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 625, 125 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 650, 100 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 675, 125 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 700, 100 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 725, 125 + 10 * i, 25, 25);
                g2.FillRectangle(blackBrush, 750, 100 + 10 * i, 25, 25);
                g2.DrawString("From All of us at F1", drawFont, drawBrush, 360, 25);

                g2.FillRectangle(orangeBrush, 450, 250 - 10 * i, 150, 100);
                g2.DrawLine(grayPen, 450, 215 - 10 * i, 650, 315 - 10 * i); // moves the car fowards to cross the finish line
                g2.DrawLine(grayPen, 400, 300 - 10 * i, 600, 200 - 10 * i);
                g2.DrawLine(grayPen2, 400, 340 - 10 * i, 600, 340 - 10 * i);
                g2.FillRectangle(orangeBrush, 498, 325 - 10 * i, 25, 50);
                g2.DrawRectangle(blackPen, 498, 325 - 10 * i, 25, 50);
                g2.FillRectangle(orangeBrush, 472, 360 - 10 * i, 79, 175);
                g2.DrawRectangle(blackPen2, 472, 360 - 10 * i, 79, 175);
                g2.DrawLine(blackPen2, 442, 375 - 10 * i, 472, 375 - 10 * i);
                g2.DrawLine(blackPen2, 551, 375 - 10 * i, 581, 375 - 10 * i);
                g2.DrawLine(blackPen2, 442, 500 - 10 * i, 472, 500 - 10 * i);
                g2.DrawLine(blackPen2, 551, 500 - 10 * i, 581, 500 - 10 * i);
                g2.FillRectangle(blackBrush, 425, 350 - 10 * i, 30, 50);
                g2.FillRectangle(blackBrush, 569, 350 - 10 * i, 30, 50);
                g2.FillRectangle(blackBrush, 425, 477 - 10 * i, 30, 50);
                g2.FillRectangle(blackBrush, 569, 477 - 10 * i, 30, 50);
                g2.DrawLine(blackPen2, 490, 535 - 10 * i, 490, 560 - 10 * i);
                g2.DrawLine(blackPen2, 535, 535 - 10 * i, 535, 560 - 10 * i);
                g2.FillRectangle(orangeBrush, 470, 560 - 10 * i, 85, 30 - 10 * i);
               
                g2.DrawString("From All of us at F1", drawFont, drawBrush, 360, 25); // new message saying "Froma all of us at F1"
            }
        }
    }
}