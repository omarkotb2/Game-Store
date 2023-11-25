namespace GameZone.Services
{
    public interface IGameService
    {
        Game? GetByID(int id);
        IEnumerable<Game> GetAll();
        Task  Create(CreateGameFormViewModel model);
        Task<Game?> Edit(EditGameFormViewModel model);
        bool Delete(int id);
    }
}
