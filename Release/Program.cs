using Newtonsoft.Json;
using SeleniumTests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace XmlGenerator
{
    class Program
    {
        private static string pathData = @"C:\Users\Valeria\Desktop\HW-tests\TestProject1\Data\";

        //2 comments.xml xml
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
            var comments = new List<CommentData>();
            for (var i = 0; i < count; i++)
            {
                comments.Add(new CommentData(GenerateRandomString(10)));
            }

            StreamWriter writer = new StreamWriter(filename);
            if (format == "xml")
                WriteToXmlFile(comments, writer);
            else
                Console.Out.Write("Unrecognized format" + format);

            writer.Close();
        }
        public static string GenerateRandomString(int max)
        {
            Random rnd = new Random();
            int rndValue = Convert.ToInt32(rnd.NextDouble() * max);
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i <= rndValue; i++)
            {
                builder.Append(Convert.ToChar(32 + Convert.ToInt32(rnd.NextDouble() * 65)));

            }
            return builder.ToString();
        }

        static void WriteToXmlFile(List<CommentData> comments, TextWriter writer)
        {
            new XmlSerializer(typeof(List<CommentData>)).Serialize(writer, comments);
        }
    }    
}