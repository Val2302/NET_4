using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
	static public class FigureValidator
	{
		static public bool IsTriangle ( AbstractTriangle triangle )
		{
			var expression1 = triangle.A + triangle.B > triangle.C;
			var expression2 = triangle.B + triangle.C > triangle.A;
			var expression3 = triangle.C + triangle.A > triangle.B;
			return expression1 && expression2 && expression3;
		}
	}
}
