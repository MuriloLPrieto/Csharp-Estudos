﻿using ComposicaoObj.Entities;
using ComposicaoObj.Entities.Enums;
using System.Globalization;

Console.Write("Enter department's name: ");
string deptName = Console.ReadLine();

Console.WriteLine("Enter worker data:");

Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Junior/Pleno/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.Write("Base Salary: ");
double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department dept = new Department(deptName);
Worker worker = new Worker(name, level, sal, dept);

Console.Write("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data: ");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double perHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration: ");
    int hours = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date, perHour, hours);
    worker.AddContract(contract);
    Console.Clear();
}
Console.WriteLine();
Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();

int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3));

Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Department: {worker.Department.Name}");
Console.WriteLine($"Income for {monthAndYear}: R${worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");