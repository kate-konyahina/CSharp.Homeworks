// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Insert your text");
string text = Console.ReadLine();

Console.WriteLine("Your text without longest word:");
DeleteLongestWord(text);
void DeleteLongestWord(string text)
{
    string[] word = text.Split(' ' , '.');
    int biggestLength = 0;
    int biggestIndex = 0;
    for (int i = 0; i < word.Length; i++) 
    { 
    if (word[i].Length > biggestLength) 
        { 
            biggestLength = word[i].Length;
            biggestIndex = i;
        }
    }

    string[] newWord = new string[word.Length-1];

    for (int i = 0; i < biggestIndex; i++)
        newWord[i] = word[i];

    for (int i = biggestIndex + 1; i < word.Length - 1; i++)
        newWord[i - 1] = word[i];

        var result = string.Join(" ", newWord);
    Console.WriteLine(result);
}

Console.WriteLine("Swap the longest and the shortest words:");
SwapLongestWithShortest(text);
void SwapLongestWithShortest(string text)
{    string[] word = text.Split(' ');
    int biggestLength = 0;
    int biggestIndex = 0;
    for (int i = 0; i < word.Length; i++)
    {
        if (word[i].Length > biggestLength)
        {
            biggestLength = word[i].Length;
            biggestIndex = i;
        }
    }

    int smallestLength = word[biggestLength].Length;
    int smallestIndex = 0;
    for (int i = 0; i < word.Length; i++)
    {
        if (word[i].Length < smallestLength)
        {
            smallestLength = word[i].Length;
            smallestIndex = i;
        }
    }

    string temp = word[smallestIndex];
    word[smallestIndex] = word[biggestIndex];
    word[biggestIndex] = temp;

   
    string result = string.Join(" ", word);
    Console.WriteLine(result);
}

Console.WriteLine("Number of letters and punctial signs in your text:");
LettersPunctuationsNumber(text);
void LettersPunctuationsNumber(string text)
{
    string[] word = text.Split(' ');
    string result = string.Join("", word);
    Console.WriteLine(result.Length);
}

Console.WriteLine("Your text sorted from the longest word to the shortest:");
SortingByLength(text);
void SortingByLength(string text)
{
    string[] word = text.Split(' ');
    Array.Sort(word, (x, y) => y.Length.CompareTo(x.Length));

    string result = string.Join(" ", word);
    Console.WriteLine(result);
}    