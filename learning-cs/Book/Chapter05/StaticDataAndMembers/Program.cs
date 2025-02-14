using StaticDataAndMembers;

SavingsAccount s1 = new SavingsAccount(50);
SavingsAccount s2 = new SavingsAccount(100);
SavingsAccount s3 = new SavingsAccount(10000.75);

Console.WriteLine(SavingsAccount.GetInterestRate());

TimeUtilsClass.PrintTime();
TimeUtilsClass.PrintDate();

Console.ReadLine();