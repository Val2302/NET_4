
using static System.Console;

namespace Triangle
{
	public class Menu
	{
		public void Show ( )
		{
			WriteLine( "Program triangle:" );
			var a = ReadSideLength( "A" );
			var b = ReadSideLength( "B" );
			var c = ReadSideLength( "C" );

			var triangle = new Triangle( a, b, c );

			if ( FigureValidator.IsTriangle( triangle ) )
			{
				WriteLine( "It figure is triangle" );
				WriteLine( $"Perimetr = {triangle.Perimeter( )}" );
				WriteLine( $"Area = {triangle.Area( )}" );
			}
			else
			{
				WriteLine( "It is not triangle" );
			}

			ReadKey( );
		}

		private double ReadSideLength ( string side )
		{
			Write( $"Length triangle side {side} = " );
			var isParsed = double.TryParse( ReadLine( ), out var value );
			return isParsed && value >= 0 ? value : ReadSideLength( side );
		}
	}
}
