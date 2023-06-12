namespace _05_MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IChatRoom room = new ChatRoom();
            User mark=new Participant("Mark");
            User frank=new Participant("Frank");
            User george=new Participant("George");

            room.Register(mark);
            room.Register(frank);
            room.Register(george);

            room.SendMessage(mark.name, frank.name, "Mark sent message to frank");




            Console.ReadLine();
        }
    }
}