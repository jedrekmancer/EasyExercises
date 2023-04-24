using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSonInputCalculatorWithTxtOutput
{
    internal class Program
    {
        public class JSonObj
        {
            public string Operator { get; set; }
            public string Value1 { get; set; }
            public string Value2 { get; set; }

            public double Result { get; set; }
        }

        static void Main(string[] args)
        {
                string dataFromJSonToString = File.ReadAllText("input.json");
                Dictionary<string, JSonObj> dictionaryWithData = JsonConvert.DeserializeObject<Dictionary<string, JSonObj>>(dataFromJSonToString);

                double firstValue = 0;
                double secondValue = 0;

                foreach (KeyValuePair<string, JSonObj> obj in dictionaryWithData)
                {
                    if (obj.Value.Value2 == null)
                    {
                        firstValue = Convert.ToDouble(obj.Value.Value1);
                        obj.Value.Result = Math.Sqrt(firstValue);
                    }
                    else
                    {
                        firstValue = Convert.ToDouble(obj.Value.Value1);
                        secondValue = Convert.ToDouble(obj.Value.Value2);

                        switch (obj.Value.Operator)
                        {
                            case "add":
                                obj.Value.Result = firstValue + secondValue;
                                break;

                            case "sub":
                                obj.Value.Result = firstValue - secondValue;
                                break;

                            case "mul":
                                obj.Value.Result = firstValue * secondValue;
                                break;
                        }

                    }

                }

                List<KeyValuePair<string, JSonObj>> sortedListFromDictionary = dictionaryWithData.OrderBy(x => x.Value.Result).ToList();
                
                // Displaying results on console is optional

                foreach (KeyValuePair<string, JSonObj> obj in sortedListFromDictionary)
                {
                    Console.WriteLine($"{obj.Key}: {obj.Value.Result}");
                }

                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    foreach (KeyValuePair<string, JSonObj> obj in sortedListFromDictionary)
                    {
                        writer.WriteLine($"{obj.Key}: {obj.Value.Result}");
                    }

                }

                Console.ReadLine();
        }
    }
}
