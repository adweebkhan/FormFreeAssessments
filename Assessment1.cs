using System;
					
public class Program
{
	public static void Main()
	{
            // declared variables for the 3 sides as strings
            string triString1, triString2,triString3;
            // declared variables for the 3 sides as ints
            int triSide1, triSide2, triSide3;
            //take in side input as string
            Console.WriteLine("Input length of first side: ");
            triString1 = Console.ReadLine();
            //convert side to int value
            triSide1 = Convert.ToInt32(triString1);
            System.Console.WriteLine("Input length of second side: ");
            triString2 = Console.ReadLine();
            triSide2 = Convert.ToInt32(triString2);
            System.Console.WriteLine("Input length of third side: ");
            triString3 = Console.ReadLine();
            triSide3 = Convert.ToInt32(triString3);

            Console.WriteLine("Input = {0}, {1}, {2} ", triSide1, triSide2, triSide3);

            if(triSide1 == triSide2 && triSide2 == triSide3)
            {
                Console.WriteLine("The triangle is equilateral.");
            }//triangle is equilateral

            else if(triSide1==triSide2 || triSide1==triSide2 || triSide2==triSide3)
            {
                Console.WriteLine("The triangle is isosceles.");
            }//triangle is isosceles
            else if(((triSide1+triSide2)<triSide3) || ((triSide1+triSide3)<triSide2) || ((triSide2+triSide3)<triSide1))
            {
                Console.WriteLine("Invalid side lengths to make a triangle.");
            }//triangular inequality theorem to check if the sides make a valid triangle
            else
            {  
                Console.Write("The triangle is scalene.");  
            }//triangle is scalene

            //test for invalid triangle dimensions!!

    }
}