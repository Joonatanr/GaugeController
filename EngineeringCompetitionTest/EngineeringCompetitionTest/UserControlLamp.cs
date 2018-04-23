using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringCompetitionTest
{
    public partial class UserControlLamp : UserControl
    {

        public Color LampColor { get; set; } = Color.Red;

        private Boolean m_value = false;
        public Boolean Value
        {
            get
            {
                return m_value;
            }

            set
            {
                m_value = value;
                this.Invalidate();
            }
        }

        public UserControlLamp()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Do I need to call this?
            base.OnPaint(e);

            Rectangle rect = new Rectangle(new Point(0, 0), new Size(this.Height - 1, this.Width - 1));

            Graphics gfx = e.Graphics;

            Pen myPen = new Pen(Color.Black);
            myPen.Width = 2;

            //Draw background color.
            SolidBrush myBrush = new SolidBrush(getDisplayedColor());
            gfx.FillEllipse(myBrush, rect);

            //Draw circle.
            gfx.DrawEllipse(myPen, rect);
        }

        private Color getDisplayedColor()
        {
            if (m_value)
            {
                //return Color.LightGreen;
                return ControlPaint.Light(LampColor);
            }
            else
            {
                //return Color.DarkGreen;
                return ControlPaint.Dark(LampColor);
            }
        }
    }
}
