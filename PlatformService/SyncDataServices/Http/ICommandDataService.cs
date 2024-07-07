using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    public interface ICommandDataService
    {
        Task SendPlatformToCommand(PlatformReadDto plat);
    }
}