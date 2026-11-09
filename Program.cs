using System;
using System.Collections.Generic;

class Student
{
    public string StudentId { get; set; }
    public string Department { get; set; }
    public int Level { get; set; }
    public double AttendancePercentage { get; set; }
    public double AverageExaminationScore { get; set; }

    public Student(string id, string department, int level,
                   double attendance, double score)
    {
        StudentId = id;
        Department = department;
        Level = level;
        AttendancePercentage = attendance;
        AverageExaminationScore = score;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("STU001", "Computer Science", 200, 92, 85),
            new Student("STU002", "Cyber Security", 200, 88, 79),
            new Student("STU003", "Software Engineering", 300, 95, 91),
            new Student("STU004", "Computer Science", 100, 80, 74),
            new Student("STU005", "Information Technology", 400, 90, 82),
            new Student("STU006", "Cyber Security", 300, 85, 77),
            new Student("STU007", "Software Engineering", 200, 97, 89),
            new Student("STU008", "Computer Science", 300, 78, 68),
            new Student("STU009", "Information Technology", 200, 86, 80),
            new Student("STU010", "Cyber Security", 100, 93, 88)
        };

        Console.WriteLine("STUDENT DATASET");
        Console.WriteLine("-----------------------------------------------");

        foreach (Student student in students)
        {
            Console.WriteLine(
                $"ID: {student.StudentId} | " +
                $"Department: {student.Department} | " +
                $"Level: {student.Level} | " +
                $"Attendance: {student.AttendancePercentage}% | " +
                $"Average Score: {student.AverageExaminationScore}");
        }

        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Total Students: " + students.Count);
    }
}
