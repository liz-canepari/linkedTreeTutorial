// 1. Add a new directory called "applications" to the root directory.
        fileSystem.AddFileSystemNode("root", "applications", "directory");

        // 2. Add a new directory called "logs" to the "applications" directory.
        fileSystem.AddFileSystemNode("root/applications", "logs", "directory");

        // 3. Add a file called "app.exe" to the "applications" directory.
        fileSystem.AddFileSystemNode("root/applications", "app.exe", "file");

        // 4. Find the "applications" directory using the FindDirectory method and print its name.
        FileSystemNode applicationsDir = fileSystem.FindDirectory("root/applications");
        if (applicationsDir != null)
        {
            Console.WriteLine(<span class="math-inline">"Found directory\: \{applicationsDir\.Name\}"\);
\}
else
\{
Console\.WriteLine\("Directory 'applications' not found\."\);
\}
// 5\. Find the "logs" directory using the FindDirectory method and print its name\.
FileSystemNode logsDir \= fileSystem\.FindDirectory\("root/applications/logs"\);
if \(logsDir \!\= null\)
\{
Console\.WriteLine\(</span>"Found directory: {logsDir.Name}");
        }
        else
        {
            Console.WriteLine("Directory 'logs' not found.");
        }

        // 6. Find the "app.exe" file using the FindFileSystemNodeDFS method and print its name and type.
        FileSystemNode appFile = fileSystem.FindFileSystemNodeDFS(fileSystem.Root, "app.exe");
        if (appFile != null)
        {
            Console.WriteLine(<span class="math-inline">"Found file\: \{appFile\.Name\} \(Type\: \{appFile\.Type\}\)"\);
\}
else
\{
Console\.WriteLine\("File 'app\.exe' not found\."\);
\}
// 7\. Try to find a non\-existent directory called "temp" using the FindDirectory method and check if the result is null\. Print a message if it's not found\.
FileSystemNode tempDir \= fileSystem\.FindDirectory\("root/temp"\);
if \(tempDir \=\= null\)
\{
Console\.WriteLine\("Directory 'temp' not found \(as expected\)\."\);
\}
else
\{
Console\.WriteLine\(</span>"Error: Found unexpected directory 'temp'.");
        }

        // 8. Try to find a non-existent file called "data.txt" using the FindFileSystemNodeDFS method and check if the result is null. Print a message if it's not found.
        FileSystemNode dataFile = fileSystem.FindFileSystemNodeDFS(fileSystem.Root, "data.txt");
        if (dataFile == null)
        {
            Console.WriteLine("File 'data.txt' not found (as expected).");
        }
        else
        {
            Console.WriteLine($"Error: Found unexpected file 'data.txt'.");
        }
