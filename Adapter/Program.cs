using Adapter.Interface;
using Adapter.Adapters;

namespace Adapter;

class Program // Client code
{
    static void Main(string[] args)
    {
        String someXml = @"<?xml version='1.0' encoding='UTF-8' standalone='yes'?>
                    <note>
                        <to>John</to>
                        <from>Jane</from>
                        <heading>Reminder</heading>
                        <body>Remember to pick me up at work!</body>
                    </note>";

        IJsonParser<Note> jsonParser = new XmlToJsonAdapter<Note>();
        Note note = jsonParser.Parse(someXml);
        Console.WriteLine(jsonParser.ConvertToJson(note));
    }
}