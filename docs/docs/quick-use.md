# TL;DR

Add the Xdg.Directories package to your project:

```bash
dotnet add package Xdg.Directories
```

Then use the `BaseDirectory` and `UserDirectory` classes to access the XDG directories:

```csharp
using System;
using Xdg.Directories;

// Prints /home/$USER/.local/share
Console.Writeline(BaseDirectory.DataHome);

// Prints /home/$USER/Documents
Console.Writeline(UserDirectory.DocumentsDir);
```

For more information, see the [API documentation](/api/Xdg.Directories.html).
