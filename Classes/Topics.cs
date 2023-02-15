namespace Classes
{
    public class Topics
    {
        public string[] topics = { "Data types", "Array" };

        public void showTopics()
        {
            for (int i = 0; i < topics.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {topics[i]}");
            }
        }
    }
}