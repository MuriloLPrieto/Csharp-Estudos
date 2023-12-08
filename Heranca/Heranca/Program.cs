using Heranca.Entities;

Account acc = new Account(8010, "Murilo", 0.0);
BussinessAccount bacc = new BussinessAccount(1000, "Julia", 0.0, 500.0);

//UpCasting
Account acc1 = bacc;
Account acc2 = new BussinessAccount(1001, "Alana", 0.0, 300.0);
Account acc3 = new SavingsAccount(1002,"Leonardo", 1000.0, 0.01);

//Downcasting

BussinessAccount acc4 = (BussinessAccount)acc2;
acc4.Loan(100.0);

//BussinessAccount acc5 = (BussinessAccount)acc3;

if (acc3 is BussinessAccount)
{
    //BussinessAccount acc5 = (BussinessAccount)acc3;
    BussinessAccount acc5 = acc3 as BussinessAccount; //Sintaxe alternativa para casting
    acc5.Loan(200.00);
    Console.WriteLine("Loan!");
}

if (acc3 is SavingsAccount)
{
    //SavingsAccount acc5 = (SavingsAccount)acc3;
    SavingsAccount acc5 = acc3 as SavingsAccount;
    acc5.UpdateBalance();
    Console.WriteLine("Uptade!");
}