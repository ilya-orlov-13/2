public class Student
{
    private string name;
    private int[] grades;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int[] Grades
    {
        get { return grades; }
        set { grades = value ?? new int[0]; }
    }

    public Student(string name, int[] grades = null)
    {
        Name = name;
        Grades = grades;
    }

    public double AverageGrade
    {
        get
        {
            if (grades.Length == 0) return 0;

            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            return sum / grades.Length;
        }
    }

    public bool IsExcellent
    {
        get
        {
            if (grades.Length == 0) return false;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] != 5)
                    return false;
            }
            return true;
        }
    }

    public override string ToString()
    {
        return $"{Name}: [{string.Join(", ", Grades)}], Средний балл: {AverageGrade:F2}, Отличник: {IsExcellent}";
    }
}