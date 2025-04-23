using Avalonia.Controls;
using System.Collections.Generic;

namespace TicTacToeAvalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Board()
        {
            //fields
            //Tuple + Dictionary option:
            //private List<(int, int)> _boardGrid = new List<(int, int)>
            //    { 
            //    (0, 0), 
            //    (0, 1), 
            //    (0, 2), 
            //    (1, 0), 
            //    (1, 1), 
            //    (1, 2), 
            //    (2, 0), 
            //    (2, 1), 
            //    (2, 2) 
            //    };


            //Grid option
            public int[][] boardGrid { get; private set; } = new int[9][]
           {
            [0, 0],
            [0, 1],
            [0, 2],
            [1, 0],
            [1, 1],
            [1, 2],
            [2, 0],
            [2, 1],
            [2, 2],
           };

            //properties
            //Tuple + dictionary option
            public Dictionary<(int, int), PieceType> TicTacToeBoard { get; set; } = new(); // creates getter/setter while initializing

            //Grid option dictionary
            public Dictionary<int[], PieceType> boardStates = new Dictionary<int[], PieceType>();
            //Methods

            //Constructor
            public Board()
            {
                //Tuple + Dictionary Option
                //foreach((int, int) cell in _boardGrid)  //initializes each cell to EmptySpace
                //{
                //    TicTacToeBoard.Add(cell, PieceType.EmptySpace);
                //}

                //Grid option
                for (int i = 0; i < 9; i++)
                {
                    boardStates[boardGrid[i]] = PieceType.EmptySpace;
                }

            }
        }

        public enum PieceType
        {
            XPiece,
            OPiece,
            EmptySpace
        }
    }
}