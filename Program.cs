/*Benji Stansfield, 04-03-25, Lab 10 "MadLibs 2"*/
Console.Clear();

Dictionary<string, List<string>> words =  new Dictionary<string, List<string>>();

List<string> adjective = new List<string>{"fat", "slimy", "dirty", "gorgeous", "lanky", "withered", "mysterious", "shiny", "goofy"};
List<string> noun = new List<string>{"bear", "sticky-note", "almond", "crayon", "salmon", "orb", "boat", "box", "fire"};
List<string> pluralNoun = new List<string>{"friends", "goats", "sandwiches", "hats", "tires", "almonds", "teeth", "clams", "teachers"};
List<string> pastTenseVerb = new List<string>{"laughed", "choked", "ran", "fought", "fell", "ate", "cramped", "slept", "arrived"};
List<string> verb = new List<string>{"fly", "cook", "destroy", "draw", "claim", "control", "drive", "golf", "wobble"};

words.Add("adjective", adjective);
words.Add("noun", noun);
words.Add("pluralNoun", pluralNoun);
words.Add("pastTenseVerb", pastTenseVerb);
words.Add("verb", verb);

Random rand = new Random();
