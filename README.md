# Console Framework
Console framework for [Rust](https://store.steampowered.com/app/252490/Rust/) using the [Oxide/uMod](https://umod.org) or [Carbon](https://carbonmod.gg) extension platforms, allowing you to log in Pterodactyl's console using colors. *(It might work in other consoles, but hasn't been tested.)*

## Getting Started
Download the artifact for your extension platform from the latest release:

### Oxide/uMod
1. Download `Oxide.Ext.ConsoleExt.dll`.
2. Put the DLL into the `RustDedicated_Data\Managed` folder.
3. Restart the server.

### Carbon
1. Download `Carbon.Ext.ConsoleExt.dll`.
2. Put the DLL into the `carbon\extensions` folder.
3. Restart the server.

## Usage
```csharp
using Oxide.Ext.ConsoleExt;

// some code
OxideConsole.Log("Hello World", OxideConsole.GREEN);
```
![image](https://github.com/ilovepatatos-rust/console-extension/assets/49655463/ce609a19-1f12-4554-b488-9043555a9b40)
