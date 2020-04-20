﻿using System.Drawing;

namespace Tanks
{
    class Tank : Unit, IDrawn
    {
        private readonly Bitmap bitmap = new Bitmap(Properties.Resources.unnamed);
        private readonly Rectangle body = new Rectangle(new Point(0, 0), new Size(128, 128));
        private readonly Rectangle tower = new Rectangle(new Point(128, 0), new Size(128, 128));
        private float vectorTower; //Угол поворота башни

        //Отрисовка танка
        public void DrawUnit(Graphics g, Point cursor)
        {
            target = cursor;
            Position();
            Vector();
            vectorTower += 1;

            #region Отрисовка по частям
            //Корпус
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform(vector);
            g.DrawImage(bitmap, -62, -59, body, GraphicsUnit.Pixel);
            g.ResetTransform();

            //Башня
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform(vectorTower);
            g.DrawImage(bitmap, -64, -58, tower, GraphicsUnit.Pixel);
            g.ResetTransform();

            DrawInfo(g);
            #endregion
        }
    }
}
