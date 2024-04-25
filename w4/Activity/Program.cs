namespace Week4_Activity
{
    class Program
    {
        struct Point{
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        static Point GetRandomPoint(int minX,int maxX,int minY,int maxY){
            Random rnd = new Random();
            int rndX = rnd.Next(minX, maxX);
            int rndY = rnd.Next(minY,maxY);
            Point point = new Point(rndX,rndY);
            return point;
        }

        static void Main(string[] args){
            Point rndPoint = GetRandomPoint(-100,100,-100,100);
            System.Console.WriteLine($"X:{rndPoint.X} Y:{rndPoint.Y}");
        }


    }
}