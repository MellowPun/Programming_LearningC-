using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProefExamen
{
    internal class Program
    {
        static string firstName = "Ayoub";
        static string secondName = "Achoukhi";
        static string fileName = firstName + ".json";
        static void Main(string[] args)
        {
            
            PixelArt pixelArt = new PixelArt(firstName + " "+ secondName,secondName.Length,firstName.Length);

            
            string inputUser;
            do
            {
                Console.WriteLine("A. Create, B. Show, C. Save, D. Load, E. Quit");
                 inputUser = Console.ReadLine().ToLower();

                switch(inputUser)
                {
                    case "a":
                        Console.WriteLine("Creating new pixelart" );
                        pixelArt = new PixelArt(firstName + " " + secondName, secondName.Length, firstName.Length);

                        break;
                    case "b":
                        Console.WriteLine(pixelArt);
                        pixelArt.DrawPixelArt();

                        break;
                    case "c":
                        SaveJSON(pixelArt);
                        break;
                    case "d":
                        LoadJSON(out pixelArt);
                        
                        
                        break;
                }


            } while(inputUser != "e");
            

        }
        static void SaveJSON(PixelArt pixelArt)
        {
            Console.WriteLine("Saving current pixelart to {0}", fileName);
            string saveJson = JsonConvert.SerializeObject(pixelArt);
            File.WriteAllText(fileName, saveJson);

        }
        static void LoadJSON(out PixelArt pPixelArt)
        {
            Console.WriteLine("Loading pixelart from {0}", fileName);
            string loadJson = File.ReadAllText(fileName);
            pPixelArt = JsonConvert.DeserializeObject<PixelArt>(loadJson);

        }
    }
}
