namespace Classes
{
    public class Topics
    {
        public string[] topics = { "Array", "Data types" };

        public void showTopics()
        {
            for (int i = 0; i < topics.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {topics[i]}");
            }
        }
    }
}