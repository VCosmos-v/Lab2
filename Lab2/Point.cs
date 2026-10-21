internal class Point
{
    private int x;
    private int y;

    // 4.1 было
    //public Point()
    //{
    //    x = 0;
    //    y = 0;
    //}

    //public Point(int x, int y)
    //{
    //    X = x;
    //    Y = y;
    //}

    //public Point(Point point)
    //{
    //    this.x = point.x;
    //    this.y = point.y;
    //}

    // стало
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public override string ToString()
    {
        string s = "{" + x + ";" + y + "}";
        return s;
    }
}
