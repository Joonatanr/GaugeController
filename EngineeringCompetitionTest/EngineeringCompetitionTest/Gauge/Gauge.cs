using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;
using System.Globalization;
using System.Collections;
using System.ComponentModel.Design;
using System.Collections.ObjectModel;

namespace GaugeControl
{
    public class Gauge : UserControl
    {
        private Boolean drawGaugeBackground = true;

        private float m_angle = 0.0f;
        private Decimal m_value = 0;

        private PointF CenterPoint;
        private Bitmap gaugeBitmap;

        private List<GaugeMarker> m_markerList = new List<GaugeMarker>();
        private List<GaugeLabel> customTextList = new List<GaugeLabel>();
        private Dictionary<string, GaugeNeedle> customNeedleDictionary = new Dictionary<string, GaugeNeedle>();

        private Size        m_needleSize =                  new Size(4,66);
        private Color       m_needleColor =                 Color.Red;
        private float       m_needleCenterRadius =          10;
        private Color       m_needleCenterColor =           Color.Chocolate;

        private Boolean     m_isArcEnabled =                true;
        private int         m_arcWidth =                    3;
        private float       m_arcStartAngle =               120f;
        private float       m_arcEndAngle =                 400f;
        private float       m_arcRadius =                   80;
        private Color       m_arcColor =                    Color.White;

        private float       m_NumberMarkerAngleBegin =     120f;
        private float       m_NumberMarkerAngleInterval =   40f;
        private float       m_NumberMarkerAngleEnd =       400f;

        private Decimal     m_NumberMarkerValueBegin =      200;
        private Decimal     m_NumberMarkerValueInterval =   100;
        private Decimal     m_NumberMarkerValueEnd =       1000;

        private int         m_NumberMarkerWidth =           40;
        private int         m_NumberMarkerHeight =          12;
        private int         m_NumberMarkerOffset =         -18;
        private Color       m_NumberMarkerColor =           Color.White;
        private Font        m_NumberMarkerFont =            new Font ("Tahoma",8);


        private Boolean     m_isBackGroundEllipseEnabled =  true;
        private Color       m_backGroundEllipseColor =      Color.Black;
        private float       m_backGroundEllipseRadius =     90;

        private GaugeBorder m_Border;
        private Boolean     m_isBorderEnabled =             true;
        private Boolean     m_isCustomNeedleEnabled =       false; /* Enabled needle from bitmap. */

        private Bitmap      m_needleBitMap;
        private Bitmap      ResizedNeedleBitMap;
        private float       ResizeScale = 70; /* Really should review this. */
        private PointF      NeedleCenterPoint = new PointF(20f, 40f);

        private Boolean     isGridEnabled = false;
        
        #region properties

        [Browsable(true),
        Category("Border"),
        Description("Is border enabled")]
        public Boolean BorderEnabled
        {
            get { return m_isBorderEnabled; }
            set
            {
                if (m_isBorderEnabled != value)
                {
                    m_isBorderEnabled = value;
                    drawGaugeBackground = true;
                }
                Refresh();
            }
        }

        [Browsable(true),
        Category("Border"),
        Description("Border color")]
        public Color BorderColor
        {
            get { return m_Border.BorderColor; }
            set
            {
                if (m_Border.BorderColor != value)
                {
                    m_Border.BorderColor = value;
                    drawGaugeBackground = true;
                }
                Refresh();
            }
        }

        [Browsable(true),
        Category("Border"),
        Description("Border width")]
        public float BorderWidth
        {
            get { return m_Border.BorderWidth; }
            set
            {
                if (m_Border.BorderWidth != value)
                {
                    m_Border.BorderWidth = value;
                    drawGaugeBackground = true;
                }
                Refresh();
            }
        }


        [Browsable(true),
        Category("NumberMarkers"),
        Description("Marker font")]
        public Font NumberMarkerFont
        {
            get { return m_NumberMarkerFont; }
            set
            {
                if (value != null)
                {
                    m_NumberMarkerFont = value;
                    drawGaugeBackground = true;
                    UpdateMarkers();
                    Refresh();
                }
            }
        }


        [Browsable(true),
        Category("NumberMarkers"),
        Description("Begin Angle")]
        public float NumberMarkerAngleBegin
        {
            get { return m_NumberMarkerAngleBegin; }
            set 
            { 
                m_NumberMarkerAngleBegin = value;
                drawGaugeBackground = true;
                UpdateMarkers();
                Refresh();
            }
        }

        [Browsable(true),
        Category("NumberMarkers"),
        Description("Number marker arc end angle")]
        public float NumberMarkerAngleEnd
        {
            get { return m_NumberMarkerAngleEnd; }
            set
            {
                m_NumberMarkerAngleEnd = value;
                drawGaugeBackground = true;
                UpdateMarkers();
                Refresh();
            }
        }

