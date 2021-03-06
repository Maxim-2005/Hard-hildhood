﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Tanks
{
    public partial class FormTanks : Form
    {
        private Game game;
        public static Size window;
        public Graphics g;
        private Point cursor;

        //Окно приложения
        public FormTanks()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);

            UpdateStyles();
        }

        //Загрузка окна
        private void FormTanks_Load(object sender, EventArgs e)
        {
            window = ClientSize;
            game = new Game();
            game.StartGame();
        }
        
        //Обновление окна
        private void FormTanks_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            cursor = PointToClient(Cursor.Position);
            game.StepGame(g);
        }

        //Таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        //Старт || Стоп
        private void FormTanks_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        //Это событие при двойном нажатии на окно
        private void FormTanks_DoubleClick(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.Sizable)
                FormBorderStyle = FormBorderStyle.None;
            else FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void RESTART_Click(object sender, EventArgs e)
        {
            window = ClientSize;
            game = new Game();
            game.StartGame();

            Refresh();
        }
    }
}