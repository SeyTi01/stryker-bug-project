using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace StrykerBugProject;

public static class Program {
    public static async Task Main(string[] args) {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        await builder.Build().RunAsync();
    }
}