        [Browsable(true),
        Category("NumberMarkers"),
        Description("Angle Interval")]
        public float NumberMarkerAngleInterval
        {
            get { return m_NumberMarkerAngleInterval; }
            set
            {
                m_NumberMarkerAngleInterval = value;
                drawGaugeBackground = true;
                UpdateMarkers();
                Refresh();
            }
        }

        [Browsable(true),
        Category("NumberMarkers"),
        Description("First numerical value")]
        public Decimal NumberMarkerValueBegin
        {
            get { return m_NumberMarkerValueBegin; }
            set
            {
                m_NumberMarkerValueBegin = value;
                drawGaugeBackground = true;
                UpdateMarkers();
                Refresh();
            }
        }

        [Browsable(true),
        Category("NumberMarkers"),
        Description("Value interval ")]
        public Decimal NumberMarkerValueInterval
        {
            get { return m_NumberMarkerValueInterval; }
            set
            {
                m_NumberMarkerValueInterval = value;
                drawGaugeBackground = true;
                UpdateMarkers();
                Refresh();
            }
        }

        [Browsable(true),
        Category("NumberMarkers"),
        Description("Number marker width ")]
        public int NumberMarkerWidth
        {
            get { return m_NumberMarkerWidth; }
            set
            {
                m_NumberMarkerWidth = value;
                drawGaugeBackground = true;
                UpdateMarkers();
                Refresh();
            }
        }

        [Browsable(true),
        Category("NumberMarkers"),
        Description("Number marker height ")]
        public int NumberMarkerHeight
        {
            get { return m_NumberMarkerHeight; }
            set
            {
                m_NumberMarkerHeight = value;
                drawGaugeBackground = true;
                UpdateMarkers();
                Refresh();
            }
        }

        [Browsable(true),
        Category("NumberMarkers"),
        Description("Number marker offset ")]
        public int NumberMarkerOffset
        {
            get { return m_NumberMarkerOffset; }
            set
            {
                m_NumberMarkerOffset = value;
                drawGaugeBackground = true;
                UpdateMarkers();
                Refresh();
            }
        }

        [Browsable(true),
        Category("NumberMarkers"),
        Description("Number marker offset ")]
        public Color NumberMarkerColor
        {
            get { return m_NumberMarkerColor; }
            set
            {
                m_NumberMarkerColor = value;
                drawGaugeBackground = true;
                UpdateMarkers();
                Refresh();
            }
        }

        [Browsable(true),
        Category("Gauge"),
        Description("The value.")]
        public float Angle
        {
            get { return (int)m_angle; }
        }

