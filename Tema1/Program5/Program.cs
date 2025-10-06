public record Course(string Name, int Credits);

public class Program
{
    public static void Main(string[] args)
    {
        List<Course> courses = new List<Course>
        {
            new Course("Mathematics", 5),
            new Course("Physics", 4),
            new Course("Chemistry", 3),
            new Course("English", 1),
            new Course("History", 2)
        };

        Console.WriteLine("Courses with more than 3 credits:");
        var filteredCourses = courses.Where(c => c.Credits> 3);
        foreach (var course in filteredCourses)
        {
            Console.WriteLine($"{course.Name} - {course.Credits} credits");
        }
    }
}