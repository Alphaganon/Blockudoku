using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace StockManagerHero
{
    public partial class Blockudoku : Form
    {
        string filePath = Environment.CurrentDirectory;
        private string[] tileImages;
        private int cellSize;
        private readonly Stopwatch stopwatch = new Stopwatch();
        private GameState gameState = new GameState();
        private Stopwatch bonusTimer = new Stopwatch();
        private LanguageMenu languageMenu;
        public bool isFrench = true;
        public bool rotate = false;

        public Blockudoku()
        {
            InitializeComponent();
            tileImages = new string[]
            {
                Directory.GetFiles(filePath, "TileEmpty.png")[0],
                Directory.GetFiles(filePath, "Cardboard.png")[0],
                Directory.GetFiles(filePath, "TileYellow.png")[0]
            };
            languageMenu = new LanguageMenu(this);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void StockManager_Load(object sender, EventArgs e)
        {
            cellSize = GameCanvas.Size.Width/9;
            ScoreText.BringToFront();
            this.Controls.Add(languageMenu);
            languageMenu.BringToFront();
            GameTimer.Start();
            stopwatch.Start();
            DrawGrid();
        }

        private void DrawGrid()
        {
            Image backgroundImg = new Bitmap(cellSize * gameState.GameGrid.Rows, cellSize * gameState.GameGrid.Columns);
            Graphics g = Graphics.FromImage(backgroundImg);
            for (int i = 0; i < gameState.GameGrid.Rows; i++)
            {
                for (int j = 0; j < gameState.GameGrid.Columns; j++)
                {
                    Image img = new Bitmap(Image.FromFile(tileImages[gameState.GameGrid[i, j]]), new Size(cellSize, cellSize));
                    g.DrawImage(img, i * cellSize, j * cellSize);
                    img.Dispose();
                }
            }
            g.FillRectangle(Brushes.Black, new Rectangle(147, 0, 6, 450));
            g.FillRectangle(Brushes.Black, new Rectangle(297, 0, 6, 450));
            g.FillRectangle(Brushes.Black, new Rectangle(0, 147, 450, 6));
            g.FillRectangle(Brushes.Black, new Rectangle(0, 297, 450, 6));
            g.Dispose();
            GameCanvas.BackgroundImage = backgroundImg;
        }

        private void DrawBlock(Block block, Graphics g)
        {
            foreach (Tile t in block.TilePositions())
            {
                if (t.Row + gameState.MousePosOnGrid[0] < 9 && t.Row + gameState.MousePosOnGrid[0] >= 0 && t.Col + gameState.MousePosOnGrid[1] < 9 && t.Col + gameState.MousePosOnGrid[1] >= 0)
                {
                    Image img = new Bitmap(Image.FromFile(tileImages[2]), new Size(cellSize, cellSize));
                    ColorMatrix colormatrix = new ColorMatrix();
                    colormatrix.Matrix33 = 0.5f;
                    ImageAttributes imgAttribute = new ImageAttributes();
                    imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(img, new Rectangle(t.Row * cellSize + gameState.MousePosMove[0] - cellSize / 2, t.Col * cellSize + gameState.MousePosMove[1] - cellSize / 2,
                                img.Width, img.Height),
                                0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
                    img.Dispose();
                    imgAttribute.Dispose();
                }
            }

        }

        private void Update(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawBlock(gameState.CurrentBlock, g);
        }

        private void GetMousePos(object sender, MouseEventArgs e)
        {
            gameState.MousePosOnGrid[0] = e.Location.X / cellSize;
            gameState.MousePosOnGrid[1] = e.Location.Y / cellSize;
            gameState.MousePosMove[0] = e.Location.X;
            gameState.MousePosMove[1] = e.Location.Y;
        }

        private void CheckAddScore()
        {
            int currentScore = gameState.Score;
            gameState.CheckAddScore();
            if (gameState.Score != currentScore)
            {
                stopwatch.Stop();
                if (stopwatch.ElapsedMilliseconds < 8000)
                {
                    gameState.Score += gameState.Score - currentScore;
                    BonusText.Text = "Bonus Timer : x2";
                    BonusText.BringToFront();
                }
                else if (stopwatch.ElapsedMilliseconds > 16000) { }
                else
                {
                    float multiplier = (float)16000 / (float)stopwatch.ElapsedMilliseconds;
                    gameState.Score += (int)((gameState.Score - currentScore) * multiplier);
                    BonusText.Text = "Bonus Timer : x" + multiplier.ToString().Substring(0, 4);
                    BonusText.BringToFront();
                }
                stopwatch.Restart();
                bonusTimer.Start();
            }
            ScoreText.Text = $"Score: {gameState.Score}";
            GameCanvas.Invalidate();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (bonusTimer.ElapsedMilliseconds > 2000)
            {
                ScoreText.BringToFront();
                bonusTimer.Reset();
            }
            if (!gameState.GameOver)
            {
                GameCanvas.Invalidate();
                if (gameState.IsGameOver(rotate))
                {
                    GameOverMenu gameOverMenu = new GameOverMenu(this);
                    gameOverMenu.SetText(gameState.Score.ToString());
                    Thread.Sleep(3000);
                    this.Controls.Add(gameOverMenu);
                    gameOverMenu.BringToFront();
                    gameState = new GameState();
                    ScoreText.Text = $"Score: {gameState.Score}";
                    DrawGrid();
                }
            }
        }

        private void ReactOnClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gameState.PlaceBlock();
                CheckAddScore();
                DrawGrid();
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (rotate) gameState.CurrentBlock.Rotate();
            }
        }
    }
}
