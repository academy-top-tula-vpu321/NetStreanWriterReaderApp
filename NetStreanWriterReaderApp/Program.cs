string fileName = "file01.txt";
string text = "The following example uses an instance of StreamReader to read text from a file. The constructor used in this example is not supported for use in Windows Store Apps.";

//using(StreamWriter writer = new(fileName))
//{
//    writer.WriteLine(text);
//}

//using (StreamWriter writer = new(fileName, true))
//{
//    writer.WriteLine(text);
//}

using(StreamReader reader = new StreamReader(fileName))
{
    //string textFull = reader.ReadToEnd();
    //Console.WriteLine(textFull);

    string line;
    while((line = reader.ReadLine()) is not null)
        Console.WriteLine(line);
}