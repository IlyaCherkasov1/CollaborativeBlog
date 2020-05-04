using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UP11
{
    class Ball
    {
        int x, y;   // координаты
        int dx, dy; //приращение координат-определяет скорость
        int w, h;   //ширина высота шарика
        bool live;   // признак жизни 
        string text;

        public string Text { get => text; set => text = value; }
        public int Dx { get => dx; set => dx = value; }
        public int Dy { get => dy; set => dy = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public bool Live { get => live; set => live = value; }
        public Action dl { get; set; }
        public Thread thr;  //Создание ссылки на потоковый объект
        private static object locker = new object();

        //функция рисования шарика
        public void DrawBall(Graphics dc)
        {
            Random rd = new Random();
            Pen p = new Pen(Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256)));
            dc.DrawEllipse(p, x, y, w, h);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            dc.DrawString(Text, new Font("Times New Roman", 5), blueBrush, x + 3, y + 3);
            dc.DrawRectangle(Pens.Red, 40, 40, 50, 50);
        }

        //конструктор класса
        public Ball(int xn, int yn, int wn, int hn, int dxn, int dyn, string text)
        {
            x = xn; y = yn; w = wn; h = hn; Dx = dxn; Dy = dyn;//инициализируем
            live = true;    //устанавливаем признак жизни
            this.Text = text;
            thr = new Thread(new ThreadStart(FnThr)); //создаем потоковый объект
            thr.Start();    //запускаем поток   
        }

        // потоковая функция
        public void FnThr()
        {

            while (live)
            {
                if ((x >= 40 && x <= 90) && (y >= 40 && y <= 90))
                {
                    lock (locker)
                    {
                        while((x >= 40 && x <= 90) && (y >= 40 && y <= 90))
                        { 
                         x += Dx;
                         y += Dy;
                         Thread.Sleep(100);
                         dl();
                        }
                    }
                }
                else
                {
                    x += Dx;
                    y += Dy;
                }

                //здесь отражемся от границ области
                if (x < 0 || x > 200) Dx = -Dx;
                if (y < 0 || y > 200) Dy = -Dy;
                //здесь пересчитываем координаты
                
                Thread.Sleep(100);//спим
                dl();   //вызываем с помощью делегата Invalidate()
            }
            w = h = 0;  //схлопываем шарик
            dl();      //вызываем с помощью делегата Invalidate()
        }
    }
}


