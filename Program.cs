using BankAccount;



Customer customer1 = new Customer("Uwak", "Charles");

Customer customer2 = new Customer("Liss", "James");



Account account1 = new Account(customer1, 500);

Account account2 = new Account(customer2, 500);



ChildAccount childAccount = new ChildAccount(customer1);

Account account3 = new Account(customer1, 50);

Customer anotherCustomer = new Customer("Jane", "Jones");

CurrentAccount currentAccount = new CurrentAccount(anotherCustomer);
currentAccount.Deposit(10);

if (currentAccount.Withdraw(10))
{
    Console.WriteLine("Able to withdraw 10");
}


Console.WriteLine($"Account ID: {account1.ID}, Customer: {account1.Customer.FullName}, Balance: {account1.Balance}");

Console.WriteLine($"Account ID: {account2.ID}, Customer: {account2.Customer.FullName}, Balance: {account2.Balance}");

Console.WriteLine($"Account ID {account3.ID}, Customer: {account3.Customer.FullName}, Balance: {account3.Balance}");





// Test Deposit 

Console.WriteLine("Depositing $50 into account1...");

account1.Deposit(50);

Console.WriteLine($"New Balance of Account {account1.ID}: {account1.Balance}");



// Test Withdraw 

Console.WriteLine("Withdrawing $30 from account2...");

account2.Withdraw(30);

Console.WriteLine($"New Balance of Account {account2.ID}: {account2.Balance}");



Console.WriteLine("Withdrawing $5 from account3...");

account3.Withdraw(5);

Console.WriteLine($"New Balance of Account {account3.ID}: {account3.Balance}");



// Test Withdrawal that exceeds balance 

Console.WriteLine("Attempting to withdraw $300 from account1...");

bool withdrawalSuccess = account1.Withdraw(300);

Console.WriteLine($"Withdrawal successful? {withdrawalSuccess}. New Balance of Account {account1.ID}: {account1.Balance}");