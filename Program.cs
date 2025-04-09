/*Benji Stansfield, 04-03-25, Lab 10 "MadLibs 2"*/
class Program
{
    static void Main(string[] filenames)
    {
        Console.Clear();

        Dictionary<string, List<string>> words =  new Dictionary<string, List<string>>(); //create the dictionary

        /*Different Lists containing types of words and examples of each*/
        List<string> adjective = new List<string>{"fat", "slimy", "dirty", "gorgeous", "lanky", "withered", "mysterious", "shiny", "goofy"};
        List<string> noun = new List<string>{"bear", "sticky-note", "almond", "crayon", "salmon", "orb", "boat", "box", "fire"};
        List<string> pluralNoun = new List<string>{"friends", "goats", "sandwiches", "hats", "tires", "almonds", "teeth", "clams", "teachers"};
        List<string> pastTenseVerb = new List<string>{"laughed", "choked", "ran", "fought", "fell", "ate", "cramped", "slept", "arrived"};
        List<string> verb = new List<string>{"fly", "cook", "destroy", "draw", "claim", "control", "drive", "golf", "wobble"};

        /*Adds the keys and values to the dictionary to get the examples pulled out*/
        words.Add("adjective", adjective);
        words.Add("noun", noun);
        words.Add("pluralNoun", pluralNoun);
        words.Add("pastTenseVerb", pastTenseVerb);
        words.Add("verb", verb);

        Random rand = new Random();

        /*Read the files*/
        string story1 = File.ReadAllText("story1.txt");

        string[] storyWords = story1.Split(' '); //splits the story into separate words
        List<string> generatedWords = new List<string>(); //this list will contain all of the words the story generates

        foreach(string word in storyWords)
        {
            if(word.Contains("::")) //focuses on the words in story that we need to replace
            {
                if(word.Contains("adjective"))
                {
                    string randomWord = adjective[rand.Next(adjective.Count)];
                    generatedWords.Add(randomWord);
                    continue;
                }
                if(word.Contains("plural-noun"))
                {
                    string randomWord = pluralNoun[rand.Next(pluralNoun.Count)];
                    generatedWords.Add(randomWord);
                    continue;
                }
                if(word.Contains("noun"))
                {
                    string randomWord = noun[rand.Next(noun.Count)];
                    generatedWords.Add(randomWord);
                    continue;
                }
                if(word.Contains("past-tense-verb"))
                {
                    string randomWord = pastTenseVerb[rand.Next(pastTenseVerb.Count)];
                    generatedWords.Add(randomWord);
                    continue;
                }
                if(word.Contains("verb"))
                {
                    string randomWord = verb[rand.Next(verb.Count)];
                    generatedWords.Add(randomWord);
                    continue;
                }
            }
            else
                generatedWords.Add(word); //adds the unreplaced word to the list
        }

        File.WriteAllText("generated.story1.txt", String.Join(" ", generatedWords));

        /*Repeat process for story 2*/
        string story2 = File.ReadAllText("story2.txt");

        string[] storyWords2 = story2.Split(' '); //splits the story into separate words
        List<string> generatedWords2 = new List<string>(); //this list will contain all of the words the story generates

        foreach(string word in storyWords2)
        {
            if(word.Contains("::")) //focuses on the words in story that we need to replace
            {
                if(word.Contains("adjective"))
                {
                    string randomWord = adjective[rand.Next(adjective.Count)];
                    generatedWords2.Add(randomWord);
                    continue;
                }
                if(word.Contains("noun"))
                {
                    string randomWord = noun[rand.Next(noun.Count)];
                    generatedWords2.Add(randomWord);
                    continue;
                }
                if(word.Contains("plural-noun"))
                {
                    string randomWord = pluralNoun[rand.Next(pluralNoun.Count)];
                    generatedWords2.Add(randomWord);
                    continue;
                }
                if(word.Contains("past-tense-verb"))
                {
                    string randomWord = pastTenseVerb[rand.Next(pastTenseVerb.Count)];
                    generatedWords2.Add(randomWord);
                    continue;
                }
                if(word.Contains("verb"))
                {
                    string randomWord = verb[rand.Next(verb.Count)];
                    generatedWords2.Add(randomWord);
                    continue;
                }
            }
            else
                generatedWords2.Add(word); //adds the unreplaced word to the list
        }

        File.WriteAllText("generated.story2.txt", String.Join(" ", generatedWords2));
    }
}
