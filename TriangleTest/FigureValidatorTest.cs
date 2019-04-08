using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace TriangleTest
{
	/// <summary>
	/// Summary description for FigureValidatorTest
	/// </summary>
	[TestClass]
	public class FigureValidatorTest
	{
		[TestMethod]
		public void FigureTriangleIsValidationTest_True ( )
		{
			var a = 5;
			var b = 3;
			var c = 4;
			var triangle = new Triangle.Triangle( a, b, c );
			Assert.IsTrue( FigureValidator.IsTriangle( triangle ) );
		}

		[TestMethod]
		public void FigureTriangleIsValidationTest_False ( )
		{
			var a = 5;
			var b = 3;
			var c = 1;
			var triangle = new Triangle.Triangle( a, b, c );
			Assert.IsFalse( FigureValidator.IsTriangle( triangle ) );
		}
	}
}
