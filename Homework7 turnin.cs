namespace Homework7;
class Customer{  
// Method used to create customer's information
 private int cus_id; 
 public string cus_name;
 public int cus_age;
// Method used to used to assign id, name and age to the customer when an object is created.
 public Customer(int id, string name, int age) {
// Customer id 
  cus_id = id;
// Customer name 
  cus_name = name;
// Customer age 
  cus_age = age;
  this.cus_age = age;
  this.cus_name = name;
}
 public void CompareAge(Customer objCustomer) 
 // Method used to compare the current object’s age with the objCustomer’s age. Then print out the cus_name of the older customer.
{
    if(this.cus_age >= objCustomer.cus_age)
{
  Console.WriteLine($"{this.cus_name} is older");
}
    else
{
  Console.WriteLine($"{objCustomer.cus_name} is older");
}
}
 // Method used to change customer id
 public void ChangeID(int new_id) {
     cus_id = new_id;
}
  // Method used to print customer information
 public void PrintCusInfo(){
  // Printing the values of corresponding customer 
     Console.WriteLine("Customer: "+cus_id+", name: "+cus_name+", age: "+cus_age);
}
}
class Program {
// Runs the program
  static void Main() {
    // Intializing the object of customer1
    Customer cust1 = new Customer(110,"Alice", 28);
    // Printing the values of customer1 
    cust1.PrintCusInfo();
    // Intializing the object of customer2 
    Customer cust2 = new Customer(111,"Bob", 30);
    // Printing the values of customer2
    cust2.PrintCusInfo();
    // Setting the new id for "Alice" 
    cust1.ChangeID(220);
    // Setting the new id for "Bob"
    cust2.ChangeID(221);
    // Printing the values of the customers with changed ids
    cust1.PrintCusInfo();
    cust2.PrintCusInfo();
    cust2.CompareAge(cust1); 
  }
}