using Week_5;

class Program
{
    static void Main()
    {
        //task 1
        BankAccount acc = new BankAccount("AC-1001", 5000);

        Console.WriteLine("Account Number: " + acc.AccountNumber);
        Console.WriteLine("Initial Balance: " + acc.Balance);

        acc.Deposit(1500);
        acc.Withdraw(2000);

        Console.WriteLine("Remaining Balance: " + acc.Balance);
//task 2

        Car car = new Car("Toyota", 180, 5);
        Motorcycle bike = new Motorcycle("Yamaha", 140, false);

        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        bike.Start();
        bike.DisplayInfo();
        bike.Stop();

//task 3
        Printer p = new Printer();
        p.Print("Hello!");
        p.Print(123);
        p.Print("Repeat me", 3);


        //task 4
        VehicleAbs ca_r = new CarAbs();
        VehicleAbs bik_e = new BikeAbs();

        ca_r.Display();
        ca_r.StartEngine();
        ca_r.StopEngine();

        Console.WriteLine();

        bik_e.Display();
        bik_e.StartEngine();
        bik_e.StopEngine();

    }
}
