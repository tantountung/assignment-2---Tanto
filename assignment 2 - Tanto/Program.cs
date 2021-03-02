using System;
using System.Text;

namespace assignment_2___Tanto
{
    class Program
    {
        static Random rg = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Player!");
            Console.WriteLine("");
            Console.WriteLine("Welcome to Hangman!\n\nThe word is about name of food");
            Console.WriteLine("");
            typeGuess();
            Console.WriteLine("");
            Console.ReadKey();
        }
        static void typeGuess()
        {
            Console.WriteLine("If you want to guess the word (only 1 chance), please type 'W' \nor type any key if you want to guess per letter (You have 10 chances)\nGood luck!");
            var userChoice = Console.ReadLine();
            userChoice = userChoice.ToUpper();

            if (userChoice == "W")
            {
                Console.WriteLine("");
                Words();
            }
            else
            {
                Console.WriteLine("");
                GuessLetter();
            }
        }
        static void Words()
        {
            string[] wds = { "pasta", "balls", "soppa", "pizza", "glass", "penne", "sukiyaki" };
            string chosenWord = wds[rg.Next(wds.Length)];

            char[] dashWords = new char[chosenWord.Length];//count the string to integer, thats why in for, use int
            for (int i = 0; i < dashWords.Length; i++)//dont forget ;, stupid Tanto......, 2 hours sighh....
            {
                dashWords[i] = '_';
            }

            //string firstLetter = chosenWords.Substring(1);
            //string dashLetter = firstLetter.Replace("*", "_");
            //string secLetter = chosenWords.Substring(2).Replace("[a-z]", "_");
            //string thirdLetter = chosenWords.Substring(3).Replace("[a-z]", "_");
            //string fourthLetter = chosenWords.Substring(4).Replace("[a-z]", "_");
            //string fifthLetter = chosenWords.Substring(5).Replace("[a-z]", "_");
            //StringBuilder strB = new StringBuilder(chosenWords);
            //strB[0] = _;

            Console.WriteLine(dashWords);


            Console.WriteLine("Please enter your guess: ");
            var userGuwo = Console.ReadLine();
            userGuwo = userGuwo.ToLower();



            if (userGuwo == chosenWord)
            {
                Console.WriteLine("");
                Console.WriteLine("You win!!");

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Bad guess, you lose :(");
                Console.WriteLine("");

            }


            Console.WriteLine("The answer is:" + chosenWord);
        }


        static void GuessLetter()

        {
            string[] wds = { "pasta", "balls", "soppa", "pizza", "glass", "penne", "sukiyaki" };
            string chosenWord = wds[rg.Next(wds.Length)];

            char[] dashWords = new char[chosenWord.Length];//count the string to integer, thats why in for, use int
            for (int i = 0; i < dashWords.Length; i++)//dont forget ;, stupid Tanto......, 2 hours sighh....
            {
                dashWords[i] = '-';
            }
            string str = new string(dashWords);

            Console.WriteLine(str);
            

            // StringBuilder (bikin disini buat menan=pung incorrect letter, yg dibutuhkan hanya letters, kalo words, sekali tembak, atau mati)
            //   konsep boxes, yg dalam diproses dulu, baru yg luar, tapi yg luar tetep menampunghasil yg dalam
            //  for loop, i++, di offset dengan i--, tinggal mainkan for loop
            //yg terkahri adalah soal wild card buat character, user input adalah wild card nya,
            // jadi kalo if -1, ga ada yg di index of chosen WOrd, tapi kalo +1, tru, pakai indexOFfunction

            StringBuilder incorrectGuess = new StringBuilder();
           
            

            //StringBuilder newDashword = new StringBuilde

            int count = 10;
            for (int i = 0; i < count; i++)
            {

                Console.WriteLine("Please enter your guess: ");
                char userGule = Console.ReadKey(false).KeyChar;
                userGule = char.ToLower(userGule);


                if (incorrectGuess.ToString().Contains(userGule))
                {
                    Console.WriteLine("Repeating guess.");
                    i--;
                }
                else
                {
                    
                    
                    bool at = chosenWord.Contains(userGule);
                    
                    //sekarang index of dulu(done, pake contains), lalu logika -1(done, contains use true false, notnumber -1), 
                    //dan lalu replace dash, dan logika sumbang darah i-- utk tenakan yg sama (done), alu win stop the circle,



                    if (at)
                    {
                        Console.WriteLine("");

                        for (int x = 0; x < chosenWord.Length; i++)
                        {
                            if (chosenWord[x] == userGule)
                            {
                                dashWords[x] = chosenWord[x];
                            }
                        }
                        str = new string(dashWords);
                        Console.WriteLine(str);
                        Console.WriteLine("Good guess! Keep going!");

                        if (str == chosenWord)
                        {
                            
                            Console.WriteLine("Congrats, you won!!");
                            i = 0;
                            break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Bad guess, try again. :(");
                        Console.WriteLine("");
                        



                        //StringBuilder userGuwoall = new StringBuilder(userGuwo);

                        //stuck in adding stringbuilder accumulative,  and to exclude repeating guess into for loop
                    }
                    incorrectGuess.Append(userGule).Append(", ");
                    Console.WriteLine("Already guessed:" + incorrectGuess.ToString());
                    Console.WriteLine("");
                }




            }
            Console.WriteLine("The answer is:" + chosenWord);
        }
    }


}
