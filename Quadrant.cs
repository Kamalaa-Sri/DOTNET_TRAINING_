class Quadrant
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the value of X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value of Y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        if(x>0 && y > 0)
        {
            Console.WriteLine("The values " +x+ " , " +y+ " belong to first quadrant");
        }else if(x<0 && y>0){
            Console.WriteLine("The values " +x+ " , " +y+ " belong to second quadrant");
        }else if(x>0 && y<0){
            Console.WriteLine("The values " +x+ " , " +y+ " belong to fourth quadrant");
        }else if(x<0 && y<0){
            Console.WriteLine("The values " +x+ " , " +y+ " belong to third quadrant");
        }
    }
}