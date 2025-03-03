using Polymorpism;

Customer customer1 = new Customer("John", "Smith");
Customer customer2 = new Customer("Mary", "Jones");

Bank bank = new Bank();

bank.AddCustomer(customer1);
bank.AddCustomer(customer2);

Account johnAccount = new ChildAccount(customer1);
Account maryAccount = new Account(customer2);

bank.AddAccount(johnAccount);
bank.AddAccount(maryAccount);

Console.WriteLine(johnAccount);
Console.WriteLine(maryAccount);

johnAccount.Deposit(15);
maryAccount.Deposit(15);

Console.WriteLine(johnAccount);
Console.WriteLine(maryAccount);

bank.Transfer(johnAccount.ID, maryAccount.ID, 11); // this should fail - more than 10

Console.WriteLine(johnAccount);
Console.WriteLine(maryAccount);

bank.Transfer(johnAccount.ID, maryAccount.ID, 10); // this should pass

Console.WriteLine(johnAccount);
Console.WriteLine(maryAccount);

bank.Transfer(johnAccount.ID, maryAccount.ID, 10); // this should fail - not enough funds

bank.Transfer(maryAccount.ID, johnAccount.ID, 11); // this should pass - maryAccount is not a ChildAccount

Console.WriteLine(johnAccount);
Console.WriteLine(maryAccount);

bank.Transfer(maryAccount.ID, johnAccount.ID, 100); // this should fail - not enough funds

Console.WriteLine(johnAccount);
Console.WriteLine(maryAccount);
