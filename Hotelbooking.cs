public class Hotelbooking
{
    public static void Main (String[] args)
    {
        Console.Write("Welcome to Mariott Hotels! Enter 1 for Standard room, 2 for Deluxe room and 3 for Suite. Please select your room type: ");
        int roomtype = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the number of days you will staying: ");
        int days = Convert.ToInt32(Console.ReadLine());
        Console.Write("Do you have a membership pass? If yes type YES. If no type NO: ");
        string membership = Console.ReadLine();
        if (membership != "YES" && membership != "NO")
        {
            Console.WriteLine("Oops! Invalid input.");
            Environment.Exit(0);
        }
        Console.Write("Do you want breakfast(extra 500 rupees) included in your stay? If yes type YES. If no type NO: ");
        string food = Console.ReadLine();
        if (food != "YES" && food != "NO")
        {
            Console.WriteLine("Oops! Invalid input.");
            Environment.Exit(0);
        }
        double totfoodprice = 500 * days;
        double stdprice = 1000 * days;
        double dprice = 1900 * days;
        double sprice = 2500 * days;
        double discount = 0;
        double newprice = 0;
        double finalprice = 0;
        String name;
       
        switch (roomtype)
        {
            case 1:
                if(membership == "YES" && food == "YES")
                {
                    Console.WriteLine("The price for Standard room/night is 1000. For " +days+ " days the price is: " +stdprice);
                    Console.WriteLine("Yay!! you get a 5% off");
                    discount = (stdprice + totfoodprice) * 0.05;
                    newprice = (stdprice + totfoodprice) - discount; 
                    finalprice = (newprice * 0.12) + newprice;
                    Console.WriteLine("Your calculated bill inclusive of taxes is: " +finalprice);
                }
                else if (membership == "YES" && food == "NO" || membership == "NO" && food == "YES")
                {
                    Console.WriteLine("Yay!! you get a 5% off");
                    discount = stdprice * 0.05;
                    newprice = stdprice - discount;
                    finalprice = (newprice * 0.12) + newprice;
                    Console.WriteLine("Your calculated bill inclusive of taxes is: " +finalprice);
                }
                else if (membership == "NO" && food == "NO")
                {
                finalprice = (stdprice * 0.12) + stdprice;
                Console.WriteLine("Your calculated bill inclusive of taxes is: " +finalprice);    
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    break;
                }
                Console.WriteLine("Bill details:");
                Console.WriteLine("Room type: Standard");
                Console.WriteLine("Number of nights: " + days);
                Console.WriteLine("Total room price: " + stdprice);
                if(food == "YES" && membership == "YES")
                {
                Console.WriteLine("Total food price: " + totfoodprice);
                Console.WriteLine("Membership Discount: " + discount);
                }
                else if(food == "YES" && membership == "NO")
                {
                Console.WriteLine("Total food price: " + totfoodprice);
                }
                else if(food == "NO" && membership == "YES")
                {
                Console.WriteLine("Membership Discount: " + discount);
                }
                else
                {
                Console.WriteLine("No food and no membership discount applied.");
                }
                Console.WriteLine("Final price (inclusive of taxes): " + finalprice);
                break;

            case 2:
                if(membership == "YES" && food == "YES")
                {
                    Console.WriteLine("The price for Deluxe room/night is 1900. For " +days+ " days the price is: " +dprice);
                    Console.WriteLine("Yay!! you get a 5% off");
                    discount = (dprice + totfoodprice) * 0.05;
                    newprice = (dprice + totfoodprice) - discount; 
                    finalprice = (newprice * 0.12) + newprice;
                    Console.WriteLine("Your calculated bill inclusive of taxes is: " +finalprice);
                }
                else if (membership == "YES" && food == "NO" || membership == "NO" && food == "YES")
                {
                    Console.WriteLine("Yay!! you get a 5% off");
                    discount = dprice * 0.05;
                    newprice = dprice - discount;
                    finalprice = (newprice * 0.12) + newprice;
                    Console.WriteLine("Your calculated bill inclusive of taxes is: " +finalprice);
                }
                else if (membership == "NO" && food == "NO")
                {
                finalprice = (dprice * 0.12) + dprice;
                Console.WriteLine("Your calculated bill inclusive of taxes is: " +finalprice);  
                    
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                Console.WriteLine("Bill details:");
                Console.WriteLine("Room type: Deluxe");
                Console.WriteLine("Number of nights: " + days);
                Console.WriteLine("Total room price: " + dprice);
                if(food == "YES" && membership == "YES")
                {
                Console.WriteLine("Total food price: " + totfoodprice);
                Console.WriteLine("Membership Discount: " + discount);
                }
                else if(food == "YES" && membership == "NO")
                {
                Console.WriteLine("Total food price: " + totfoodprice);
                }
                else if(food == "NO" && membership == "YES")
                {
                Console.WriteLine("Membership Discount: " + discount);
                }
                else
                {
                Console.WriteLine("No food and no membership discount applied.");
                }
                Console.WriteLine("Final price (inclusive of taxes): " + finalprice);
                break;
            
            case 3:
                if(membership == "YES" && food == "YES")
                {
                    Console.WriteLine("The price for Suite room/night is 2500. For " +days+ " days the price is: " +sprice);
                    Console.WriteLine("Yay!! you get a 5% off");
                    discount = (sprice + totfoodprice) * 0.05;
                    newprice = (sprice + totfoodprice) - discount; 
                    finalprice = (newprice * 0.12) + newprice;
                }
                else if (membership == "YES" && food == "NO" || membership == "NO" && food == "YES")
                {
                    Console.WriteLine("Yay!! you get a 5% off");
                    discount = sprice * 0.05;
                    newprice = sprice - discount;
                    finalprice = (newprice * 0.12) + newprice;
                }
                else if (membership == "NO" && food == "NO")
                {
                finalprice = (sprice * 0.12) + sprice;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                Console.WriteLine("Bill details:");
                Console.WriteLine("Room type: Suite");
                Console.WriteLine("Number of nights: " + days);
                Console.WriteLine("Total room price: " + sprice);
                if(food == "YES" && membership == "YES")
                {
                Console.WriteLine("Total food price: " + totfoodprice);
                Console.WriteLine("Membership Discount: " + discount);
                }
                else if(food == "YES" && membership == "NO")
                {
                Console.WriteLine("Total food price: " + totfoodprice);
                }
                else if(food == "NO" && membership == "YES")
                {
                Console.WriteLine("Membership Discount: " + discount);
                }
                else
                {
                Console.WriteLine("No food and no membership discount applied.");
                }
                Console.WriteLine("Final price (inclusive of taxes): " + finalprice);
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        } 
        Console.Write("Please enter your name for the booking confirmation: ");
        name = Console.ReadLine();
        Console.WriteLine("Your booking is confirmed, " + name + "! Tell your name to the receptionist as the booking reference." );
        Console.WriteLine("Thank you for choosing Mariott Hotels! We hope to see you again soon.");
    }
}