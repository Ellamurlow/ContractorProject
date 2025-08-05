using System;
using System.Collections.Generic;

public class Contractor
{
    // Member variables
    protected string contractorName;
    protected int contractorNumber;
    protected DateTime contractorStartDate;

    // Constructor
    public Contractor(string name, int number, DateTime startDate)
    {
        contractorName = name;
        contractorNumber = number;
        contractorStartDate = startDate;
    }

    // Accessors (Getters)
    public string GetName() => contractorName;
    public int GetNumber() => contractorNumber;
    public DateTime GetStartDate() => contractorStartDate;

    // Mutators (Setters)
    public void SetName(string name) => contractorName = name;
    public void SetNumber(int number) => contractorNumber = number;
    public void SetStartDate(DateTime date) => contractorStartDate = date;
}

public class Subcontractor : Contractor
{
    // Additional member variables
    private int shift; // 1 = Day, 2 = Night
    private double hourlyPayRate;

    // Constructor
    public Subcontractor(string name, int number, DateTime startDate
