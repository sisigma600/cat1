using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatoroverloadin1
{
    public class Fraction
    {
        private int numerator;
        private int denominator;
        //constructor of Fraction class
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        //preparing the Fraction class and it's objects for operator overloading
        //the + operator has two operands lhs and rhs 
        public static Fraction operator+(Fraction lhs, Fraction rhs)
        {
            if (lhs.denominator  == rhs.denominator)
            {
                return new Fraction(lhs.numerator + rhs.numerator, lhs.denominator);
            }
            int FirstProduct = lhs.numerator * rhs.denominator;
            int SecondProducrt = rhs.numerator * lhs.denominator;
            return new Fraction(FirstProduct + SecondProducrt, lhs.denominator * rhs.denominator);
        }
        public override string ToString()
        {
          //  return base.ToString();
            //override the virtual tostring() from the object class so that console.writeline can handle format like:4/5;
            String s = numerator.ToString() + "/" + denominator.ToString();
            return s;
        }
   }

   public  class Tester
    {
       public void Run() 
       {
           //calling the constructor to get the values
           Fraction firstFraction= new Fraction(4,5);
           //need to format the input values by overriding the ToString() to display the oputput in the console as a string NOT an int, otherwise we will problem showing 4/5 as input specially the "/"
           Console.WriteLine("The Value for firstFraction is {0}",firstFraction.ToString());
           Fraction secondFraction = new Fraction(1, 6);
           Console.WriteLine("The value for second option is {0}", secondFraction.ToString());
           //addition of two object is possible due to operator overloading in Fraction class
           Fraction sum=firstFraction +secondFraction;
           Console.WriteLine("The sum of Fraction is:{0}",sum.ToString());
         }

        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
