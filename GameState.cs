namespace StockManagerHero
{
    public class GameState
    {
        private Block currentBlock;

        public Block CurrentBlock
        {
            get { return currentBlock; }
            private set
            {
                currentBlock = value;
            }
        }

        public GameGrid GameGrid { get; }
        public BlockGenerator BlockQueue { get; }
        public bool GameOver { get; private set; }
        public int Score { get; set; }

        public int[] MousePosOnGrid = new int[2];
        public int[] MousePosMove = new int[2];

        public GameState()
        {
            GameGrid = new GameGrid(9, 9);
            BlockQueue = new BlockGenerator();
            CurrentBlock = BlockQueue.GetAndUpdate();
            Score = 0;
        }

        private bool BlockFits()
        {
            return CurrentBlock.CheckPlacement(MousePosOnGrid[0], MousePosOnGrid[1], currentBlock.rotationState, GameGrid);
        }

        public bool IsGameOver(bool rotate)
        {
            if (rotate)
            {
                for (int rotationState = 0; rotationState < currentBlock.stateNbr; rotationState++)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (currentBlock.CheckPlacement(i, j, rotationState, GameGrid)) return false;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (currentBlock.CheckPlacement(i, j, currentBlock.rotationState, GameGrid)) return false;
                    }
                }
            }
            GameOver = true;
            return true;
        }

        public void PlaceBlock()
        {
            if (BlockFits())
            {
                currentBlock.PlaceBlock(MousePosOnGrid[0], MousePosOnGrid[1], GameGrid);
                CurrentBlock = BlockQueue.GetAndUpdate();
            }
        }

        public void CheckAddScore()
        {
            Score += GameGrid.CheckAndClear();
        }
    }
}
