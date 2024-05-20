using helloMVC.Controllers;
using Jering.Javascript.NodeJS;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using System.IO;
using TodoApi;

var services = new ServiceCollection();
services.AddNodeJS();
ServiceProvider serviceProvider = services.BuildServiceProvider(); 
INodeJSService nodeJSService = serviceProvider.GetRequiredService<INodeJSService>();
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/qr", QR);

app.MapGet("/", () => "Hello World!");


var todoItems = app.MapGroup("/Inode");
todoItems.MapGet("/", getnode);

async Task<string> getnode(HttpContext context)
{
    Result? result = await nodeJSService.InvokeFromFileAsync<Result>("QR.js", args: new[] { "success" });
    Console.WriteLine(result.Message);

    return result.Message;

}

app.MapGet("/users/{userId}/{postID}", 
    (string userId, int postID) => $"The user id is {userId} and post id is {postID}");

  async Task<IActionResult>QR(string text = "uwu")      
{    
    Console.WriteLine("API IS called from c#");
    var data = await nodeJSService.InvokeFromFileAsync<CacheVaryByRules>("./qr.js");


    if (File.Exists("./qr.js"))
    {
        Console.WriteLine("File exist");
    }
    else
    {
        Console.WriteLine("File DOESNOT exist");
    }
   
    IActionResult my = (IActionResult)data.VaryByValues;
    return (ViewResult)my;
}


app.Run();


     async Task<string> HelloAsync(string text = "42") 
    {

        Console.WriteLine("calling js interop");

        if (File.Exists("./qr.js"))
        {
            Console.WriteLine("File exist");
        }
        else
        {
            Console.WriteLine("File DOESNOT exist");
        }



         byte[] data = await  nodeJSService.InvokeFromFileAsync<byte[]>("./qr.js",text.ToString());
        FileOptions edit = FileOptions.WriteThrough;
        File.Create("/Image", data.Length,edit);
        
        return "Hello Instance method";
       
    
}


