using System;
using System.Collections.Generic;

public class FileSystemNode
{
    public string Name { get; set; }
    public string Type { get; set; } // "directory" or "file"
    public List<FileSystemNode> Children { get; set; }

    public FileSystemNode(string name, string type)
    {
        Name = name;
        Type = type;
        Children = new List<FileSystemNode>();
    }

    public void AddChild(FileSystemNode child)
    {
        Children.Add(child);
    }
}

public class FileSystemTree
{
    public FileSystemNode Root { get; set; }

    public FileSystemTree(string rootName)
    {
        Root = new FileSystemNode(rootName, "directory");
    }

    public FileSystemNode FindDirectory(string path)
    {
        string[] parts = path.Split('/');
        FileSystemNode current = Root;

        for (int i = 1; i < parts.Length; i++)
        {
            string directoryName = parts[i];
            bool found = false;
            foreach (var child in current.Children)
            {
                if (child.Type == "directory" && child.Name == directoryName)
                {
                    current = child;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                return null;
            }
        }
        return current;
    }

    public void AddFileSystemNode(string parentPath, string newNodeName, string newNodeType)
    {
        FileSystemNode parentDirectory = FindDirectory(parentPath);
        if (parentDirectory != null)
        {
            FileSystemNode newNode = new FileSystemNode(newNodeName, newNodeType);
            parentDirectory.AddChild(newNode);
            Console.WriteLine(<span class="math-inline">"Successfully added '\{newNodeName\}' \(type\: \{newNodeType\}\) to '\{parentPath\}'\."\);
\}
else
\{
Console\.WriteLine\(</span>"Error: Parent directory '{parentPath}' not found.");
        }
    }

    // Helper method to adapt FindNodeDFS for FileSystemNode
    public FileSystemNode FindFileSystemNodeDFS(FileSystemNode root, string name)
    {
        if (root == null)
        {
            return null;
        }

        if (root.Name == name)
        {
            return root;
        }

        foreach (var child in root.Children)
        {
            FileSystemNode foundNode = FindFileSystemNodeDFS(child, name);
            if (foundNode != null)
            {
                return foundNode;
            }
        }

        return null;
    }

    public void DisplayTree(FileSystemNode node, int level)
    {
        Console.WriteLine($"{new string(' ', level * 2)}- {node.Name} ({node.Type})");
        foreach (var child in node.Children)
        {
            DisplayTree(child, level + 1);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        FileSystemTree fileSystem = new FileSystemTree("root");

        // TODO: Your task is to add code below to perform the following actions:

        // 1. Add a new directory called "applications" to the root directory.
        //    Use the AddFileSystemNode method.

        // 2. Add a new directory called "logs" to the "applications" directory.
        //    Use the AddFileSystemNode method.

        // 3. Add a file called "app.exe" to the "applications" directory.
        //    Use the AddFileSystemNode method.

        // 4. Find the "applications" directory using the FindDirectory method and print its name.

        // 5. Find the "logs" directory using the FindDirectory method and print its name.

        // 6. Find the "app.exe" file using the FindFileSystemNodeDFS method and print its name and type.

        // 7. Try to find a non-existent directory called "temp" using the FindDirectory method and check if the result is null. Print a message if it's not found.

        // 8. Try to find a non-existent file called "data.txt" using the FindFileSystemNodeDFS method and check if the result is null. Print a message if it's not found.

        Console.WriteLine("Final File System Structure:");
        fileSystem.DisplayTree(fileSystem.Root, 0);
    }
}
