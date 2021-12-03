string workingDirectory = Environment.CurrentDirectory;
string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
string[] lines = File.ReadAllLines($"{projectDirectory}\\Input.txt");
int? previousSum = null;
var nrsHigherThanPrevious = 0;

for (var i = 2; i < lines.Length; i ++)
{
    var firstNumber = int.Parse(lines[i - 2]);
    var secondNumber = int.Parse(lines[i - 1]);
    var thirdNumber = int.Parse(lines[i]);

    if (previousSum == null)
        previousSum = firstNumber + secondNumber + thirdNumber;

    var currentSum = firstNumber + secondNumber + thirdNumber;
    if (previousSum < currentSum)
        nrsHigherThanPrevious++;

    previousSum = currentSum;
}

Console.WriteLine("higher than previous nr = " + nrsHigherThanPrevious);

Console.WriteLine("Press any key to exit.");
Console.ReadKey();