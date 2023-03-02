
namespace Homework6;
class Program 
{
    static void Main() 
    {
        // Creating first professor in the Professor class.
        Professor pf1 = new Professor();
        pf1.profName = "Alice";
        pf1.classTeach = "Java";
        pf1.SetSalary(9000.0);
        
        // Creating the second professor in the Professor Class
        Professor pf2 = new Professor();
        pf2.profName = "Bob";
        pf2.classTeach = "Math";
        pf2.SetSalary(8000.0);
        
        // Creating the first student in the Student class.
        Student st1 = new Student();
        st1.studentName = "Lisa";
        st1.classEnroll = "Java";
        st1.SetGrade(90.0);
        
        // Creating the second student in the Student class
        Student st2 = new Student();
        st2.studentName = "Tom";
        st2.classEnroll = "Math";
        st2.SetGrade(80.0);
        
        // Printing out the profeesors and students with their grade and salary
        Console.WriteLine("Professor " + pf1.profName + " teaches " + pf1.classTeach + ", and the salary is: " + pf1.GetSalary());
        Console.WriteLine("Professor " + pf2.profName + " teaches " + pf2.classTeach + ", and the salary is: " + pf2.GetSalary());
        Console.WriteLine("Student " + st1.studentName + " enrolls " + st1.classEnroll + ", and the grade is: " + st1.GetGrade());
        Console.WriteLine("Student " + st2.studentName + " enrolls " + st2.classEnroll + ", and the grade is: " + st2.GetGrade());
        Console.WriteLine("The salary difference between " + pf1.profName + " and " + pf2.profName + " is: " + (pf1.GetSalary() - pf2.GetSalary()));
        Console.WriteLine("The total grade of " + st1.studentName + " and " + st2.studentName + " is: " + (st1.GetGrade() + st2.GetGrade()));
    }
}