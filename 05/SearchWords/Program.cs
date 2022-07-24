// Given a list of words
// Store the words in some data structure
// Give search option to search for a particular word
// Give search option to search for a list of words using wildcards
// * to be handled - * can represent only 1 character
// sure - s*re - sur* - *ure 

using System.Net.Http;

// string url = "https://gist.githubusercontent.com/paulcc/3799331/raw/74207b4ee400469ddbb61d297dbd62f31a3407ce/gistfile1.txt";
// string wordList = string.Empty;
// using(HttpClient  client = new HttpClient()) {
//    wordList = await client.GetStringAsync(url);
// }
// string[] listOfWords = wordList.Split("\n");

string[] listOfWords = new[] {"car", "man", "seen", "amen", "sure"};
SearchWords search = new(listOfWords);

string word = "amen";
foreach(var w in search.GenerateWildCards(word)) {
    Console.WriteLine(w);
}

// string[] wordsForTesting = new[] {"ali", "amen", "agha", "sure", "nil"};
// foreach(string word in wordsForTesting) {
//     Console.WriteLine($"{word} Found: {search.Search(word)}");
// }

// wordsForTesting = new[] {"al*", "*men", "ag*a", "sur*", "n*l"};
// foreach(string word in wordsForTesting) {
//     Console.WriteLine($"{word} Found: {search.SearchWithWildcard(word)}");
// }

// O(N)
class SearchWords {
    private readonly Dictionary<string, string> words;

    public SearchWords(string[] words) {
        //this.words = words.ToDictionary(x => x, x => true);
        /**
        for(int i = 0; i <  words.Length; i++) {
            if(word.Length != words[i].Length) continue;
            if(word == words[i]) return true;
            int j = 0;
            for(; j < word.Length; j++) {
                if(word[j] == '*') continue;
                if(words[i][j] != word[j]) break;
            }
            if(j == word.Length) return true;
        }
        return false;
        **/
    }

    public IEnumerable<string> GenerateWildCards(string word) {
        for(int i = 0; i < word.Length; i++) {
            string begin = "";
            string end = "";
            if(i > 0) begin = word.Substring(0, i);
            if(i < word.Length - 1) end = word.Substring(i + 1, word.Length - i - 1);
            yield return (begin + '*' + end);
        }
        yield return word;
    }

    // car

    // car
    // *ar
    // c*r
    // ca*


    // O(1)
    public bool Search(string word) {
        return words.ContainsKey(word);
    }

}