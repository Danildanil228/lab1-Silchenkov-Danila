using System.Text;

string pred = Console.ReadLine();
string[] slow = pred.Split(' ');
StringBuilder revers = new StringBuilder();
for (int i = slow.Length -1; i>= 0; i--)
{
    revers.Append(slow[i]);
    if (i > 0)
    {
        revers.Append(" ");
    }
}
Console.WriteLine(revers);
