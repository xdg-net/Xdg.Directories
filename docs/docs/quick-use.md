# TL;DR

Add the Xdg.Directories package to your project:

```bash
dotnet add package Xdg.Directories
```

Then use the `BaseDirectory` and `UserDirectory` classes to access the XDG directories:

```csharp
using System;
using System.IO;
using Xdg.Directories;

// Prints /home/$USER/.local/share
Console.Writeline(BaseDirectory.DataHome);

// Prints /home/$USER/Documents
Console.Writeline(UserDirectory.DocumentsDir);

// Create and open a new cache file under the "foo" directory
FileStream file = File.Open(BaseDirectory.CacheFile("foo/bar.json"), FileMode.OpenOrCreate);
```

For more information, see the [API documentation](/api/Xdg.Directories.html).
