using System.Collections.Generic;

namespace StockManagerHero
{
    public abstract class Block
    {
        protected abstract Tile[][] Tiles { get; }
        public int stateNbr;
        public int rotationState;


        public Block()
        {
            stateNbr = Tiles.Length;
        }

        public IEnumerable<Tile> TilePositions()
        {
            foreach (Tile t in Tiles[rotationState])
            {
                yield return new Tile(t.Row, t.Col);
            }
        }

        public void Rotate()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }

        public bool CheckPlacement(int row, int col, int rotationState, GameGrid grid)
        {
            if (row < 0 || col < 0) return false;
            foreach (var tile in Tiles[rotationState])
            {
                if (row + tile.Row >= 9 || col + tile.Col >= 9) return false;
                if (grid[row + tile.Row, col + tile.Col] == 1) return false;
            }
            return true;
        }

        public void PlaceBlock(int row, int col, GameGrid grid)
        {
            foreach (var tile in Tiles[rotationState])
            {
                grid[row + tile.Row, col + tile.Col] = 1;
            }
        }
    }
}
