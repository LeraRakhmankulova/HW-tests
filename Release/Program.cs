using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace SeleniumTests
{
    class Program
    {
        private static string pathData = @"C:\Users\Valeria\Desktop\HW-tests\TestProject1\Models\";

        //2 comment.xml xml
        static void Main(string[] args)
        {
            var data = Console.ReadLine()?.Split();
            if (data == null) return;
            var dataCount = Convert.ToInt32(data[0]);
            var fileName = pathData + data[1];
            string dataFormat = data[2];
            GenerateComments(dataCount, fileName, dataFormat);
        }

        static void GenerateComments(int count, string filename, string format)
        {
            var comments = new List<string>();
            for (var i = 0; i < count; i++)
            {
                comments.Add(TestBase.GenerateRandomString(10));
            }

            StreamWriter writer = new StreamWriter(filename);
            if (format == "xml")
                WriteToXmlFile(comments, writer);
            else
                Console.Out.Write("Unrecognized format" + format);

            writer.Close();
        }

        static void WriteToXmlFile(List<string> groups, TextWriter writer)
        {
            new XmlSerializer(typeof(List<string>)).Serialize(writer, groups);
        }
    }    
}