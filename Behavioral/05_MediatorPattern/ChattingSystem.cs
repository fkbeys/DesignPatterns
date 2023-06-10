namespace _05_MediatorPattern
{
    public interface IChatRoom
    {
        void Register(User user);
        void SendMessage(string from, string to, string message);
    }
    public abstract class User
    {
        public string name { get; private set; }
        public IChatRoom chatRoom { get; set; }

        public User(string name)
        {
            this.name = name;
        }

        public void Send(string to, string message)
        {
            chatRoom.SendMessage(name, to, message);
        }

        public abstract void RecieveMessage(string from, string message);

    }

    public class ChatRoom : IChatRoom
    {
        //Dictionary<string, User> userlist = new();
        List<User> userlist = new();
        public void Register(User user)
        {
            if (!userlist.Contains(user))
            {
                userlist.Add(user);
                user.chatRoom = this;
            }

        }

        public void SendMessage(string from, string to, string message)
        {
            if (userlist.Any(x => x.name == from) && userlist.Any(x => x.name == to))
            {
                User? recepientUser = userlist.FirstOrDefault(x => x.name == to);
                recepientUser?.RecieveMessage(from, message);
            }
        }
    }

    public class Participant : User
    {
        public Participant(string name) : base(name)
        {

        }
        public override void RecieveMessage(string from, string message)
        {
            Console.WriteLine($"From:{from}, To:{name}, Message:{message} ");
        }
    }



}
