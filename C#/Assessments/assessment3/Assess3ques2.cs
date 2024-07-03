using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Box
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Box(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public static Box Add(Box box1, Box box2)
    {
        double lengthSum = box1.Length + box2.Length;
        double breadthSum = box1.Breadth + box2.Breadth;
        return new Box(lengthSum, breadthSum);
    }

    public void Display()
    {
        Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
    }
}

public class Test
{
    public static void Main()
    {
        Console.WriteLine(" Enter the length and breadth values for Box 1 ");
        Console.WriteLine("Length 1 value ");
        double length1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Breadth 1 value ");
        double breadth1 = Convert.ToDouble(Console.ReadLine());

        Box box1 = new Box(length1, breadth1);

        Console.WriteLine(" Enter the length and breadth values of Box 2 ");
        Console.WriteLine("Length 2 value ");
        double length2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Breadth 2 value ");
        double breadth2 = Convert.ToDouble(Console.ReadLine());

        Box box2 = new Box(length2, breadth2);

        Box box3 = Box.Add(box1, box2);

        Console.WriteLine(" Dimensions of Box 3 (Sum of Box 1 and Box 2) ");
        box3.Display();

        Console.ReadLine();
    }
}

