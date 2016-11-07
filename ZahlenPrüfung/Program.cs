using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahlenPrüfung
{
  class Program
  {

    static void Main(string[] args)
    {
      Console.Title = "Zahlen sortieren";

      double z1, z2, z3;
      double größte =0, mittel=0, kleinste=0;

      Console.WriteLine("Bitte geben sie den Wert 1 ein");
      z1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Bitte geben sie den Wert 2 ein");
      z2 = double.Parse(Console.ReadLine());

      Console.WriteLine("Bitte geben sie den Wert 3 ein");
      z3 = double.Parse(Console.ReadLine());

      if ( z1 > z2 && z1 > z3)
      {
        größte = z1;
        if (z2 > z3)
        {
          mittel = z2;
          kleinste = z3;
        }
        else if ( z3 > z2)
        {
          mittel = z3;
          kleinste = z2;
        }
      }
      else if (z2 > z1 && z2 > z3)
      {
        größte = z2;
        if (z1 > z3)
        {
          mittel = z1;
          kleinste = z3;
        }
        else if (z3 > z1)
        {
          mittel = z3;
          kleinste = z1;
        }
      }
      else if ( z3 > z1 && z3 > z2)
      {
        größte = z3;
        if (z1 > z2)
        {
          mittel = z1;
          kleinste = z2;
        }
        else if (z2 > z1)
        {
          mittel = z2;
          kleinste = z1;
        }
      }
      
      Console.WriteLine(größte + " > " + mittel + " > " + kleinste);
      Console.WriteLine(kleinste + " < " + mittel + " < " + größte);
      Console.ReadLine();
    }
  }
}
