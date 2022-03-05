using System.CommandLine;
using Dhl.Commands;

RootCommand rootCommand = new();
Command create = new("create");
create.SetHandler(() =>
{
    CreateCommand.Handle();
});

Command scaffold = new("scaffold");
scaffold.SetHandler(() =>
{
    ScaffoldCommand.Handle();
});

rootCommand.Add(create);

return await rootCommand.InvokeAsync(args);