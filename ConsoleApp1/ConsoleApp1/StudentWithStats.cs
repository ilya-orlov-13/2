using System.Linq;

public class StudentWithStats : Student
{
    public StudentWithStats(string name, int[] grades = null) : base(name, grades) { }

    public double AverageGrade
    {
        get
        {
            if (Grades.Length == 0) return 0;
            return Grades.Average();
        }
    }

    public bool IsExcellent
    {
        get
        {
            return Grades.Length > 0 && Grades.All(grade => grade == 5);
        }
    }

    public override string ToString()
    {
        return $"{Name}: [{string.Join(", ", Grades)}], Средний балл: {AverageGrade:F2}, Отличник: {IsExcellent}";
    }
}