        [Browsable(true),
        Category("Arc"),
        Description("Is arc visible")]
        public Boolean isArcEnabled
        {
            get { return m_isArcEnabled; }
            set
            {
                if (m_isArcEnabled != value)
                {
                    m_isArcEnabled = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [Browsable(true),
        Category("Arc"),
        Description("Arc width")]
        public Single ArcWidth
        {
            get { return m_arcWidth; }
            set
            {
                if (m_arcWidth != value)
                {
                    m_arcWidth = (int)value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [Browsable(true),
        Category("Arc"),
        Description("Arc start angle")]
        public float ArcStartAngle
        {
            get { return m_arcStartAngle; }
            set
            {
                if (m_arcStartAngle != value)
                {
                    m_arcStartAngle = (int)value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [Browsable(true),
        Category("Arc"),
        Description("Arc end angle")]
        public float ArcEndAngle
        {
            get { return m_arcEndAngle; }
            set
            {
                if (m_arcEndAngle != value)
                {
                    m_arcEndAngle = (int)value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [Browsable(true),
        Category("Arc"),
        Description("Arc Radius")]
        public float ArcRadius
        {
            get { return m_arcRadius; }
            set
            {
                if (m_arcRadius != value)
                {
                    m_arcRadius = value;
                    drawGaugeBackground = true;
                    mainNumberMarker.Radius = m_arcRadius + m_NumberMarkerOffset;
                    Refresh();
                }
            }
        }

        [Browsable(true),
        Category("Arc"),
        Description("Arc Color")]
        public Color ArcColor
        {
            get { return m_arcColor; }
            set
            {
                if (m_arcColor != value)
                {
                    m_arcColor = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [Browsable(true),
        Category("Needle"),
        Description("Enable custom needle")]
        public Boolean isCustomNeedleEnabled
        {
            get { return m_isCustomNeedleEnabled; }
            set 
            {
                m_isCustomNeedleEnabled = value;
                UpdateNeedleBitmap();
                Refresh();
            }
            
        }

        [Browsable(true),
        Category("Needle"),
        Description("Simple needle size")]
        public Size NeedleSize
        {
            get { return m_needleSize; }
            set 
            { 
                m_needleSize = value;
                UpdateNeedleBitmap();
            }
        }

        [Browsable(true),
        Category("Needle"),
        Description("Simple needle color")]
        public Color NeedleColor
        {
            get { return m_needleColor; }
            set 
            { 
                m_needleColor = value;
                UpdateNeedleBitmap();
            }
        }

        [Browsable(true),
        Category("Needle"),
        Description("Simple needle center radius")]
        public float NeedleCenterRadius
        {
            get { return m_needleCenterRadius; }
            set 
            { 
                m_needleCenterRadius = value;
                UpdateNeedleBitmap();
            }
        }

        [Browsable(true),
        Category("Needle"),
        Description("Simple needle center color")]
        public Color NeedleCenterColor
        {
            get { return m_needleCenterColor; }
            set 
            { 
                m_needleCenterColor = value;
                UpdateNeedleBitmap();
            }
        }

        [Browsable(true),
        Category("Gauge"),
        Description("Gauge background ellipse color")]
        public Color BackGroundEllipseColor
        {
            get { return m_backGroundEllipseColor; }
            set
            {
                if (m_backGroundEllipseColor != value)
                {
                    m_backGroundEllipseColor = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [Browsable(true),
        Category("Needle"),
        Description("Gauge needle image")]
        public Image NeedleImage
        {
            get { return m_needleBitMap; }
            set
            {
                m_needleBitMap = (Bitmap)value;
                UpdateNeedleBitmap();
            }
        }

        [Browsable(true),
        Category("Gauge"),
        Description("Gauge needle image")]
        public Decimal Value
        {
            get { return m_value; }
            set
            {
                Decimal begin = m_NumberMarkerValueBegin;

                /* We don't check for value constraints because gauge might have areas where there are no numbers. */
                /* TODO : Should still define purely logical max and min value.*/

                m_value = value;
                float angle_per_value = m_NumberMarkerAngleInterval / (float)m_NumberMarkerValueInterval;
                Decimal relative_value = m_value - begin;

                SetAngle((angle_per_value * (float)relative_value) + m_NumberMarkerAngleBegin);
            }
        }

#endregion

        public GaugeNeedle          mainNeedle;
        public GaugeNumberMarker    mainNumberMarker;

        public Gauge()
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            this.CenterPoint = new PointF(Width / 2, Height / 2);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;

            m_Border = new GaugeBorder();
            m_Border.BorderRadius = m_backGroundEllipseRadius;

            UpdateNeedleBitmap();
            UpdateMarkers();
        }

        public void AddMarker(GaugeMarker m)
        {
            this.m_markerList.Add(m);
            drawGaugeBackground = true;
            this.Refresh();
        }

        public void AddGaugeLabel(GaugeLabel t)
        {
            this.customTextList.Add(t);
            drawGaugeBackground = true;
            this.Refresh();
        }

        public void AddCustomNeedle(string name, GaugeNeedle needle)
        {
            customNeedleDictionary.Add(name, needle);
        }

        public void SetCustomNeedleAngle(string name, float angle)
        {
            if (customNeedleDictionary.ContainsKey(name))
            {
                customNeedleDictionary[name].Angle = angle;
                this.Invalidate();
            }
        }

        private void UpdateMarkers()
        {
            mainNumberMarker = new GaugeNumberMarker(this.ArcRadius);
            
            mainNumberMarker.BeginAngle =       m_NumberMarkerAngleBegin;
            mainNumberMarker.IntervalAngle =    m_NumberMarkerAngleInterval;
            mainNumberMarker.EndAngle =         m_NumberMarkerAngleEnd;

            mainNumberMarker.ValueBegin =       m_NumberMarkerValueBegin;    
            mainNumberMarker.ValueInterval =    m_NumberMarkerValueInterval;
            mainNumberMarker.ValueEnd =         m_NumberMarkerValueEnd;

            mainNumberMarker.Width =            m_NumberMarkerWidth;
            mainNumberMarker.Height =           m_NumberMarkerHeight; 
                   
            mainNumberMarker.Radius =           m_arcRadius + m_NumberMarkerOffset;
            mainNumberMarker.markerColor =      m_NumberMarkerColor;
            mainNumberMarker.Font =             m_NumberMarkerFont;

            Refresh();
        }

        private void UpdateNeedleBitmap()
        {
            if (!m_isCustomNeedleEnabled)
            {
                mainNeedle = new SimpleGaugeNeedle(m_needleColor, m_needleSize, m_needleCenterColor, m_needleCenterRadius);
            }
            else if (m_needleBitMap != null)
            {
                int ResizedWidth = (int)(m_needleBitMap.Width * (ResizeScale / 100));
                int ResizedHeight = (int)(m_needleBitMap.Height * (ResizeScale / 100));

                ResizedNeedleBitMap = new Bitmap((int)Width, (int)Height);

                Graphics graph = Graphics.FromImage(ResizedNeedleBitMap);

                graph.DrawImage(m_needleBitMap, new RectangleF((Width / 2) - NeedleCenterPoint.X, (Height / 2) - NeedleCenterPoint.Y, ResizedWidth, ResizedHeight));
                mainNeedle = new ImageGaugeNeedle(ResizedNeedleBitMap, CenterPoint);
            }
            else
            {
                //Init with default values.
                mainNeedle = new SimpleGaugeNeedle();
            }
            Refresh();
        }
        /*
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {

        }
        */
        protected override void OnResize(EventArgs e)
        {
            drawGaugeBackground = true;
            this.CenterPoint = new PointF(Width / 2, Height / 2);

            m_backGroundEllipseRadius = Math.Min(this.Size.Height, this.Size.Width) / 2;
            m_Border.BorderRadius = m_backGroundEllipseRadius;

            UpdateNeedleBitmap();
            UpdateMarkers();

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(ClientRectangle);

            Invalidate(Region);
            Region = new Region(path);

            Refresh();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            /* No point in drawing anything if size is so small */
            if ((Width < 10) || (Height < 10))
            {
                return;
            }

            if (drawGaugeBackground)
            {
                /* Draw background */
                gaugeBitmap = new Bitmap(Width, Height, pe.Graphics);
                Graphics ggr = Graphics.FromImage(gaugeBitmap);
                /* This line might cause background problems? */
                ggr.FillRectangle(new SolidBrush(BackColor), ClientRectangle);

                drawBackGround(ggr);
                drawGaugeBackground = false;
            }
            
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pe.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            pe.Graphics.DrawImageUnscaled(gaugeBitmap, 0, 0);

            //Draw custom needles
            foreach (KeyValuePair<string, GaugeNeedle> pair in customNeedleDictionary)
            {
                pair.Value.Draw(pe.Graphics, this.CenterPoint);
            }

            //Draw primary needle. Currently it is set on top.
            mainNeedle.Angle = m_angle;
            mainNeedle.Draw(pe.Graphics, this.CenterPoint);
        }

        private void drawBackGround(Graphics gfx)
        {
            gfx.SmoothingMode = SmoothingMode.HighQuality;
            gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gfx.FillRectangle(new SolidBrush(BackColor), ClientRectangle);

            Brush myBrush;
            Pen myPen;

            /* TODO : Arc and background Ellipse should be made into gaugeElements. */
            /* Draw outer border. */
            if (m_isBorderEnabled)
            {
                m_Border.Draw(gfx, this.CenterPoint);
            }

            /* If enabled, draw background ellipse. */
            if (m_isBackGroundEllipseEnabled)
            {
                float radius = m_backGroundEllipseRadius;

                if (m_isBorderEnabled)
                {
                    radius -= m_Border.BorderWidth;
                }
                if (radius > 0)
                {
                    RectangleF rect = new RectangleF(CenterPoint.X - radius, CenterPoint.Y - radius, 2 * radius, 2 * radius);
                    myBrush = new SolidBrush(m_backGroundEllipseColor);
                    gfx.FillEllipse(myBrush, rect);

                    if (isGridEnabled)
                    {
                        //Draw helper grid.
                        myPen = new Pen(Color.Red);
                        gfx.DrawLine(myPen, new Point((int)CenterPoint.X, 0), new Point((int)CenterPoint.X, Height));
                        gfx.DrawLine(myPen, new Point(0, (int)CenterPoint.Y), new Point(Width, (int)CenterPoint.Y));
                    }
                }
            }

            //Draw markers
            foreach (GaugeMarker m in m_markerList)
            {
                m.Draw(gfx, this.CenterPoint);
            }

            //Draw default number marker.
            mainNumberMarker.Draw(gfx, this.CenterPoint);

            /* Draw the arc */
            if (m_isArcEnabled)
            {
                if (m_arcRadius > 0)
                {
                    myPen = new Pen(m_arcColor, m_arcWidth);
                    gfx.DrawArc(myPen, new RectangleF(CenterPoint.X - m_arcRadius, CenterPoint.Y - m_arcRadius, 2 * m_arcRadius, 2 * m_arcRadius), m_arcStartAngle, (m_arcEndAngle - m_arcStartAngle));
                }
            }

            
            //Draw custom text fields.
            foreach(GaugeLabel label in customTextList)
            {
                label.Draw(gfx, this.CenterPoint);
            }
        }

        public void SetAngle(float angle)
        {
            this.m_angle = angle;
            this.Invalidate();
        }

        public float GetAngle()
        {
            return this.m_angle;
        }
    }
}

