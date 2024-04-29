using System.Text;
using Builder.Entities;
using static Builder.Entities.User;

namespace Builder;

internal class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;

        bool hasContents(string name, string email)
        {
            return !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(email);
        }

        List<User> userList = new();
        while (isRunning)
        {
            try
            {
                Console.WriteLine("Press 1 to create a user, and 2 for userlist");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                    idPrompt:
                        Console.WriteLine("Enter an id:");
                        int id = int.Parse(Console.ReadLine());

                        if (userList.Any(user => user.Id == id))
                        {
                            Console.WriteLine("That id already exist. Try a new one");
                            goto idPrompt;
                        }

                        Console.WriteLine("Enter a name:");
                        string? name = Console.ReadLine();
                        Console.WriteLine("Enter an email:");
                        string? email = Console.ReadLine();

                        if (hasContents(name, email))
                        {
                            User user = new UserBuilder()
                            .setId(id)
                            .setName(name)
                            .setEmail(email)
                            .Build();

                            userList.Add(user);
                            Console.WriteLine($"User: {user.Name} has been created!");
                        }

                        else
                        {
                            Console.WriteLine("None of the fields can be empty!");
                        }

                        break;


                    case 2:
                        if (userList.Any())
                        {
                            StringBuilder dataBuilder = new StringBuilder();
                            foreach (User user in userList)
                            {
                                dataBuilder.Append($"Id: {user.Id}\nName: {user.Name}\nEmail: {user.Email}\n{user.Gender}\n--------\n");
                            }

                            Console.WriteLine(dataBuilder);
                        }

                        else
                        {
                            Console.WriteLine("There are no registered users!");
                        }

                        break;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
        }
    }
}