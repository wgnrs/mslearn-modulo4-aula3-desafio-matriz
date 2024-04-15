string pangram = "The quick brown fox jumps over the lazy dog";

string[] newPangram = pangram.Split(' ');

string[] reversePangram = new string[newPangram.Length];

for (int i = 0; i < newPangram.Length; i++)
{
    char[] letters = newPangram[i].ToCharArray();
    Array.Reverse(letters);
    reversePangram[i] = new string(letters);
}

string result = String.Join(" ", reversePangram);
System.Console.WriteLine(result);
