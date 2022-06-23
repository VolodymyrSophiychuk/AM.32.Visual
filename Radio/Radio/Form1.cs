namespace Radio
{
    public partial class Radio : Form
    {
        List<Point> stations = new List<Point>();
        List<Point> connections = new List<Point>();

        List<float> powers = new List<float>();
        List<float> distances = new List<float>();

        Point abonent = new Point();

        bool mode = false;
        public Radio()
        {
            InitializeComponent();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (!mode)
            {
                foreach (Point item in stations)
                    graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(item, new Size(10, 10)));
                graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(abonent, new Size(10, 10)));
            }
            else
            {
                foreach (Point item in stations)
                    graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(item, new Size(10, 10)));
                graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(abonent, new Size(10, 10)));

                int index = -1;
                foreach (Point item in stations)
                    graphics.DrawEllipse(new Pen(new SolidBrush(Color.Black)),
                        new Rectangle(new Point(item.X - ((int)distances[++index]), item.Y - ((int)distances[index])),
                        new Size((int)distances[index] * 2, (int)distances[index] * 2)));

                mode = false;
            }
        }

        private void Canvas_Click(object sender, EventArgs e)
        {
            stations.Add(Canvas.PointToClient(Cursor.Position));
            FillGrid();
            Canvas.Invalidate();
        }

        private void Canvas_MouseHover(object sender, EventArgs e)
        {
            abonent = Canvas.PointToClient(Cursor.Position);
            Canvas.Invalidate();
        }

        private void Func()
        {
            powers.Clear();
            distances.Clear();
            foreach (Point item in stations)
            {
                Point xy = new Point(item.X - abonent.X, item.Y - abonent.Y);
                powers.Add((float)(1F / Math.Sqrt(Math.Pow(xy.X, 2) + Math.Pow(xy.Y, 2))));
            }
            foreach (float item in powers)
            {
                distances.Add(1F / item);
            }

            mode = true;
            FindAllCircleConnections();
            Canvas.Invalidate();
        }
        private void FindAllCircleConnections()
        {
            float a = 0;
            float h = 0;
            float d = 0;
            Point b = new Point();
            connections = new List<Point>();

            for (int trigger = 1; trigger < stations.Count; trigger++)
            {
                d = (2 * distances[0]) + (2 * distances[trigger]) - ((2 * distances[0]) - (2 * distances[trigger]));
                a = (float)(((Math.Pow(distances[0], 2) - Math.Pow(distances[trigger], 2)) + Math.Pow(d, 2)) / (2 * d));
                h = (float)Math.Sqrt(Math.Pow(distances[0], 2) - Math.Pow(a, 2));
                b = new Point(
                    (int)(stations[0].X + ((a / (d)) * (stations[trigger].X - stations[0].X)) + ((h / (d)) * (stations[trigger].Y - stations[0].Y))),
                    (int)(stations[0].Y + ((a / (d)) * (stations[trigger].Y - stations[0].Y)) - ((h / (d)) * (stations[trigger].X - stations[0].X)))
                    );
                connections.Add(b);
                b = new Point(
                    (int)(stations[0].X + ((a / (d)) * (stations[trigger].X - stations[0].X)) - ((h / (d)) * (stations[trigger].Y - stations[0].Y))),
                    (int)(stations[0].Y + ((a / (d)) * (stations[trigger].Y - stations[0].Y)) + ((h / (d)) * (stations[trigger].X - stations[0].X)))
                    );
                connections.Add(b);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Func();
        }
    }
}