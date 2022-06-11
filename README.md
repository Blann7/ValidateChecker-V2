This is new version of ValidateChecker (V1 - https://github.com/Blann7/ValidateChecker-V1).
I use this version in my project - https://github.com/Blann7/RazorPagesBlog.

This V2 made with BackgroundService class (IHosted, IDisposable), and V1 made as default console application.

Project can work on Windows VPS(VDS) as default windows console application, but you can implement this into your project as Service, inherited from class BackgroundService (in asp.net project, page Program.cs - builder.Services.AddHostedService<*childclass name*>();)
