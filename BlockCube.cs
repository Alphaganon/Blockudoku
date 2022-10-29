namespace StockManagerHero
{
    public class BlockCube : Block
    {
        private readonly Tile[][] tiles = new Tile[][]
        {
            new Tile[] { new Tile(0, 0), new Tile(0, 1), new Tile(1, 0), new Tile(1, 1) }
        };
        protected override Tile[][] Tiles => tiles;
    }
}
