string workingDirectory = Environment.CurrentDirectory;
string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
string[] lines = File.ReadAllLines($"{projectDirectory}\\Input.txt");
var x = 0;
var y = 0;
var aim = 0;

foreach (var line in lines)
{
    var direction = line.Split(' ')[0];
    var amount = int.Parse(line.Split(' ')[1]);

    switch (direction)
    {
        case "forward":
            x += amount;
            y += (aim * amount);
            break;
        case "up":
            aim -= amount;
            break;
        case "down":
            aim += amount;
            break;
    }
}

Console.WriteLine(x * y);

Console.WriteLine("Press any key to exit.");
Console.ReadKey();