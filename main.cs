using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter salesperson name.");
    string salespersonname = Console.ReadLine();
    Console.WriteLine("Enter sales amount.");
    double salesamount = Convert.ToDouble(Console.ReadLine());
    double salescommission = 200 + (.09 * salesamount);
    Console.WriteLine("Sales commission for " + salespersonname + " is $" + salescommission + ".");
  if (salesamount >= 0 && salesamount <= 2999){
    Console.WriteLine("Performance is poor.");
  }
  else if (salesamount>=3000 && salesamount<=4999){
    Console.WriteLine("Performance is Average.");
  }
  else if (salesamount>=5000 && salesamount<=9999){
    Console.WriteLine("Performance is good.");
  }
  else if (salesamount>=10000 && salesamount<=14999){
    Console.WriteLine("Performance is Excellent.");
  }
  else if (salesamount>=15000){
    Console.WriteLine("Performance is outstanding");
  }
  }
}
// need to take screenshot and submit