dotnet publish -c Release -r linux-x64 --self-contained true --output $HOME/.local/share/dhl
dotnet new -i Avalonia.Templates

chmod +x $HOME/.local/share/dhl/Dhl

sudo ln -s $HOME/.local/share/dhl/Dhl /usr/local/bin/dhl