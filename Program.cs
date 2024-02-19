using System.Text.Json;
using System.Text.Json.Nodes;

namespace ForEducation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu();

            
        }
        static  void Menu()
        {
            Console.WriteLine(" Quize projectiga xush kelibsiz ");
            Console.Write("1-Savollarga javob berish 2-Savol qo'shish : ");
            string[] questions = new string[7];

            
                
                int choice = Convert.ToInt32(Console.ReadLine());
              
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Savollarga javob bering");

                    AnsverTheQuestion(questions);
                    break;

                case 2:
                    Console.WriteLine("!!!!!!!!!!!");
                    //AddQuestions();
                    Menu();
                    break;
                default:
                    Console.WriteLine("Xato amal");
                    Menu();
                    break;
            }
        }
        static void AnsverTheQuestion(string[] array)
        {
            array[0] = "O'zbekistonning poytaxti ";
            array[1] = "Rossiyaning poytaxti ";
            array[2] = "Angliyaning poytaxti ";
            array[3] = "Fransiyaning poytaxti ";
            array[4] = "Ispaniyaning poytaxti ";
            array[5] = "Saudiya Arabisotnining poytaxti ";
            array[6] = "USA poytaxti ";

            string[] ansvers = new string[array.Length];

            ansvers[0] = "Toshkent";
            ansvers[1] = "Moskva";
            ansvers[2] = "London";
            ansvers[3] = "Parij";
            ansvers[4] = "Madrid";
            ansvers[5] = "Ar-Riyod";
            ansvers[6] = "Vashington";
            int ball = 0;
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                string ans = Console.ReadLine();
                if (ans.ToLower() == ansvers[i].ToLower())
                {
                    Console.WriteLine("To'g'ri");
                    ball++;
                }
                else
                {
                    Console.WriteLine("Xato");
                }
            }
            Console.WriteLine($"Ballingiz {ball}");
            
            
           
        }
        //static void AddQuestions()
        //{

        //}
    }
}
