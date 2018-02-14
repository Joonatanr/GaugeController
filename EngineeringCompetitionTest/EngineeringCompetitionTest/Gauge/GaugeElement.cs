using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaugeControl
{
    public abstract class GaugeElement
    {

        public PointF Offset { get; set; } = new PointF(0, 0);
        public String Name { get; set; } = "GaugeElement";

        protected PointF    m_centerPoint = new PointF(0,0);
        
        public void Draw(Graphics g, PointF centerPoint)
        {
            m_centerPoint = centerPoint;
            m_centerPoint.X += Offset.X;
            m_centerPoint.Y += Offset.Y;
            DrawElement(g);
        }

        protected abstract void DrawElement(Graphics g);
    }
}
