using System;
using System.Windows.Forms;
using System.Drawing;


namespace AsteroidGame
{


    static class Game
    {
        static Bitmap image;
        static Ship ship;

        // Графическое устройство для вывода графики            
        static Graphics g;

        static BaseObject[] objs;

        static BufferedGraphicsContext context;
        static public BufferedGraphics buffer;

        // Свойства
        // Ширина и высота игрового поля
        static public int Width { get; set; }
        static public int Height { get; set; }

        static Game()
        {
        }

        static public void Init(Form form)
        {

            // предоставляет доступ к главному буферу графического контекста для текущего приложения
            context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();// Создаём объект - поверхность рисования и связываем его с формой
            // Запоминаем размеры формы
            Width = form.Width;
            Height = form.Height;
            // Связываем буфер в памяти с графическим объектом.
            // для того, чтобы рисовать в буфере

            buffer = context.Allocate(g, new Rectangle(0, 0, Width, Height));

            image = new Bitmap(@"background.bmp", true);


            form.KeyDown += Form_KeyDown;




            Load();

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Start();
            timer.Tick += Timer_Tick;

        }

        static private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            // if (e.KeyCode == Keys.ControlKey) bullet = new Bullet(new Point(ship.Rect.X + 10, ship.Rect.Y + 4), new Point(4, 0), new Size(4, 1));
            if (e.KeyCode == Keys.Up) ship.Up();
            if (e.KeyCode == Keys.Down) ship.Down();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
            Update();
        }
