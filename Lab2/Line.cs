internal class Line
{
    private Point start;
    private Point end;

    // 4.2 было
    //public Line()
    //{
    //    start = new Point(0, 0);
    //    end = new Point(0, 0);
    //}

    //public Line(Point x, Point y)
    //{
    //    start = x;
    //    end = y;
    //}

    //public Line(Line line1, Line line2)
    //{
    //    this.start = line1.start;
    //    this.end = line2.end;
    //}

    //public Line(Line line)
    //{
    //    this.start = line.start;
    //    this.end = line.end;
    //}

    // стало
    public Line()
    {
        start = new Point(0, 0);
        end = new Point(0, 0);
    }

    public Line(Point x, Point y)
    {
        start = x;
        end = y;
    }

    public Line(int x1, int y1, int x2, int y2)
    {
        start = new Point(x1, y1);
        end = new Point(x2, y2);
    }

    public Line(Line line1, Line line2)
    {
        this.start = line1.start;
        this.end = line2.end;
    }

    public Line(Line line)
    {
        this.start = line.start;
        this.end = line.end;
    }

    public Point Start
    {
        get { return start; }
    }

    public Point End
    {
        get { return end; }
    }

    public void ChangeStart(Point x)
    {
        this.start = x;
    }

    public void ChangeEnd(Point y)
    {
        this.end = y;
    }

    public int Distance()
    {
        return (int)Math.Round(
            Math.Sqrt(
                Math.Pow((start.X - end.X), 2) 
                + Math.Pow((start.Y - end.Y), 2)));
    }

    public override string ToString()
    {
        string s = $"Линия от {start} до {end}";
        return s;
    }
}
