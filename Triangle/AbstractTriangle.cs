using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
	abstract public class AbstractTriangle
	{
		public double A { get; private set; }
		public double B { get; private set; }
		public double C { get; private set; }

		public double[ ] SidesLengths { get; private set; }

		public AbstractTriangle ( double a, double b, double c )
		{
			A = a;
			B = b;
			C = c;

			SidesLengths = new[ ] { A, B, C };
		}

		abstract public double Perimeter ( );
		abstract public double Area ( );
	}
}
