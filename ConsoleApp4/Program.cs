// Initialize, install, use plugin and launch

using PlaywrightExtraSharp;
using PlaywrightExtraSharp.Models;
using PlaywrightExtraSharp.Plugins.ExtraStealth;

var playwrightExtra = await new PlaywrightExtra(BrowserTypeEnum.Chromium)
    .Install()
    .Use(new StealthExtraPlugin())
    .LaunchAsync(new ()
    {
        Headless = false
    });

// Create a new page
var context = await playwrightExtra.NewContextAsync();
var page = await context.NewPageAsync();
await page.GotoAsync("http://google.com");
