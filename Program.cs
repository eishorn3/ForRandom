namespace ForRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello... Who is there?\n");
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("\n");

            //for stuff
            Console.WriteLine($"Feed me master {userName}!\n");
            int value;
            int[] userNumbers = new int[10];
            bool execute = true;


            for (int counter = 0; counter <= userNumbers.Length - 1;)
            {

                while (execute)
                {
                    string number = Console.ReadLine();
                    bool numbRes = int.TryParse(number, out value);


                    if (!numbRes)
                    {
                        Console.WriteLine($"I don't like what you fed me... I need {10 - counter} more numbers.. Go on then, feed me!");

                    }
                    else
                    {
                        userNumbers[counter] = value;
                        counter++;

                        if (counter == userNumbers.Length)
                        {
                            break;
                        }

                    }
                }

                Console.WriteLine("\nYour second 10 snacks are:\n");
                foreach (int nmbr in userNumbers)
                {
                    Console.WriteLine($"{nmbr.ToString("N0")}\n");
                }
                Console.WriteLine("\nThanks for those delicious inputs!");

            }

            //userNumbers[counter] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("\nYour second 10 snacks are:\n");
            //foreach (int number in userNumbers)
            //{
            //    Console.WriteLine($"{number.ToString("N0")}\n");
            //}
            //Console.WriteLine("\nThanks for those delicious inputs!");

            //var valid = true;

            //while (valid)
            //{
            //    var tmp = Convert.ToInt32(Console.ReadLine());


            //    for (int i = 1; i < userNumbers.Length; i++)
            //    {
            //        if (tmp[i] != '0' && tmp[i] != '1')
            //        {
            //            valid = false;
            //        }
            //        userNumbers.Add(tmp);
            //        userNumbers[i] = Convert.ToInt32(Console.ReadLine());

            //    }

            //    try
            //    {
            //        var zahl = (int)tmp[0];
            //        valid = true;

            //    }
            //    catch { Exception ex; }
            //    {
            //        Console.WriteLine("No Number");
            //        valid = false;
            //    }


            //    if (int.TryParse(tmp, out int result))
            //    {
            //        userNumbers[0] = result;
            //        valid = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("No Number");
            //        valid = false;
            //    }
            //}
            //Console.WriteLine("\nYour second 10 snacks are:\n");
            //foreach (int number in userNumbers)
            //{
            //    Console.WriteLine($"{number.ToString("N0")}\n");
            //}
            //Console.WriteLine("\nThanks for those delicious inputs!");

            //userNumbers[0] = Convert.ToInt32(Console.ReadLine());

            //var userInp = Console.ReadLine();

            //if (userInp is int)


            //    if (userNumbers[0] is string || userNumbers[0] is char)
            //    {
            //        Console.WriteLine("Please enter a mumb");
            //        for (int counter = 0; counter <= userNumbers.Length - 1; counter++)
            //        {

            //            userNumbers[counter] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }

            //    else
            //    {
            //        for (int counter = 1; counter <= userNumbers.Length - 1; counter++)
            //        {

            //            userNumbers[counter] = Convert.ToInt32(Console.ReadLine());

            //if (input.GetType() != typeof(int))
            //{

            //}


            //if (input.GetType() == typeof(string))
            //{
            //    Console.WriteLine("Nooo, I don't like string...");

            //    userNumbers[counter] = Convert.ToInt32(Console.ReadLine());
            //}
            //else if (input.GetType() == typeof(char))
            //{
            //    Console.WriteLine("Nooo, I don't like chars...");
            //    userNumbers[counter] = Convert.ToInt32(Console.ReadLine());

            //}
            //else
            //{
            //    userNumbers[counter] = Convert.ToInt32(Console.ReadLine());cfx
            //}



        }

    }

}