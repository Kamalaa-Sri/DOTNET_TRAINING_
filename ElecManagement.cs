
class ElecManagement {
    public static void Main(string[] args) {
        int customers;
        double units = 0; 
        double bill = 0;
        double totalRevenue = 0;
        int count = 0;
        Console.Write("Enter number of customers: ");
        customers = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= customers; i++) {
            Console.WriteLine("Customer " + i);
            Console.Write("Enter Customer ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter units consumed: ");
            units = Convert.ToDouble(Console.ReadLine());
            if (units <= 100) {
                bill = units * 1.5;
            }
            else if (units <= 200) {
                bill = (100 * 1.5) + ((units - 100) * 2.5);
            }
            else if (units <= 300) {
                bill = (100 * 1.5) + (100 * 2.5) + ((units - 200) * 4);
            }
            else {
                bill = (100 * 1.5) + (100 * 2.5) + (100 * 4) + ((units - 300) * 6);
            }
            double fixedCharge = 50;
            double surcharge = 0;
            if (bill > 1000) {
                surcharge = bill * 0.05;
            }
            bill = bill + fixedCharge + surcharge;
            Console.WriteLine("      ELECTRICITY BILL     ");
            Console.WriteLine("Customer ID: " + id);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Units Consumed: " + units);
            Console.WriteLine("Fixed Charge: Rs. " + fixedCharge);
            Console.WriteLine("Surcharge: Rs. " + surcharge);
            Console.WriteLine("Total Bill: Rs. " + bill);
            if (bill <= 500){
                Console.WriteLine("Payment Category: Low");
            }
            else if (bill <= 1500){
                Console.WriteLine("Payment Category: Medium");
            }
            else {
                Console.WriteLine("Payment Category: High");
            }
            totalRevenue = totalRevenue + bill;
            count++;
        }
        Console.WriteLine("\n===== SUMMARY =====");
        Console.WriteLine("Customers Processed: " + count);
        Console.WriteLine("Total Revenue: Rs. " + totalRevenue);
    }
}
