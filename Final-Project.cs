// Contractor class
public class Contractor
{
    public string ContractorName { get; set; }
    public int ContractorNumber { get; set; }
    public DateTime ContractorStartDate { get; set; }

    public Contractor(string name, int number, DateTime startDate)
    {
        ContractorName = name;
        ContractorNumber = number;
        ContractorStartDate = startDate;
    }

    public virtual void PrintDetails()
    {
        Console.WriteLine($"Contractor Name: {ContractorName}");
        Console.WriteLine($"Contractor Number: {ContractorNumber}");
        Console.WriteLine($"Contractor Start Date: {ContractorStartDate.ToShortDateString()}");
    }
}
// Subcontractor class derived from Contractor
public class Subcontractor : Contractor
{
    public int Shift { get; set; }
    public double HourlyPayRate { get; set; }

    public Subcontractor(string name, int number, DateTime startDate, int shift, double hourlyPayRate)
        : base(name, number, startDate)
    {
        Shift = shift;
        HourlyPayRate = hourlyPayRate;
    }
// Method to calculate pay with shift differential
    public float CalculatePay(int hoursWorked)
    public float CalculatePay(int hoursWorked)
    {
        double pay = HourlyPayRate * hoursWorked;
        if (Shift == 2) // Night shift
        {
            pay *= 1.03; // 3% shift differential
        }
        return (float)pay;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Shift: {Shift}");
        Console.WriteLine($"Hourly Pay Rate: {HourlyPayRate}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Subcontractor> subcontractors = new List<Subcontractor>();
        string input;

        do
        {
            Console.WriteLine("Enter subcontractor details (or type 'done' to finish):");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "done") break;

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Start Date (YYYY-MM-DD): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Shift (1 for day, 2 for night): ");
            int shift = int.Parse(Console.ReadLine());

            Console.Write("Hourly Pay Rate: ");
            double hourlyPayRate = double.Parse(Console.ReadLine());

            Subcontractor subcontractor = new Subcontractor(name, number, startDate, shift, hourlyPayRate);
            subcontractors.Add(subcontractor);

        } while (true);

        Console.WriteLine("\nSubcontractor Details:");
        foreach (var sub in subcontractors)
        {
            sub.PrintDetails();
            Console.WriteLine($"Calculated Pay: {sub.CalculatePay(8):C}"); // Assuming 8 hours worked
            Console.WriteLine();
        }
    }
}
