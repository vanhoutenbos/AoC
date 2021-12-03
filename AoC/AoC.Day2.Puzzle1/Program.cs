string workingDirectory = Environment.CurrentDirectory;
string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
string[] lines = File.ReadAllLines($"{projectDirectory}\\Input.txt");
var x = 0;
var y = 0;

foreach(var line in lines)
{
    var direction = line.Split(' ')[0];
    var amount = int.Parse(line.Split(' ')[1]);

    switch (direction)
    {
        case "forward":
            x += amount;
            break;
        case "up":
            y -= amount;
            break;
        case "down":
            y += amount;
            break;
    }
}

Console.WriteLine(x * y);

Console.WriteLine("Press any key to exit.");
Console.ReadKey();