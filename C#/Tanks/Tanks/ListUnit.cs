﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class ListUnit
    {
        public byte count = 10;

        private List<object> listUnits = new List<object>();
        private Random random = new Random();

        //Создание списка танков
        public List<object> CreateListUnit()
        {
            for (byte i = 1; i <= count; i++)
            {
                listUnits.Add(new Tank
                {
                    id = i,
                    position = StartPosition(),
                    speed = 1
                });

                listUnits.Add(new Car
                {
                    id = i,
                    position = StartPosition(),
                    speed = 3
                });
            }
            return listUnits;
        }

        //Отрисовка списка танков
        public void DrawListUnit(Graphics g, Point cursor)
        {
            foreach (dynamic unit in listUnits)
            {
                unit.DrawUnit(g, cursor);
            }
        }

        //Стартовая позиция
        public Point StartPosition()
        {
            Point position = new Point();
            position.X = random.Next(1280);
            position.Y = random.Next(720);
            return position;
        }
    }
}