string sentence = "The quick brown fox jumps over the lazy dog";
string[] words = sentence.Split(' ');
List<string> reversedWords = new();
foreach(string word in words) {
    string reversed = ReverseString(word);
    reversedWords.Add(reversed);
}
string pangramString = string.Join(' ', reversedWords);
Console.WriteLine($"Using List: {pangramString}");

string[] reversedWordsArray = new string[words.Length];
for(int i = 0; i < words.Length; i++) {
    string reversed = ReverseString(words[i]);
    reversedWordsArray[i] = reversed;
}
pangramString = string.Join(' ', reversedWordsArray);
Console.WriteLine("Using Arrays: {0}", pangramString);

string ReverseString(string str) {
    var characters = str.ToCharArray();
    Array.Reverse(characters);
    return new string(characters);
}