using System;
// See https://aka.ms/new-console-template for more information
// Create FileystemWatcher, set directory, and an empty filte
FileSystemWatcher watcher = new FileSystemWatcher();
try{
watcher.Path = "";//System.Reflection.Assembly.GetExecutingAssembly().Location;
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}
watcher.Filter = "";
watcher.IncludeSubdirectories = true;
watcher.Changed += onChanged;
watcher.Created += onCreate;
watcher.Deleted += onDelete;
//HttpClient client = new HttpClient();
//client.BaseAddress = new Uri("http://localhost:6969");
//client.Send(new HttpRequestMessage(HttpMethod.Post, "/api/notify"));

static void onChanged(object source, FileSystemEventArgs e)
{
    Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
}

static void onCreate(object source, FileSystemEventArgs e)
{
    Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
}

static void onDelete(object source, FileSystemEventArgs e)
{
    Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
}
