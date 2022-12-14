namespace StockManagerHero
{
    public class BlockL : Block
    {
        private readonly Tile[][] tiles = new Tile[][]
        {
            new Tile[] { new Tile(0, 0), new Tile(1, 0), new Tile(2, 0), new Tile(2, 1), new Tile(2, 2) },
            new Tile[] { new Tile(0, 2), new Tile(1, 2), new Tile(2, 0), new Tile(2, 1), new Tile(2, 2) },
            new Tile[] { new Tile(0, 0), new Tile(0, 1), new Tile(0, 2), new Tile(1, 2), new Tile(2, 2) },
            new Tile[] { new Tile(0, 0), new Tile(0, 1), new Tile(0, 2), new Tile(1, 0), new Tile(2, 0) }
        };
        protected override Tile[][] Tiles => tiles;
    }
}
