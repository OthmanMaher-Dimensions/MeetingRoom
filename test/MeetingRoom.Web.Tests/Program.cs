using Microsoft.AspNetCore.Builder;
using MeetingRoom;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<MeetingRoomWebTestModule>();

public partial class Program
{
}
