using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace List_Enum_OEF
{
    
    internal class Program

    {
        public enum CardType
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs,

        }


        public enum CardSymbol
        {
            None,
            Ace =1,
            Jack=11,
            Queen=12,
            King=13,
        }
        
        
        public enum CardinalDirections
        {
            North,
            East,
            South,
            West,
            None,

        }
        public enum Languages
        {
            Dutch,
            French, 
            English

        }
        
        public enum RainbowColors
        {
            red=1,
            orange=2,
            yellow,
            green,
            blue,
            indigo,
            violet,

        }
        public enum TempertureFeeling
        {
            Hot=30,
            Warm,
            Cold=15
        }

        static void Main(string[] args)
        {


            List<int>list = new List<int> {1,2,3 };
            list.Contains(2);
            //is de element aanwezig in de list (True, False antwoord)
            list.IndexOf(3);
            //plaats van ingevoerde cijfer in de lijst
            list.Insert(2, 254);
            //1ste cijfer positie, 2de cijfer getal in lijst invoegen

            Random randomGen = new Random();


            ////OEF les 

            //List<int> missions = new List<int>();

            //missions.Add(0);
            //missions.Add(1);
            //missions.Add(2);

            //Console.WriteLine(missions[2]);

            ////OEF 1 & 2 & 3

            //List<string> myCards= CardsInDeckShuffled();
            //string inputUser;
            //int programStilRunning= 2;

            //string cardDrawn = "Nothing to Remove anymore";
            //do
            //{

            //    Console.WriteLine("Press Enter to hit another Card");
            //    Console.WriteLine("Type fold to fold and end the application");

            //    inputUser = Console.ReadLine().ToLower();


            //    if (inputUser == string.Empty)
            //    {
            //        cardDrawn = myCards[randomGen.Next(0, myCards.Count)];
            //        Console.WriteLine(cardDrawn);
            //        programStilRunning = 1;

            //    }
            //    if (inputUser == "fold")
            //    {
            //        programStilRunning = 0;
            //    }

            //    myCards.Remove(cardDrawn);
            //    if(myCards.Count <= 0) 
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("We need to reset the deck you have drawn every card");
            //        Console.WriteLine();
            //        myCards = CardsInDeckShuffled();

            //    }
            //}while (programStilRunning!=0);


            ////OEF 5

            //List<string> myCards = CardsInDeckShuffled();
            //string inputUser;
            //int programStilRunning = 2;
            //int result = 0;
            //int value = 0;
            //string cardDrawn = "Nothing to Remove anymore";
            //do
            //{

            //    Console.WriteLine("Press Enter to hit another Card");
            //    Console.WriteLine("Type fold to fold and end the application");

            //    inputUser = Console.ReadLine().ToLower();


            //    if (inputUser == string.Empty)
            //    {
            //        cardDrawn = myCards[randomGen.Next(0, myCards.Count)];
            //        Console.WriteLine(cardDrawn);
            //        BlackJack(cardDrawn, out value);
            //        programStilRunning = 1;
            //        result += value;
            //        Console.WriteLine("You have {0} points if you get 21 you win!{1}", result, value);
            //        if (result == 21)
            //        {
            //            Console.WriteLine("NICE YOU WON");
            //            result = 0;
            //        }
            //    }
            //    if (inputUser == "fold" || result > 21)
            //    {
            //        Console.WriteLine("You lost still want to play? press Enter");
            //        inputUser = Console.ReadLine().ToLower();
            //        result = 0;
            //        if (inputUser == string.Empty)
            //        {
            //            programStilRunning = 1;
            //        }
            //        else
            //        {
            //            programStilRunning = 0;
            //        }
            //    }

            //    myCards.Remove(cardDrawn);
            //    if (myCards.Count <= 0 || inputUser == "yes")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("We need to reset the deck you have drawn every card");
            //        Console.WriteLine();
            //        myCards = CardsInDeckShuffled();

            //    }
            //} while (programStilRunning != 0);


            ////OEF 6

            //List<int > integersSaved = new List<int>();
            //int amountOfNumbers = 20;

            //for (int i = 0; i < amountOfNumbers; i++)
            //{
            //    Console.WriteLine("Give me {0} number", amountOfNumbers);
            //    int.TryParse(Console.ReadLine(), out int inputUser);
            //    integersSaved.Add(inputUser);


            //}            
            //for(int i = integersSaved.Count; i> 0; i--)
            //{
            //    Console.WriteLine(integersSaved[i-1]);
            //}

            ////OEF 7 

            //List<int> integersPutIn = new List<int>();

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Give me a number");
            //    integersPutIn.Add(int.Parse(Console.ReadLine()));

            //}
            //Console.WriteLine("Which number do you wanna see");
            //int.TryParse(Console.ReadLine(), out int j);
            //Console.WriteLine(integersPutIn[j-1]);



            ////OEF 8 

            //string inputUser;
            //bool parseSucceeded;
            //List<int> list = new List<int>();
            //do
            //{
            //    Console.WriteLine("Give me number if you don't want to type 'stopt' ");
            //    inputUser = Console.ReadLine().ToLower();
            //    parseSucceeded = int.TryParse(inputUser, out int result);
            //    if (parseSucceeded)
            //    {

            //        list.Add(result);






            //    }
            //    else
            //    {
            //        if (inputUser == "stopt")
            //        {
            //            Console.WriteLine("You typed stop the application will close");
            //        }
            //        else
            //        {
            //            Console.WriteLine("You put in some wrong input try again");
            //        }
            //    }



            //} while (inputUser != "stop");

            //for (int i = 0; i < list.Count; i++)
            //{
            //    list.Sort();
            //    list.Reverse();

            //    int isListModul2 = list[i];
            //    isListModul2 %= 2;
            //    if (isListModul2 == 0)
            //    {
            //        Console.WriteLine(list[i]);
            //    }

            //}

            ////OEF 10 gwn  reverse na sort zetten

            ////OEF 9
            //List<string> namesStudent = new List<string>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Give me a name");

            //    namesStudent.Add(Console.ReadLine());

            //}
            //namesStudent.Sort();
            //for (int i = 0; i < namesStudent.Count; i++)
            //{
            //    Console.WriteLine(namesStudent[i]);

            //}


            ////OEF 11
            //List<int> intSum = new List<int>();

            //int sumOfList = 0;
            //int userInputNumber;

            //bool programStillRunning= true;

            //do
            //{
            //    Console.WriteLine("Give me a number.");
            //    int.TryParse(Console.ReadLine(), out userInputNumber);
            //    intSum.Add(userInputNumber);
            //    sumOfList += intSum[intSum.Count-1];
            //    Console.WriteLine("The sum right now is {0}", sumOfList);

            //    Console.WriteLine();
            //    Console.WriteLine("Press a to put another number in");
            //    Console.WriteLine("Press b to start all over again");
            //    Console.WriteLine("Press c to end the program");
            //    string userInputChoice = Console.ReadLine().ToLower();
            //    switch (userInputChoice)
            //    {
            //        case "a":



            //            programStillRunning = true;
            //            break;


            //        case "b":
            //            Console.WriteLine("The sum has been reset");
            //            sumOfList = 0;
            //            programStillRunning =true;
            //            break;


            //        case "c":
            //            Console.WriteLine("You will exit the application, the sum total is {0}", sumOfList);

            //            foreach(int i in intSum)
            //            {
            //                Console.WriteLine(i);
            //            }
            //            Console.ReadKey();

            //            programStillRunning =false;
            //            break;

            //    }




            //} while (programStillRunning);

            ////OEF 12
            //List <int> listShuffle = new List<int> { 1,2,3,4,5,6,7,8,9,10};

            //foreach (int i in listShuffle)
            //{
            //    Console.WriteLine(i);
            //}
            //int x = listShuffle[0];
            //for(int i = 0; i < listShuffle.Count-1; i++)
            //{

            //    listShuffle[i] = listShuffle[i+1];
            //}
            //listShuffle[listShuffle.Count-1] = x;

            //foreach (int i in listShuffle)
            //{
            //    Console.WriteLine(i);
            //}

            ////to the right 

            //int y = listShuffle[listShuffle.Count - 1];
            //for(int i = listShuffle.Count-1; i > 0; i--)
            //{
            //    listShuffle[i] = listShuffle[i - 1];

            //}
            //listShuffle[0] = y;

            ////OEF 13
            //List<string> list = new List<string> {"Cirlce", "Triangle", "Rectangle", "Square" };

            //for(int i = 0; i < list.Count; i++)
            //{
            //    switch(list[i])
            //    {
            //        case "Cirlce":
            //            Console.WriteLine("Ik");
            //            break;
            //        case "Triangle":
            //            Console.WriteLine("Jij");
            //            break;
            //        case "Rectangle":
            //            Console.WriteLine("Hij");
            //            break;
            //        case "Square":
            //            Console.WriteLine("Zij");
            //            break;
            //    }
            //}

            ////OEF 14
            //int inputCardinalDegrees;
            //string inputUser;
            //Random randomGenerator = new Random();
            //CardinalDirections direction;
            //do 
            //{

            //    Console.WriteLine("Write stop if you don't want to partake.");
            //    inputUser = Console.ReadLine();
            //    inputCardinalDegrees = randomGen.Next(0, 361);

            //    if(inputCardinalDegrees<=45 || inputCardinalDegrees >315)
            //    {
            //        direction = CardinalDirections.North;
            //    }
            //    if (inputCardinalDegrees > 45 && inputCardinalDegrees <= 135)
            //    {
            //        direction = CardinalDirections.East;
            //    }
            //    if (inputCardinalDegrees > 135 && inputCardinalDegrees <= 225)
            //    {
            //        direction = CardinalDirections.South;
            //    }
            //    if (inputCardinalDegrees > 225 && inputCardinalDegrees <= 315)
            //    {
            //        direction = CardinalDirections.West;
            //    }
            //    else
            //    {
            //        direction= CardinalDirections.None;
            //    }

            //    Console.WriteLine("Cardinal direction with degrees {0} is {1}",inputCardinalDegrees,direction.ToString());


            //} while (inputUser!="stop");


            ////OEF 15
            //List<string> listNames = new List<string>();
            //Console.WriteLine("Give me 5 names");
            //listNames.Add(Console.ReadLine());
            //listNames.Add(Console.ReadLine());
            //listNames.Add(Console.ReadLine());
            //listNames.Add(Console.ReadLine());
            //listNames.Add(Console.ReadLine());


            //Console.ReadKey();

            ////OEF 16
            //string inputString;
            //List <string> studentNames= new List<string>();
            //do
            //{
            //    Console.WriteLine("Give me a name if you want to exit type stop");
            //    inputString = Console.ReadLine();
            //    if(inputString == "stop")
            //    {

            //    }
            //    else
            //    {
            //        studentNames.Add(inputString);

            //    }




            //} while (inputString != "stop");


            //for(int i = 0; i < studentNames.Count; i++)
            //{
            //    Console.WriteLine(studentNames[i]);
            //}
            //Console.WriteLine();    



            ////OEF 17

            //string inputString;
            //List<string> studentNames = new List<string>();
            //do
            //{
            //    Console.WriteLine("Give me a name if you want to exit type stop");
            //    inputString = Console.ReadLine();
            //    if (inputString == "stop")
            //    {

            //    }
            //    else
            //    {
            //        studentNames.Add(inputString);

            //    }




            //} while (inputString != "stop");

            //Console.WriteLine("Which name do you want to remove");

            //inputString = Console.ReadLine().ToLower();
            //studentNames.Remove(inputString);


            //for (int i = 0; i < studentNames.Count; i++)
            //{
            //    Console.WriteLine(studentNames[i]);
            //}
            //Console.WriteLine();


            //OEF 18
            Random rnd = new Random();
            Languages languages;
            int randomLanguage = rnd.Next(0, 3);

            switch (randomLanguage)
            {
                case 0:

                    Console.WriteLine((Languages)randomLanguage + "Goededag");
                    break;
                case 1:

                    Console.WriteLine((Languages)randomLanguage + "Bonjour");
                    break;
                case 2:
                    Console.WriteLine((Languages)randomLanguage + "Hello");
                    break;

            }

            Console.WriteLine((Languages)0);
            Console.WriteLine((int)Languages.Dutch);
            Enum.TryParse("Dutch", out Languages result);

            Console.ReadKey();

            //OEF 19

            //RainbowColors color;
            //Console.WriteLine("Give me a color of the rainbow");
            //string colourInput = Console.ReadLine().ToLower();


            //bool parseSucceeded =Enum.TryParse(colourInput, out color);


            //if (!parseSucceeded)
            //{
            //    Console.WriteLine("This is not a color part of a rainbow");
            //}
            //else
            //{
            //    Console.WriteLine("This is the {0}th color of the rainbow", (int)color);
            //}

            ////OEF 20

            //TempertureFeeling temperture;
            //Random rnd = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    int temp = rnd.Next(0, 41);


            //    if (temp < (int)TempertureFeeling.Cold)
            //    {
            //        temperture = TempertureFeeling.Cold;

            //    }
            //    else
            //    {
            //        if (temp > (int)TempertureFeeling.Hot)
            //        {
            //            temperture = TempertureFeeling.Hot;

            //        }
            //        else
            //        {
            //            temperture = TempertureFeeling.Warm;

            //        }
            //    }
            //    Console.WriteLine("its {0} degrees " + temperture, temp);
            //}
            //Console.ReadKey();

        }
        /* OEF 1 ZONDER ENUM
        static List<string> CardsInDeck()
        {
            List <string> cardTypes = new List<string> {"H","K","S","R" };

            List <string> cardNumber = new List<string>();
            int amountCardsInStack = 13;
            foreach(string cardType in cardTypes)
            {
                for (int i = 1; i <= amountCardsInStack; i++)
                { 
                    cardNumber.Add(cardType + i) ; 
                }
                
            }


            return cardNumber;
        }
        */


        //OEF 3-> OEF 1 WITH ENUMS
        static List<string> CardsInDeck()
        {

            CardType cardType;
            int amountCardType = 4;
            int amountCardsPerSuit = 13;
            List<string> cards = new List<string>();
            CardSymbol cardSymbol;
            
            for (int i = 1; i <= amountCardsPerSuit; i++)
            {
                for (int j = 0; j < amountCardType; j++)
                {
                    cardType = (CardType)j;
                    switch (i)
                    {
                        case 1:
                            cardSymbol = (CardSymbol)i;
                            break;

                        case 11:
                            cardSymbol= CardSymbol.Jack;
                            break;
                        case 12:
                            cardSymbol = CardSymbol.Queen;
                            break;
                        case 13:
                            cardSymbol = (CardSymbol)i;
                            break;


                            default:
                            cardSymbol = CardSymbol.None;
                            break;
                        
                    }
                    string cardNumber = i.ToString();
                    if (cardSymbol != CardSymbol.None)
                    {
                        cardNumber = cardSymbol.ToString();
                    }
                    
                    cards.Add(cardType + " " + cardNumber);
                    

                }


            }
            cards.Sort();
            return cards;
        }


        //OEF 4 -> OEF 1 met shuffled deck
        static List<string> CardsInDeckShuffled()
        {
            List<string> cards = CardsInDeck();
            List<string> shuffledCards = new List<string>();

            Random randomGenerator = new Random();

            int amountInDeck = 52;
            int totalAmountInDeck = 52;
            for (int i = 0; i < totalAmountInDeck; i++)
            {

                int randomCardDeck = randomGenerator.Next(0, amountInDeck);
                shuffledCards.Add(cards[randomCardDeck]);
                cards.Remove(cards[randomCardDeck]);
                amountInDeck--;


            }



            return shuffledCards;
        }

        static void BlackJack(string cardDrawn, out int value)
        {
            
            string valueInString;

            valueInString = cardDrawn.Substring(cardDrawn.IndexOf(' ') + 1);
            

            if(int.TryParse(valueInString, out value))
            {
                
            }
            else
            {
                switch(valueInString)
                {
                    case "Jack":
                    case "Queen":
                    case "King":
                        value = 10;
                        break;

                    case "Ace":
                        value = 1;
                        break;
                }

            }
            
           
            

        }
        



    }
}
