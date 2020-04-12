using System;
namespace PersonalProjectLab
{

	public class Class
	{

		private double num1;
		private double num2;
		private string op;

		// constructor 
		public Class()
		{

		}

		public double addition(double a, double b)
		{
			double result = a + b;
			return result;
		}

		public double multiplication(double a, double b)
		{
			double result = a * b;
			return result;
		}

		public double division(double a, double b)
		{
			double result = a / b;
			return result;
		}

		public void compute(double a, double b, string c)
		{
			double result;
			if (c.Equals("+"))
			{
				result = addition(a, b);
				Console.WriteLine("resul of your operation is " + result);
			}
			else if (c.Equals("*"))
			{
				result = multiplication(a, b);
				Console.WriteLine("result of your multiplication is " + result);
			}
			else if (c.Equals("/"))
			{
				result = division(a, b);
				Console.WriteLine("result of your operation is " + result);
			}
			else
			{
				Console.WriteLine("error: wrong input ");
			}
		}

	}

}
