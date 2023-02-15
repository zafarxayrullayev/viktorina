namespace Viktorina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] topics = {"Array", "Data types"};


            Console.WriteLine("Assalomu alaykum, kerakli mavzuni tanlang");
            Console.WriteLine("1.Data types\n2.Array");

            int topicChoose = Convert.ToInt32(Console.ReadLine());

            string[] questionsDataTypes = {
                "Tiplarning minimum qiymati qanday ko'riladi?",
                "Tiplarning maximum qiymati qanday ko'riladi?" };

            string[] questionsArray = {
                "Array nima?",
                "Array indeksi nechchidan boshlanadi?" };

            string[,] answersDataTypes = { 
                { "a) <dataType>.MinValue", "b) .MinValue", "c).MaxValue" }, 
                { "a) <dataType>.MinValue", "b) .MinValue", "c) <dataType>.MaxValue" } 
            };
            
            string[,] answersArray = { 
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
                    for (int i = 0; i < questionsDataTypes.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}-savol;\n{questionsDataTypes[i]}");
                        for (int j = i; j <= j; j++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                Console.WriteLine(answersDataTypes[j,k]);
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