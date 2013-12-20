using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameFifteen;
using System.Text;

namespace GameFifteen.Test
{
    [TestClass]
    public class PlayBoardTest
    {
        [TestMethod]
        public void TestCorrectTraverselWithCorectBoardRow()
        {
            // Arange
            PlayBoard testBoard = new PlayBoard();
            // Act
            int result = testBoard.BoardTraversRow(14);
            //Assert
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void TestCorrectTraverselWithIncorectBoardRow()
        {
            // Arange
            PlayBoard testBoard = new PlayBoard();
            // Act
            int result = testBoard.BoardTraversRow(25);
            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestCorrectTraverselWithCorrectBoardCol()
        {
            // Arange
            PlayBoard testBoard = new PlayBoard();
            // Act
            int result = testBoard.BoardTraversCol(14);
            //Assert
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void TestCorrectTraverselWithIncorectBoardCol()
        {
            // Arange
            PlayBoard testBoard = new PlayBoard();
            // Act
            int result = testBoard.BoardTraversCol(25);
            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void IsValidWithValideMovePositionRow()
        {
            PlayBoard testBoard = new PlayBoard();

            int rowPosition = 0;
            int colPosition = 0;

            // Get start position in the matrix;
            for (int i = 0; i < testBoard.GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < testBoard.GameBoard.GetLength(1); j++)
                {
                    if (testBoard.GameBoard[i, j] == 0)
                    {
                        rowPosition = i;
                        colPosition = j;
                    }
                }
            }

            bool moveResultRight = testBoard.IsValidMove((rowPosition + 1), colPosition);
            bool moveResultLeft = testBoard.IsValidMove((rowPosition - 1), colPosition);
            bool moveResult = (moveResultRight || moveResultLeft);

            Assert.IsTrue(moveResult);
        }

        [TestMethod]
        public void IsValidWithValidMovePositionCol()
        {
            // Arange
            PlayBoard testBoard = new PlayBoard();

            int rowPosition = 0;
            int colPosition = 0;

            for (int i = 0; i < testBoard.GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < testBoard.GameBoard.GetLength(1); j++)
                {
                    if (testBoard.GameBoard[i, j] == 0)
                    {
                        rowPosition = i;
                        colPosition = j;
                    }
                }
            }
            // Act
            bool moveResultRight = testBoard.IsValidMove(rowPosition, colPosition + 1);
            bool moveResultLeft = testBoard.IsValidMove(rowPosition, colPosition - 1);
            bool moveResult = (moveResultLeft || moveResultRight);

            // Assert
            Assert.IsTrue(moveResult);
        }

        [TestMethod]
        public void ValidateMoveAtInvalidePositionOutOfRange()
        {
            // Arange
            PlayBoard testBoard = new PlayBoard();

            // Act
            bool moveResultRight = testBoard.IsValidMove(testBoard.GameBoard.GetLength(0) + 1, testBoard.GameBoard.GetLength(1) + 1);
            bool moveResultLeft = testBoard.IsValidMove(testBoard.GameBoard.GetLength(0) + 1, testBoard.GameBoard.GetLength(1) + 1);
            bool moveResult = (moveResultLeft || moveResultRight);

            // Assert
            Assert.IsFalse(moveResult);
        }

        [TestMethod]
        public void ValidateMoveAtSamePositionAsStartPosition()
        {
            // Arange
            PlayBoard testBoard = new PlayBoard();

            int rowPosition = 0;
            int colPosition = 0;

            for (int i = 0; i < testBoard.GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < testBoard.GameBoard.GetLength(1); j++)
                {
                    if (testBoard.GameBoard[i, j] == 0)
                    {
                        rowPosition = i;
                        colPosition = j;
                    }
                }
            }

            // Act
            bool moveResultRight = testBoard.IsValidMove(rowPosition, colPosition);
            bool moveResultLeft = testBoard.IsValidMove(rowPosition, colPosition);
            bool moveResult = (moveResultLeft || moveResultRight);

            // Assert
            Assert.IsFalse(moveResult);
        }
    }
}
