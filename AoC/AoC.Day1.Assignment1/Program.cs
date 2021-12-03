string workingDirectory = Environment.CurrentDirectory;
string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

string[] lines = File.ReadAllLines($"{projectDirectory}\\Input.txt");

Console.WriteLine("Contents of WriteLines2.txt = ");
int? previousNumber = null;
var nrsHigherThanPrevious = 0;

foreach (string line in lines)
{
    if (previousNumber == null)
        previousNumber = int.Parse(line);

    var currentNumber = int.Parse(line);
    if(previousNumber < currentNumber)
        nrsHigherThanPrevious++;   

    previousNumber = currentNumber;
}

Console.WriteLine("high than previous nr = " + nrsHigherThanPrevious);

Console.WriteLine("Press any key to exit.");
Console.ReadKey();