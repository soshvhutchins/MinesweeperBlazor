namespace Minesweeper.BlazorClient.Models;

public class CellModel
{
    public int Row { get; set; }
    public int Column { get; set; }
    public bool IsRevealed { get; set; }
    public bool HasMine { get; set; }
    public int AdjacentMineCount { get; set; }
    public bool IsFlagged { get; set; }
}
