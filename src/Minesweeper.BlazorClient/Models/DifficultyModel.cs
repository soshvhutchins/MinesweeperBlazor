namespace Minesweeper.BlazorClient.Models;

public class DifficultyModel
{
    public string Name { get; set; } = "Beginner";
    public int Rows { get; set; }
    public int Columns { get; set; }
    public int MineCount { get; set; }
}
