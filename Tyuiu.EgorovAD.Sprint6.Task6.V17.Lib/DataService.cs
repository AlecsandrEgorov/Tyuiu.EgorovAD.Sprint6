using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.EgorovAD.Sprint6.Task6.V17.Lib
{
    public class DataService : ISprint6Task6V17
    {
        public string CollectTextFromFile(string path)
        {

            string fileContent = File.ReadAllText(path);


            return ExtractThirdWords(fileContent);
        }


        private static string ExtractThirdWords(string text)
        {
            using (StringReader reader = new StringReader(text))
            {
                string line;
                string result = "";

                while ((line = reader.ReadLine()) != null)
                {

                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                    if (words.Length >= 3)
                    {
  
                        result += words[2] + " ";
                    }
                }

                return result.Trim();
            }
        }
            
    }
}
