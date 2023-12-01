using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assig = new Assignment("William Osiakwan","Inheritance");
        assig.GetSummary();
        Console.WriteLine(assig.GetSummary());

        MathAssignment mathassig = new MathAssignment("William Osiakwan","Inheritance","7.3","10-11");
        mathassig.GetHomeWorkList();
        Console.WriteLine(mathassig.GetHomeWorkList());

        WritingAssignment writingassign = new WritingAssignment("William Osiakwan","American History","American Civil War");
        writingassign.GetWritingInfo();
        Console.WriteLine(writingassign.GetWritingInfo());
    }
}