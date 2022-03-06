using System.CommandLine;
using Dhl.Commands;

RootCommand rootCommand = new();
Command create = new("create");
create.SetHandler(() =>
{
    CreateCommand.Handle();
});
rootCommand.Add(create);


Command add = new("add");
add.SetHandler(() =>
{
    AddCommand.Handle();
});
rootCommand.Add(add);

return await rootCommand.InvokeAsync(args);