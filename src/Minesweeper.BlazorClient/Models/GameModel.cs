using System.Collections.Generic;

namespace Minesweeper.BlazorClient.Models;

public class GameModel
{
    public string Id { get; set; } = string.Empty;
    public string Status { get; set; } = "NotStarted";
    public int Rows { get; set; }
    public int Columns { get; set; }
    public int MineCount { get; set; }
    public int FlagsUsed { get; set; }
    public int ElapsedSeconds { get; set; }
    public CellModel[,] Cells { get; set; } = default!;
    public string Difficulty { get; set; } = "Beginner";
}
