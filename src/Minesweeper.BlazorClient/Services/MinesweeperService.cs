using Minesweeper.BlazorClient.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Minesweeper.BlazorClient.Services;

public class MinesweeperService : IMinesweeperService
{
    private readonly HttpClient _http;
    public MinesweeperService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<DifficultyModel>> GetDifficultiesAsync()
    {
        var result = await _http.GetFromJsonAsync<List<DifficultyModel>>("api/games/difficulties");
        return result ?? new List<DifficultyModel>();
    }

    public async Task<GameModel> StartNewGameAsync(string difficulty)
    {
        var response = await _http.PostAsJsonAsync("api/games", new { DifficultyName = difficulty });
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<GameModel>() ?? new GameModel();
    }

    public async Task<GameModel> RevealCellAsync(string gameId, int row, int column)
    {
        var response = await _http.PostAsJsonAsync($"api/games/{gameId}/reveal", new { Row = row, Column = column });
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<GameModel>() ?? new GameModel();
    }

    public async Task<GameModel> FlagCellAsync(string gameId, int row, int column)
    {
        var response = await _http.PostAsJsonAsync($"api/games/{gameId}/flag", new { Row = row, Column = column });
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<GameModel>() ?? new GameModel();
    }

    public async Task<GameModel> GetGameAsync(string gameId)
    {
        var result = await _http.GetFromJsonAsync<GameModel>($"api/games/{gameId}");
        return result ?? new GameModel();
    }
}
