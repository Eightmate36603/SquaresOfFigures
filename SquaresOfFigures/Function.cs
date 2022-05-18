using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresOfFigures
{
	internal static class Function
	{
		public static double SquareTriangle(double a, double h)
		{
			return 0.5 * a * h;
		}

		public static double SquareTriangle(double a, double b, int alpha)
		{
			return 0.5 * a * b * Math.Sin(alpha);
		}

		public static double SquareTriangle(double a, double b, double c)
		{
			double p = (a + b + c) / 2;
			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}

		public static double SquareTrianglePR(double a, double b, double c, double R)
		{
			return (a * b * c) / (4 * R);
		}

		public static double SquareTrianglePR(double r)
		{
			return Math.PI * r;
		}



		public static int SquareBox(int a)
		{
			return a * a;
		}

		public static double SquareBox(double d)
		{
			return (d * d) / 2;
		}



		public static double SquareRectangle(double a, double b)
		{
			return a * b;
		}

		public static double SquareRectangle(double d, int alpha)
		{
			return 0.5 * d * d * Math.Sin(alpha);
		}



		public static double SquareParallelogram(double a, double h)
		{
			return a * h;
		}

		public static double SquareParallelogram(double a, double b, int alpha, bool diagdiagonal)
		{
			return diagdiagonal ? (0.5 * a * b * Math.Sin(alpha)) : (a * b * Math.Sin(alpha));
		}



		public static double SquareRhombus(double a, double b, bool diagdiagonal)
		{
			return diagdiagonal ? (a * b) : (0.5 * a * b);
		}

		public static double SquareRhombus(double a, int alpha)
		{
			return a * a * Math.Sin(alpha);
		}

		public static double SquareRhombus(double r)
		{
			return Math.PI * r;
		}


		
		public static double SquareTrapezoid(double a, double b, double h)
		{
			return (a + b) * 0.5 * h;
		}

		public static double SquareTrapezoid(double r)
		{
			return Math.PI * r;
		}
	}
}
