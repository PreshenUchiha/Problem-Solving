//Console.Write("Enter a letter: ");
//char letter = Console.ReadLine()[0];

//// Convert letter to uppercase
//letter = char.ToUpper(letter);

//// Find the index of the first occurrence of the letter in the sentence
//string sentence = "THE QUICK BROWN FOX JUMPS OVER A LAZY DOG.";
//int index = sentence.IndexOf(letter);

//if (index >= 0)
//{
//    // Extract the word that contains the letter
//    int startIndex = sentence.LastIndexOf(' ', index) + 1;
//    int endIndex = sentence.IndexOf(' ', index);
//    if (endIndex < 0)
//    {
//        endIndex = sentence.Length;
//    }
//    string word = sentence.Substring(startIndex, endIndex - startIndex);

//    Console.WriteLine($"{letter} first occurrence in word {word}");
//}
//else
//{
//    Console.WriteLine($"The letter {letter} is not found in the sentence.");
//}


//Console.WriteLine("Enter a letter:");
//string input = Console.ReadLine();
//char letter = Char.ToUpper(input[0]);

//string sentence = "THE QUICK BROWN FOX JUMPS OVER A LAZY DOG.";
//int index = sentence.IndexOf(letter);

//if (index >= 0)
//{
//    int startIndex = index - 1;
//    int endIndex = sentence.IndexOf(" ", index);
//    if (endIndex < 0) endIndex = sentence.Length;

//    string word = sentence.Substring(startIndex, endIndex - startIndex);
//    string result = word.Replace(letter.ToString(), "");


//    Console.WriteLine($"{letter} first occurrence in word {result}");
//}
//else
//{
//    Console.WriteLine($"{letter} does not appear in the sentence.");
//}

Console.WriteLine("Enter a letter:");
string input = Console.ReadLine();
char letter = Char.ToUpper(input[0]);

string sentence = "THE QUICK BROWN FOX JUMPS OVER A LAZY DOG.";
int index = sentence.IndexOf(letter);

if (index >= 0)
{
    int startIndex = index - 1;
    int endIndex = sentence.IndexOf(" ", startIndex);
    if (endIndex < 0) endIndex = sentence.Length;

    string word = sentence.Substring(startIndex, endIndex - startIndex);

    int letterIndex = word.IndexOf(letter);
    if (letterIndex >= 0)
    {
        string remainder = word.Substring(letterIndex);
        Console.WriteLine($"{letter} first occurrence in word {remainder}");
    }
}
else
{
    Console.WriteLine($"{letter} does not appear in the sentence.");
}





















