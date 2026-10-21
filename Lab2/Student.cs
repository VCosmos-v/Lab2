internal class Student
{
    private string name;
    private int[] grades;


    public Student(string name, int[] grades)
    {
        this.name = name;
        this.grades = grades;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int[] Grades
    {
        get { return grades; }
        set { grades = value; }
    }

    public override string ToString()
    {
        string s = $"{name}: [ {grades[0]}";
        for (int i = 1; i < grades.Length; i++)
        {
            s += $", {grades[i]}";
        }
        s += " ]";
        return s;
    }
}
