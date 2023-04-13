
//Console.Write("Enter a letter: ");
//char letter = Console.ReadLine()[0]; // read the first character of the input string
//letter = Char.ToUpper(letter); // convert the letter to uppercase

//string sentence = "THE QUICK BROWN FOX JUMPS OVER A LAZY DOG.";

//int position = sentence.IndexOf(letter); // search for the letter in the sentence

//if (position >= 0) // if the letter is found
//{
//    Console.WriteLine($"{letter} first occurrence in position {position}"); // output the letter and its position
//}
//else // if the letter is not found
//{
//    Console.WriteLine($"{letter} not found in sentence."); // output a message saying that the letter was not found
//}

//Console.ReadKey(); // wait for user input before exiting 


Console.Write("Enter a letter: ");
char letter = Console.ReadLine()[0]; // read the first character of the input string
letter = Char.ToUpper(letter); // convert the letter to uppercase

string sentence = "THE QUICK BROWN FOX JUMPS OVER A LAZY DOG.";

int position = sentence.IndexOf(letter); // search for the letter in the sentence

if (position >= 0) // if the letter is found
{
    int start = sentence.LastIndexOf(' ', position) + 1; // find the start of the word containing the letter
    int end = sentence.IndexOf(' ', position); // find the end of the word containing the letter

    if (end == -1) end = sentence.Length; // if the word is at the end of the sentence, set the end to the length of the sentence

    string word = sentence.Substring(start, end - start); // extract the word containing the letter

    Console.WriteLine($"{letter} first occurrence in position {position}"); // output the letter and the word containing the letter
}
else // if the letter is not found
{
    Console.WriteLine($"{letter} not found in sentence."); // output a message saying that the letter was not found
}

Console.ReadKey(); // wait for user input before exiting


//2


//Console.WriteLine("Enter a letter:");
//string input = Console.ReadLine();
//char letter = Char.ToUpper(input[0]);

//string sentence = "THE QUICK BROWN FOX JUMPS OVER A LAZY DOG.";
//int index = sentence.IndexOf(letter);

//if (index >= 0)
//{
//    int startIndex = index;
//    int endIndex = sentence.IndexOf(" ", index); //check if the letter appears in the remainder of the word 
//    string word = sentence.Substring(startIndex, endIndex - startIndex);//extract the remainder of the word after the letter
//    Console.WriteLine($"{letter} first occurrence in word {word}");

//}
//else
//{
//    Console.WriteLine($"{letter} does not appear in the sentence.");
//}
