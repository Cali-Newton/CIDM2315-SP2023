namespace HW5p3;
class Program
{
public static void Main(string[] args)
{
//call createAccount() method
createAccount();
Console.ReadKey(true);
}
public static bool checkAge(int birth_year)
{
//calculating age
int age=2022-birth_year;
//if age is greater than or equal to 18,then return true

if(age>=18)
return true;

else
return false;
}
public static void createAccount()
{
//declare String variables userName,password and retypedPassword
String userName,password,retypedPassword;
//declare integer birthYear
int birthyear;

Console.WriteLine("Enter Your Username:");

userName=Console.ReadLine();

Console.WriteLine("Enter Your Password:");

password=Console.ReadLine();

Console.WriteLine("Enter Your Password Again:");

retypedPassword=Console.ReadLine();

Console.WriteLine("Enter Your Birthyear:");

birthyear=Convert.ToInt16(Console.ReadLine());
//if checkAge() return true,then
if(checkAge(birthyear))
{
//if password and retypedPassword are equal,then displays
//"Account is created successfully"
if(password==retypedPassword)
Console.WriteLine("Account is created successfully");

else
Console.WriteLine("Wrong password");
}

else
Console.WriteLine("Could not create an account.");
}
}
