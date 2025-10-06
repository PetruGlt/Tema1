
//1.

public record Course(string Name, int Credits);
public record Student(int ID, string Name, int Age, Course[] Courses);

// 2
public class Instructor
{
    public string Name { get; init; }
    public string Department { get; init; }
    public string Email { get; init; }
}


public class Program
{
    // 4. Pattern Matching
    public static void WhatIsThis(object obj)
    {
        switch (obj)
        {
            case Student s when s is not null:
                Console.WriteLine($"Student: {s.Name}, Age: {s.Age}");
                break;
            case Course c when c is not null:
                Console.WriteLine($"Course: {c.Name}, Credits: {c.Credits}");
                break;
            default:
                Console.WriteLine("Unknown type");
                break;
        }
    }
    
   
    
    public static void Main(string[] args)
    {
        // 1
        Course[] courses = new Course[]
        {
            new Course("Mathematics", 5), new Course("Physics", 4)
        };
        Student student1 = new Student(1, "John Doe", 20, courses);
        Student student2 = student1 with
        {
            Courses = student1.Courses.Append(new Course("Chemistry", 3)).ToArray()
        };
        
        // 2
        Instructor instructor1 = new Instructor
        {
            Name = "Dr. Smith",
            Department = "Computer Science",
            Email = "smith@cs.com" 
        };
        Console.WriteLine(instructor1.Name + "\n" + instructor1.Department + "\n" + instructor1.Email);

        // 4
        WhatIsThis(student1);
        WhatIsThis(courses[0]);
        WhatIsThis("Hello");
        
        
    }

}
