using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ChallengeSolution
{
    class Program
    {
        public static string ConvertCSVtoJSON()
        {
            // Insert complete file path of the file to be parsed in the following TextFieldParser parameter slot.
            using (var csvReader = new StringReader(File.ReadAllText(@"C:\Users\matth\Desktop\JobHunt\Microgroove\Input2.txt")))
            using (var parser = new NotVisualBasic.FileIO.CsvTextFieldParser(csvReader))
            {
                Batch ThisBatch = new Batch();
                Order ActiveOrder = new Order("","","");
                while (!parser.EndOfData)
                {
                    //Process row
                    string[] fields = parser.ReadFields();
                    if (fields[0] == "F")
                    {
                        ThisBatch.date = fields[1];
                        ThisBatch.type = fields[2];
                    }
                    else if (fields[0] == "E")
                    {
                        int ThisProcess;
                        Int32.TryParse(fields[1], out ThisProcess);
                        int ThisPaid;
                        Int32.TryParse(fields[2], out ThisPaid);
                        int ThisCreated;
                        Int32.TryParse(fields[3], out ThisCreated);
                        ThisBatch.ender = new Ender(ThisProcess, ThisPaid, ThisCreated);
                    }
                    else if (fields[0] == "O")
                    {
                        Order ThisOrder = new Order(fields[1], fields[2], fields[3]);
                        ActiveOrder = ThisOrder;
                    }
                    else if (fields[0] == "B")
                    {
                        Buyer ThisBuyer = new Buyer(fields[1], fields[2], fields[3]);
                        ActiveOrder.buyer = ThisBuyer;
                    }
                    else if (fields[0] == "L")
                    {
                        int ThisQty;
                        Int32.TryParse(fields[2], out ThisQty);
                        Item ThisItem = new Item(fields[1], ThisQty);
                        ActiveOrder.items.Add(ThisItem);
                    }
                    else if (fields[0] == "T")
                    {
                        int ThisStart;
                        Int32.TryParse(fields[1], out ThisStart);
                        int ThisStop;
                        Int32.TryParse(fields[2], out ThisStop);
                        int ThisGap;
                        Int32.TryParse(fields[3], out ThisGap);
                        int ThisOffset;
                        Int32.TryParse(fields[4], out ThisOffset);
                        int ThisPause;
                        Int32.TryParse(fields[5], out ThisPause);
                        ActiveOrder.timings = new Timings(ThisStart, ThisStop, ThisGap, ThisOffset, ThisPause);
                        ThisBatch.orders.Add(ActiveOrder);
                    }
                }
                string json = JsonConvert.SerializeObject(ThisBatch);
                string jsonFormatted = JValue.Parse(json).ToString(Formatting.Indented);
                return jsonFormatted;
            }
        }
        static void Main(string[] args)
        {
            string temp = ConvertCSVtoJSON();
            Console.WriteLine(temp);
        }
    }
}
