using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }   

    public void Print()
    {
        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
    }
}
