using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace game1.func
{
    /// <summary>
    /// star基类
    /// </summary>
    class Star
    {
        //位置
        private int _x, _y;

        //速度
        private float _speed;

        //颜色
        private Color _color;

        //大小
        private int _width, _height;

        public Star(int x, int y, int width, int height, float speed, Color color)
        {
            _x = x;
            _y = y;
            _speed = speed;
            _color = color;
            _width = width;
            _height = height;
        }

        public Point GetPoint { get => new Point(_x, _y); }
        public Color GetColor { get => _color; }
        public Size GetSize { get => new Size(_width, _height); }
    }

    static class Rendorter
    {
        public static bool isRun;
        public static void Rendort(Graphics g, ArrayList stars)
        {
            if (!isRun)
                return;

            SolidBrush sb;
            Rectangle r;
            foreach (Star ss in stars)
            {
                sb = new SolidBrush(ss.GetColor);
                r = new Rectangle(ss.GetPoint, ss.GetSize);
                g.Clear(Color.White);
                g.FillEllipse(sb, r);
            }
        }
    }

}
