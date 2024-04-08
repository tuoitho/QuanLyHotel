using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel
{
    public class RoundedButton : Button
    {
        private int borderRadius = 25; // Bán kính bo góc (có thể điều chỉnh)
        private int leftMargin = 5;   // Giá trị margin bên trái (có thể điều chỉnh)
        private int rightMargin = 5;  // Giá trị margin bên phải (có thể điều chỉnh)
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Tính toán kích thước vẽ button với margin
            Rectangle buttonRect = new Rectangle(
                this.ClientRectangle.X + leftMargin,
                this.ClientRectangle.Y,
                this.ClientRectangle.Width - leftMargin - rightMargin,
                this.ClientRectangle.Height);

            // Tạo đối tượng GraphicsPath
            GraphicsPath path = new GraphicsPath();
            path.AddArc(buttonRect.X, buttonRect.Y, borderRadius, borderRadius, 180, 90); // Góc trên bên trái
            path.AddArc(buttonRect.X + buttonRect.Width - borderRadius, buttonRect.Y, borderRadius, borderRadius, 270, 90); // Góc trên bên phải
            path.AddArc(buttonRect.X + buttonRect.Width - borderRadius, buttonRect.Y + buttonRect.Height - borderRadius, borderRadius, borderRadius, 0, 90); // Góc dưới bên phải
            path.AddArc(buttonRect.X, buttonRect.Y + buttonRect.Height - borderRadius, borderRadius, borderRadius, 90, 90); // Góc dưới bên trái
            path.CloseFigure();

            // Vẽ button với hình dạng tùy chỉnh
            pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.Region = new Region(path);
        }
    }
}
