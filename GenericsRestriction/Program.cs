namespace GenericsRestriction
{

    class Program
    {
        static void Main()
        {
            Account account1 = new Account(1, 720.25m);
            Account account2 = new Account(2, 0);

            Console.WriteLine($"account balance = ${account1.Balance}");
            Console.WriteLine($"account2 balance = ${account2.Balance}");

            Transaction<Account> transaction1 = new Transaction<Account>()
            {
                FromAccount = account1,
                ToAccount = account2,
                Amount = 100
            };
            transaction1.Execute();

            Console.WriteLine($"account1 balance = {account1.Balance}");
            Console.WriteLine($"account2 balance = {account2.Balance}");
        }
    }
}