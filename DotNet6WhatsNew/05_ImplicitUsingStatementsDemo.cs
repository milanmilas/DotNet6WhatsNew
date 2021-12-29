        <ImplicitUsings>enable</ImplicitUsings>

        “ProjectName.GlobalUsings.g.cs”

        global using global::System;
        global using global::System.Collections.Generic;
        global using global::System.IO;
        global using global::System.Linq;
        global using global::System.Net.Http;
        global using global::System.Threading;
        global using global::System.Threading.Tasks;

        // Enable/Disable namespaces explicitly
        < ItemGroup >
            < Using Remove = "System.Threading" />
            < Using Include = "Microsoft.Extensions.Logging" />
        </ ItemGroup >
 