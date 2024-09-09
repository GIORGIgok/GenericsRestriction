namespace GenericsRestriction
{
    class Transaction<T> where T: Account
    {
        public T FromAccount { get; set; }
        public T ToAccount { get; set; }
        public decimal Amount { get; set; }

        public void Execute ()
        {
            if (FromAccount.Balance >= Amount) 
            {
                FromAccount.Balance -= Amount;
                ToAccount.Balance += Amount;

                Console.WriteLine($"Successful transaction from {FromAccount.ID} to {ToAccount.ID}");
            }
            else
            {
                Console.WriteLine("Transaction failed");
            }
        }
    }
}