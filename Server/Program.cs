using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.SignalR;
using Shared;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddSignalR(); 
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", p =>
        p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();


app.UseCors("AllowAll");
app.MapControllers();
app.MapHub<ResourceHub>("/resourcehub"); 

app.Run();


public class ResourceHub : Microsoft.AspNetCore.SignalR.Hub
{
    public async Task UpdateList()
    {
        await Clients.All.SendAsync("ReceiveUpdate");
    }
}