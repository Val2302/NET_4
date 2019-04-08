
using System;
using System.Linq;

namespace Triangle
{
	public class Triangle : AbstractTriangle
	{
		public Triangle ( double a, double b, double c ) : base ( a, b, c )
		{ }

		public override double Perimeter ( )
		{
			return SidesLengths.Sum();
		}

		public override double Area ( )
		{
			var semiperimeter = Perimeter( ) / 2.0;
			var multiplication = SidesLengths.Aggregate(
				semiperimeter,
				( accumulate, currect ) => accumulate *= semiperimeter - currect
			);

			return Math.Sqrt( multiplication );
		}
	}
}
