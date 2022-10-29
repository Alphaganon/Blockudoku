using System;

namespace StockManagerHero
{
    public class BlockGenerator
    {
        private readonly Block[] blocks = new Block[]
        {
            new BlockL(),
            new BlockC(),
            new BlockCube(),
            new BlockSmolL(),
            new BlockT(),
            new BlockSingle(),
            new BlockI()
        };
        private readonly Random r = new Random();
        public Block NextBlock { get; private set; }

        public BlockGenerator()
        {
            NextBlock = RandomBlock();
        }
        private Block RandomBlock()
        {
            Block nextBlock = blocks[r.Next(blocks.Length)];
            nextBlock.rotationState = r.Next(nextBlock.stateNbr);
            return nextBlock;
        }

        public Block GetAndUpdate()
        {
            Block block = NextBlock;
            NextBlock = RandomBlock();
            return block;
        }
    }
}
