public class Student
{
    public string Name { get; set; }
    public int[] Grades { get; set; }

    public Student(string name, int[] grades = null)
    {
        Name = name;
        Grades = grades ?? new int[0];
    }

    public override string ToString()
    {
        return $"{Name}: [{string.Join(", ", Grades)}]";
    }
}