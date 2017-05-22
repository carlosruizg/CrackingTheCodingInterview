//design a jigsaw puzzle. Design Data Structures and Algorithm to solve it. 
//Assume theres a method called FitsWith that takes two pieces and returns a boolean

public class JigsawSolver
{
	private Piece[][] _board;
	private Jigsaw = _js;
	
	public Piece[][] Solve(Jigsaw js)
	{
		_board = new Piece[js.Length][js.Height]();
		_js = js;

		PutUpperFrame();		
		for(var i = 1; i < js.Length - 1; i++)
		{
			// Put left frame piece
			var leftPiece = js.Pieces.Single(p => p.Shape.LeftShape == SideShape.Flat && js.FitsWith(p, _board[i-1][0]));
			_board[i][0] = leftPiece;
			for(var j = 1; j < js.Height -1;  j++)
			{
				// Piece that fits with left and upper piece
				var newPiece = js.Pieces.Single(p => js.FitsWith(p, _board[i][j-1]) &&  js.FitsWith(p, _board[i-1][j]));
				_board[i][j] = newPiece;
			}
		}
		return _board;
	}

	private void PutUpperFrame()
	{
		// put right corner piece
		var firstPiece = _js.Pieces.Single(p => p.Shape.LeftShape == SideShape.Flat && p.Shape.UpperShape == SideShape.Flat);
		_board[0][0] = firstPiece;
		var lastPieceSet = firstPiece;

		for(var j = 1; j < _js.Height - 1; j++)
		{
			var newPiece = _js.Pieces.Single(u => p.Shape.UpperShape == SideShape.Flat && _js.FitsWith(lastPieceSet, u));
			_board[0][j] = newPiece;
			lastPieceSet = newPiece;
		}
	}
}

public class Jigsaw
{
	public List<Piece> Pieces{get; private set;}
	public int Length {get; private set;}
	public int Height {get; private set;}
	public string Name { get; set; }
	public Jigsaw(List<Piece> p, int length, int height, string name){...}
	public bool FitsWith(Piece piece1, Piece piece2){...}
}

public class Piece
{
	public Shape Shape {get; private set;}
	private byte[] _image;

	public Piece(Shape, shape, byte[] image)
	{
		_shape = shape; _image = image;
	}
}

public class Shape
{
	public SideShape LeftShape {get; private set}
	public SideShape RightShape {get; private set}
	public SideShape UpperShape {get; private set}
	public SideShape LowerShape {get; private set}
	publpublicic Shape(SideShape left, SideShape right, SideShape upper, SideShape lower){
		_leftShape = left; _rightShape = right; _upperShape = upper; _lowerShape = lower;
	}
}

public enum SideShape
{
	Flat,
	UpperInward,
	LowerInward,
	UpperOutward,
	LowerOutward
}

