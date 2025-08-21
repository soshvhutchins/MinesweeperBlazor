using Minesweeper.BlazorClient.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Minesweeper.BlazorClient.Services;

public interface IMinesweeperService
{
    Task<List<DifficultyModel>> GetDifficultiesAsync();
    Task<GameModel> StartNewGameAsync(string difficulty);
    Task<GameModel> RevealCellAsync(string gameId, int row, int column);
    Task<GameModel> FlagCellAsync(string gameId, int row, int column);
    Task<GameModel> GetGameAsync(string gameId);
}
