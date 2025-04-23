// enum
public enum PieceType
{
    EmptySpace,
    XPiece,
    OPiece
}

// game board for Tic Tac using a dictionary
public class GameBoard
{
    // initialize dictionary to store game pieces
    // key is pair (row, col) and value is the piece (XPiece, OPiece, EmptySpace)
    public Dictionary<(int, int), PieceType> Cells { get; private set }

    // initalize how many rows and columns the tic tac toe board has (3x3)
    public int Rows { get; }
    public int Cols { get; }

    // constructor: runs when we create new GameBoard
    // initalizes each cell to be empty at first and sets up 3x3 board
    public GameBoard(int rows=3, int cols = 3)
    {
        // stores the number of rows/cols
        Rows = rows;
        Cols = cols;
        Cells = new Dictionary<(int, int), PieceType>();
    }
}