using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraycomparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, we're going to create an array of your chosen size and values, and pull the biggest number out! ");
            Console.WriteLine("Limit the size of your array to however many numbers you want to put.");
            Console.WriteLine("How many numbers do you want the array to be?");
            int size = Convert.ToInt32(Console.ReadLine()); //convert their input into the array size
            int[] myArray = new int[size]; //initialize an array with the length that the user chose 
            for (int i = 0; i <= myArray.Length -1; i++) //ask for a value for each spot in the array and assign it
            {
                Console.WriteLine("Put a number in for your array!");
                int add = Convert.ToInt32(Console.ReadLine());
                myArray[i] = add; 
            }
            Console.WriteLine("Your array is: "); //display array
            foreach(int i in myArray)
            {
                Console.Write(Convert.ToString(i) + " ");
            }
            Console.Write("\nThe biggest number in your array is: ");
            numberchecker(myArray);

        }
        static void numberchecker(int[] array) //checks the first value of the array, compares to current spots value, if current spot is bigger it assigns that integer to biggest then repeats whole array
        {
            int biggest = array[0];
            for (int i = 0; i < array.Length -1; i++)
            {
                if (array[i] > biggest)
                {
                    biggest = array[i];
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
