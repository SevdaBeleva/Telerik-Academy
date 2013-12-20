using System;
using System.Text;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

public class Word
{
    public ObjectId Id { get; set; }

    public string name { get; set; }

    public string translation { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        MongoClient client = new MongoClient("mongodb://localhost/");
        MongoServer server = client.GetServer();
        var dictionaryDB = server.GetDatabase("dictionary");
        var wordCollection = dictionaryDB.GetCollection<Word>("words");
        var wordCollectionQueery = wordCollection.AsQueryable();

       // AddWord(wordCollection, "white", "colour");
    }

    private static void AddWord(MongoCollection<Word> wordCollection, string word, string translation)
    {
        Word newWord = new Word()
        {
            name = word,
            translation = translation
        };

        wordCollection.Insert(newWord);
    }

    private static void FindWord(IQueryable<Word> wordCollection)
    {
        Console.Write("Enter a word: ");
        var searchWord = Console.ReadLine();

        var word = wordCollection.Where(w => w.name == searchWord).ToList();

        foreach (Word item in word)
        {
            Console.WriteLine("translation: " + item.translation);
        }
    }

    private static void LisCollection(IQueryable<Word> wordCollection)
    {
        var words = wordCollection.ToList();
        StringBuilder sb = new StringBuilder();

        foreach (Word item in words)
        {
            sb.Append(item.name + ": " + item.translation);
            sb.Append("\n");
        }

        Console.WriteLine(sb);
    }  
}