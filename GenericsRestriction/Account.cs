namespace GenericsRestriction
{
    class Account
    {
        public int ID { get; set; }
        public decimal Balance { get; set; }
        public Account(int ID, decimal Balance) {
            this.ID = ID;
            this.Balance = Balance;
        }
    }
}