﻿using System;
using System.Drawing;
using System.Threading.Tasks;

namespace Tanks
{
    class Game
    {
        private ListUnit RedParty, BlueParty;
        private ListShot listShot;
        Shot shot = new Shot();

        //Старт игры
        public void StartGame()
        {
            RedParty = new ListUnit();
            RedParty.CreateListUnit();

            BlueParty = new ListUnit();
            BlueParty.CreateListUnit();

            //SW();
            Sound();

            shot.position = new PointF(50, 50);
            shot.target = new PointF(1000, 600);
            shot.speed = 20;
        }

        //Шаг игры
        public void StepGame(Graphics g, Point cursor)
        {
            RedParty.DrawListUnit(g, cursor);
            BlueParty.DrawListUnit(g, cursor);

            shot.DrawShot(g);
        }

        #region//Звук заставки
        private void SW()
        //261 - до 1
        //293 - ре 2
        //329 - ми 3
        //349 - фа 4
        //392 - соль 5
        //440 - ля 6
        //493 - си 7
        {
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 350);
            Console.Beep(523, 150);
            Console.Beep(415, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
        }

        //Звук заставки
        async private void Sound()
        {
            await Task.Run(() =>
            {
                Console.Beep(349, 250);
                Console.Beep(330, 250);
                Console.Beep(293, 250);
                Console.Beep(261, 250);
                Console.Beep(392, 500);
                Console.Beep(392, 350);
                Console.Beep(349, 250);
                Console.Beep(329, 250);
                Console.Beep(293, 250);
                Console.Beep(261, 250);
                Console.Beep(392, 500);
                Console.Beep(392, 350);

                Console.Beep(349, 250);
                Console.Beep(440, 250);
                Console.Beep(440, 250);
                Console.Beep(349, 250);
                Console.Beep(329, 250);
                Console.Beep(392, 250);
                Console.Beep(392, 250);
                Console.Beep(329, 250);
                Console.Beep(293, 250);
                Console.Beep(329, 250);
                Console.Beep(349, 250);
                Console.Beep(293, 250);
                Console.Beep(261, 500);
                Console.Beep(261, 500);

                Console.Beep(349, 250);
                Console.Beep(440, 250);
                Console.Beep(440, 250);
                Console.Beep(349, 250);
                Console.Beep(329, 250);
                Console.Beep(392, 250);
                Console.Beep(392, 250);
                Console.Beep(329, 250);
                Console.Beep(293, 250);
                Console.Beep(329, 250);
                Console.Beep(349, 250);
                Console.Beep(293, 250);
                Console.Beep(261, 500);
                Console.Beep(261, 500);
            });
        }
        #endregion
    }
}