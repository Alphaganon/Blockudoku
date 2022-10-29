namespace StockManagerHero
{
    public class BlockSingle : Block
    {
        private readonly Tile[][] tiles = new Tile[][]
        {
            new Tile[] { new Tile(0, 0) }
        };
        protected override Tile[][] Tiles => tiles;
    }
}
