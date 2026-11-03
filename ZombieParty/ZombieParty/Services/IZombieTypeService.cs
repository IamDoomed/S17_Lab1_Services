using ZombieParty.Models;

namespace ZombieParty.Services
{
    public interface IZombieTypeService : IServiceBaseAsync<ZombieType>
    {
        bool HasAssociatedZombies(int id);
    }
}