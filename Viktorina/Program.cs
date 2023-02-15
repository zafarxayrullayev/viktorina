using Classes;

namespace Viktorina
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Topics topics = new Topics();
            Questions questions = new Questions();

            string userAnswer = "";

            string[] answerDataTypes = {"a", "c"};  
            string[] answerArray = {"a", "b"};

            Console.WriteLine("Assalomu alaykum, kerakli mavzuni tanlang");

            topics.showTopics();

            int topicChoose = Convert.ToInt32(Console.ReadLine());

            

            string[,] optionDataTypes = { 
                { "a) <dataType>.MinValue", "b) .MinValue", "c).MaxValue" }, 
                { "a) <dataType>.MinValue", "b) .MinValue", "c) <dataType>.MaxValue" } 
            };

            string[,] optionArray = { 
                {   
                    "a) Bir xil tipdagi elementlar to'plami", 
                    "b) string tipidagi elementlar to'plami", 
                    "c) Elementlar to'plami" 
                },
                {   "a) 1 dan", "b) 0 dan", "c) -1 dan" } };

            
            switch (topicChoose)
            {
                case 1:
                    Console.WriteLine("Data types mavzusini tanladingiz!");
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine($"{i + 1}-savol;\n{questions.questionsDataTypes[i]}");
                        for (int j = i; j < i + 1; j++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                Console.WriteLine(optionDataTypes[j,k]);
                            }
                            Console.Write("Javob: ");
                            userAnswer = Console.ReadLine();
                            if (answerDataTypes[j] == userAnswer)
                            {
                                Console.WriteLine("To'gri javob, tabriklaymiz!");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Xato javob, afus!");
                                Console.WriteLine();
                            }

                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Array mavzusini tanladingiz!");
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine($"{i + 1}-savol;\n{questions.questionsArray[i]}");
                        for (int j = i; j < i + 1; j++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                Console.WriteLine(optionArray[j, k]);
                            }
                            Console.Write("Javob: ");
                            userAnswer = Console.ReadLine();
                            if (answerArray[j] == userAnswer)
                            {
                                Console.WriteLine("To'gri javob, tabriklaymiz!");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Xato javob, afus!");
                                Console.WriteLine();
                            }

                        }
                    }
                    break;

                default:
                    break;
            }




        }
    }
}