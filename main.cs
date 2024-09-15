using System;

class InchesToCentimeters
{
  static void Main (string[] args)
  {

    const double CENTIMETERS_PER_INCH = 2.54;
    double inches = 3;
    Console.Write("Enter the number of inches: ");
    inches = Convert.ToDouble(Console.ReadLine());
    double centimeters = inches * CENTIMETERS_PER_INCH;
    Console.WriteLine("{0} inches is {1} centimeters", inches, centimeters);
  }
}
