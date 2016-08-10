using System;
//using MongoDB.Driver;
//using MongoDB.Bson;
//using System.Collections;
using System.IO;

namespace HelloWorldSample 
{
  
  public static class Program 
  {
    const String testFile = "/data/testfile.txt";
    public static void Main() 
    {
      Console.WriteLine("Hello World!");
      readFile();
      writeFile();
      listMongo();
    }
  public static void readFile() {
      if (File.Exists(testFile)) {
        var fileContent = "";
        using (StreamReader reader = File.OpenText(testFile))
{
	    fileContent = reader.ReadToEnd();
        }
	Console.WriteLine(fileContent);
      }

  }

  public static void writeFile() {
	
	using (StreamWriter logWriter = System.IO.File.CreateText(testFile)) {
	  logWriter.WriteLine("Log message from .net Core");
	}
	
  }

  public static void listMongo() {
    /* FAIL! updated docs needed, not yet available 
    var client = new MongoClient("mongodb://xkxkxkxkxkxZZmongo:21017");
    var mongoDb= client.GetDatabase("test");
    var foos = mongoDb.GetCollection<BsonDocument>("foo");
    var filter = new BsonDocument();
    var result = foos.FindAll().ToList();

    Console.WriteLine(result.Count());
    */

  }
} 
  public class test {
    public String foo { get; set;}
  }

}
