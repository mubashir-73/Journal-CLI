
namespace journalcli
{
    internal class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine($"Number of args:{args.Length}");
            var content = "Start typing your journal here";
            var root = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),".journal");
            bool fileExist =Directory.Exists(root);
            if (!fileExist)
            {
                Directory.CreateDirectory(root);
            }
            Console.WriteLine($"The current directory is {root}");
            var newFolderPath = Path.Combine(root, $"{DateTime.Now:yyyy}");
            var newFilePath = Path.Combine(newFolderPath, $"{DateTime.Now:MM-dd}.md");
            Directory.CreateDirectory(newFolderPath);
            System.IO.File.WriteAllText($"{newFilePath}", content);
            Console.WriteLine($"The new file path would be {newFolderPath}");
        }
}
}