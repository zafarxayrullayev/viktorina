using Classes;

namespace Viktorina
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Topics topics = new Topics(); // mavzular
            Questions questions = new Questions(); // savollar
            Variants variants = new Variants(); // variantlar
            Methods methods = new Methods(); // methodlar, qaytarilgan methodlarni alohida bitta classga joyladim, nomini nima deb nomlashni bilmasdan 'Methods' deb qo'ya qoldim.
            Answers answers = new Answers(); // javoblar

            string userAnswer = ""; // foydalanuvchi kiritadigan javob

            

            Console.WriteLine("Assalomu alaykum, kerakli mavzuni tanlang\nKichik eslatma!! Javoblar uchun 'a', 'b', 'c' belgilarni kiriting.");

            topics.showTopics(); // mavzularni ko'rsatish

            int topicChoose = Convert.ToInt32(Console.ReadLine()); 

            switch (topicChoose)
            {
                case 1:
                    Console.WriteLine("Data types mavzusini tanladingiz!");
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine($"{i + 1}-savol;\n{questions.questionsDataTypes[i]}"); // i-savol chiqadi
                        for (int j = i; j < i + 1; j++)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                Console.WriteLine(variants.optionDataTypes[j,k]); // i-savol variantlari chiqadi
                            }
                            abs:
                            Console.Write("Javob: ");
                            userAnswer = Console.ReadLine(); //

                            if (userAnswer != "a" && userAnswer != "b" && userAnswer != "c")
                            {
                                Console.WriteLine($"Siz 'a', 'b', 'c' belgilarni kiritmadingiz! Qayta kiritishingizni so'raymiz");
                                goto abs;
                            }
                            methods.CheckAndCount(answers.answerDataTypes, userAnswer, j); // check method, berilgan javob tekshirilayapti

                        }
                    }
                    Console.WriteLine($"{methods.Count} ta savolga to'g'ri javob berdingiz!");
                    break;
                case 2:
                    Console.WriteLine("Array mavzusini tanladingiz!");
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine($"{i + 1}-savol;\n{questions.questionsArray[i]}"); // i-savol chiqadi
                        for (int j = i; j < i + 1; j++) 
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                Console.WriteLine(variants.optionArray[j, k]);
                            }
                            Console.Write("Javob: ");
                            userAnswer = Console.ReadLine();
                           
                            methods.CheckAndCount(answers.answerArray, userAnswer, j); // check method, berilgan javob tekshirilayapti
                        }
                    }
                    Console.WriteLine($"{methods.Count} ta savolga to'g'ri javob berdingiz!");
                    break;
                default:
                    break;
            }
        }
    }
}