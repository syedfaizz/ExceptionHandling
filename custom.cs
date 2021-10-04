using System;

namespace exception
{
    class Program
    {
        public Program(string name, int balance)
        {
            Name = name;
            Balance = balance;
        }
        public string Name { get; private set; }
        public int Balance { get; private set; }

        public void Debit(int amount)
        {
            if (Balance < amount) throw new InsufficientFuncException(Name, Balance, amount);
            Balance = Balance - amount;
        }

        public void Credit(int amount) => Balance = amount + Balance;
    }
}
