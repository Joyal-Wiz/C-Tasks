using System;
using System.Collections.Generic;
using System.Linq;

class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }

    public Course(int courseId, string courseName)
    {
        CourseId = courseId;
        CourseName = courseName;
    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Course Course { get; set; }

    public Student(int id, string name, int age, Course course)
    {
        Id = id;
        Name = name;
        Age = age;
        Course = course;
    }
}

class CourseManager
{
    private List<Course> courses = new List<Course>();

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public List<Course> GetAllCourses()
    {
        return courses;
    }
}

class StudentManager
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void ViewStudents()
    {
        foreach (var s in students)
        {
            Console.WriteLine($"{s.Id} | {s.Name} | {s.Age} | {s.Course.CourseName}");
        }
    }

    public void UpdateStudent(int id, string name, int age)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            student.Name = name;
            student.Age = age;
        }
    }

    public void DeleteStudent(int id)
    {
        students.RemoveAll(s => s.Id == id);
    }

    public List<Student> GetStudentsAboveAge(int age)
    {
        return students.Where(s => s.Age > age).ToList();
    }

    public List<Student> GetStudentsByCourse(string courseName)
    {
        return students.Where(s => s.Course.CourseName == courseName).ToList();
    }
}

class Program
{
    static void Main()
    {
        CourseManager courseManager = new CourseManager();
        StudentManager studentManager = new StudentManager();

        Course c1 = new Course(1, "Computer Science");
        Course c2 = new Course(2, "Data Science");

        courseManager.AddCourse(c1);
        courseManager.AddCourse(c2);

        studentManager.AddStudent(new Student(1, "Joyal", 21, c1));
        studentManager.AddStudent(new Student(2, "Alan", 24, c2));
        studentManager.AddStudent(new Student(3, "ann", 21, c1));

        studentManager.ViewStudents();

        Console.WriteLine();

        foreach (var s in studentManager.GetStudentsAboveAge(22))
        {
            Console.WriteLine(s.Name);
        }

        Console.WriteLine();

        foreach (var s in studentManager.GetStudentsByCourse("Computer Science"))
        {
            Console.WriteLine(s.Name);
        }

        studentManager.UpdateStudent(3, "ann rose", 21);
        studentManager.DeleteStudent(2);

        Console.WriteLine();
        studentManager.ViewStudents();
    }
}
