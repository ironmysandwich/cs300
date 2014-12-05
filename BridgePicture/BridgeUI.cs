using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgeControlSystem
{
    /// <summary>
    ///  This class draws the form, the bridge graphic, and responds
    ///  to button clicks on the UI.
    /// </summary>
    public partial class Form1 : Form
    {
        //Attributes for bridge status
        private bool isRaised = false;
        private bool isClosed = false;
        private bool isMoving = false;
        private bool isTrafficChanging = false;

        //Attributes for graphics
        Pen myPen = new Pen(Color.Black);
        SolidBrush myBrush = new SolidBrush(Color.LimeGreen);
        Graphics g = null;
        static int start_y, left_x, right_x;

        public Form1()
        {
            InitializeComponent();

            //calculate starting points
            left_x = canvas.Width / 4;
            right_x = canvas.Width - (canvas.Width / 4);
            start_y = canvas.Height - (canvas.Height / 4);

        }

        private void increment_TextChanged(object sender, EventArgs e)
        {

        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            myPen.Width = 2;
            g = canvas.CreateGraphics();

            drawBridge();
        }

        /// <summary>
        ///  This method draws the bridge graphic according to current
        ///  attributes.
        /// </summary>
        private void drawBridge()
        {
            canvas.CreateGraphics().Clear(canvas.BackColor);
            Point[] leftSide = 
            {
                new Point(left_x, start_y),
                new Point(left_x, start_y - canvas.Height/2),
                new Point(left_x + 50, start_y - canvas.Height/2),
                new Point(left_x + 50, start_y),
                new Point(left_x, start_y)
            };

            Point[] rightSide = 
            {
                new Point(right_x, start_y),
                new Point(right_x, start_y - canvas.Height/2),
                new Point(right_x + 50, start_y - canvas.Height/2),
                new Point(right_x + 50, start_y),
                new Point(right_x, start_y)
            };

            Point[] middleLowered = 
            {
                new Point(left_x + 50, start_y - 10),
                new Point(left_x + 50, start_y - 60),
                new Point(left_x + canvas.Width/2, start_y - 60),
                new Point(left_x + canvas.Width/2, start_y - 10),
                new Point(left_x + 50, start_y - 10)
            };

            Point[] middleRaised = 
            {
                new Point(left_x + 50, start_y - canvas.Height/2 + 50),
                new Point(left_x + 50, start_y - canvas.Height/2),
                new Point(left_x + canvas.Width/2, start_y - canvas.Height/2),
                new Point(left_x + canvas.Width/2, start_y - canvas.Height/2 + 50),
                new Point(left_x + 50, start_y - canvas.Height/2 + 50)
            };

            Point[] arrowUp =
            {
                new Point(canvas.Width/2, start_y - 80),
                new Point(canvas.Width/2, start_y - 120),
                new Point(canvas.Width/2 - 10, start_y - 120),
                new Point(canvas.Width/2 + 10, start_y - 150),
                new Point(canvas.Width/2 + 30, start_y - 120),
                new Point(canvas.Width/2 + 20, start_y - 120),
                new Point(canvas.Width/2 + 20, start_y - 80),
                new Point(canvas.Width/2, start_y - 80)
            };

            Point[] arrowDown =
            {
                new Point(canvas.Width/2, start_y - 40),
                new Point(canvas.Width/2, start_y - 80),
                new Point(canvas.Width/2 + 20, start_y - 80),
                new Point(canvas.Width/2 + 20, start_y - 40),
                new Point(canvas.Width/2 + 30, start_y - 40),
                new Point(canvas.Width/2 + 10, start_y - 20),
                new Point(canvas.Width/2 - 10, start_y - 40),
                new Point(canvas.Width/2, start_y - 40)
            };

            myPen.Color = System.Drawing.Color.Black;
            g.DrawLines(myPen, leftSide);
            g.DrawLines(myPen, rightSide);

            if (!isRaised)
            {
                myPen.Color = System.Drawing.Color.Gray;
                g.DrawLines(myPen, middleLowered);
                if (isMoving)
                {
                    myPen.Color = System.Drawing.Color.Black;
                    g.DrawLines(myPen, arrowUp);
                }
            }
            else
            {
                myPen.Color = System.Drawing.Color.Gray;
                g.DrawLines(myPen, middleRaised);
                if (isMoving)
                {
                    myPen.Color = System.Drawing.Color.Black;
                    g.DrawLines(myPen, arrowDown);
                }
            }



            if (isTrafficChanging)
                myBrush.Color = System.Drawing.Color.Yellow;
            else if (isClosed)
                myBrush.Color = System.Drawing.Color.Red;
            else
                myBrush.Color = System.Drawing.Color.LimeGreen;
            g.FillEllipse(myBrush, left_x + 5, start_y - 55, 40, 40);
            g.FillEllipse(myBrush, left_x + 5 + canvas.Width / 2, start_y - 55, 40, 40);

        }

        /// <summary>
        ///  This method is the event listener for the UI's traffic button.
        /// </summary>
        private void trafficbutton_Click(object sender, EventArgs e)
        {
            this.isTrafficChanging = true;
            drawBridge();
            renderForm();

            if (isClosed)
            {
                //Call open function of bridge object
                //Delete all below - just for testing
                System.Threading.Thread.Sleep(3000);
                openSuccess();
            }
            else
            {
                //Call close function of bridge object
                //Delete all below - just for testing
                System.Threading.Thread.Sleep(3000);
                closeSuccess();
            }


        }

        /// <summary>
        ///  This method is the event listener for the UI's bridge button.
        /// </summary>
        private void bridgebutton_Click(object sender, EventArgs e)
        {
            this.isMoving = true;
            drawBridge();
            renderForm();

            if (isRaised)
            {
                //Call lower function of bridge object
                //Delete all below - just for testing
                System.Threading.Thread.Sleep(3000);
                lowerSuccess();
            }
            else
            {
                //Call raise function of bridge object
                //Delete all below - just for testing
                System.Threading.Thread.Sleep(3000);
                raiseSuccess();
            }
        }

        /// <summary>
        ///  The following four methods are call-backs from the Bridge object
        ///  indicating success of raising/lowering the bridge and open/closing
        ///  to traffic.
        /// </summary>
        public void closeSuccess()
        {
            this.isTrafficChanging = false;
            this.isClosed = true;
            drawBridge();
            renderForm();
        }

        public void openSuccess()
        {
            this.isTrafficChanging = false;
            this.isClosed = false;
            drawBridge();
            renderForm();
        }

        public void raiseSuccess()
        {
            this.isMoving = false;
            this.isRaised = true;
            drawBridge();
            renderForm();
        }

        public void lowerSuccess()
        {
            this.isMoving = false;
            this.isRaised = false;
            drawBridge();
            renderForm();
        }

        /// <summary>
        ///  This method is called when a notification is sent to display
        ///  notification success to the user.
        ///  Input: String with notification messgae
        /// </summary>
        public void notificationSent(String msg)
        {
            MessageBox.Show("Notification Sent: " + msg);
        }

    }
}
