using Classes;

namespace Viktorina
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Topics topics = new Topics();
            Questions questions = new Questions();
            Variants answers = new Variants();
            Methods methods = new Methods();

            string userAnswer = "";

            string[] answerDataTypes = {"a", "c"};  
            string[] answerArray = {"a", "b"};

            Console.WriteLine("Assalomu alaykum, kerakli mavzuni tanlang");

            topics.showTopics();

            int topicChoose = Convert.ToInt32(Console.ReadLine());

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
                                Console.WriteLine(answers.optionDataTypes[j,k]);
                            }
                            Console.Write("Javob: ");
                            userAnswer = Console.ReadLine();
                            
                            methods.Check(answerDataTypes, userAnswer, j); // check method

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
                                Console.WriteLine(answers.optionArray[j, k]);
                            }
                            Console.Write("Javob: ");
                            userAnswer = Console.ReadLine();
                           
                            methods.Check(answerArray, userAnswer, j); // check method


                        }
                    }
                    break;

                default:
                    break;
            }




        }
    }
}