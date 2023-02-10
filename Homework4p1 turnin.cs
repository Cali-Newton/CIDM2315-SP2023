namespace Homework4p1;
class Program
{
    // function named largest that takes 2 Integers a and b
// and return largest one

static int largest(int a, int b){

if(a>b){

return a;

}

else if(b>a){

return b;

}

else{

return -1;

}

}

static void Main() {

int a = 3, b=5;

// call the largest number

int lar = largest( a, b);
Console.WriteLine("\nLargest Number is : "+lar);
}
        }
    

