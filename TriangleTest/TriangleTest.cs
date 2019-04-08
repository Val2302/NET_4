using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleTest
{
	[TestClass]
	public class TriangleTest
	{
		[TestMethod]
		public void CalculatePerimeter_Test ( )
		{
			var a = 5;
			var b = 3;
			var c = 4;
			var perimeter = a + b + c;
			var triangle = new Triangle.Triangle( a, b, c );
			Assert.AreEqual( triangle.Perimeter( ), perimeter );
		}

		[TestMethod]
		public void CalculateArea_Test ( )
		{
			var a = 5;
			var b = 3;
			var c = Math.Sqrt( a * a + b * b );
			var area = a * b / 2.0;
			var triangle = new Triangle.Triangle( a, b, c );
			Assert.AreEqual( triangle.Area( ), area );
		}
	}
}
