using System;
class Device
{
    public string Brand;
    public string Model;
     public void DisplayDeviceDetails()
    {
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Model: " + Model);
    }
}
class Mobile : Device
{
    public int BatteryCapacity;
    public int BatteryPercentage;
    public int CalculateBatteryBackup()
    {
        return BatteryPercentage * 5;
    }
}
class SmartPhone : Mobile
{
    public int StorageCapacity;
    public int UsedStorage;
    public int CalculateAvailableStorage()
    {
        return StorageCapacity - UsedStorage;
    }
    public void CheckStorageStatus()
    {
        int availableStorage = CalculateAvailableStorage();
        if (availableStorage < 5)
        {
            Console.WriteLine("Storage Status: Storage Full");
        }
        else
        {
            Console.WriteLine("Storage Status: Storage Available");
        }  
    }
}
class SmartDeviceManagement
{
    public static void Main(string[] args)
    {
        SmartPhone myPhone = new SmartPhone();
        myPhone.Brand = "Samsung";
        myPhone.Model = "Galaxy S21";
        myPhone.BatteryCapacity = 5000;
        myPhone.BatteryPercentage = 80;
        myPhone.StorageCapacity = 128;
        myPhone.UsedStorage = 100;
        myPhone.DisplayDeviceDetails();
        Console.WriteLine("Battery Capacity: " + myPhone.BatteryCapacity + " mAh");
        Console.WriteLine("Battery Percentage: " + myPhone.BatteryPercentage + "%");
        Console.WriteLine("Battery Backup: " + myPhone.CalculateBatteryBackup() + " Minutes");
        Console.WriteLine("Storage Capacity: " + myPhone.StorageCapacity + " GB");
        Console.WriteLine("Used Storage: " + myPhone.UsedStorage + " GB");
        Console.WriteLine("Available Storage: " + myPhone.CalculateAvailableStorage() + " GB");
        myPhone.CheckStorageStatus();
        
    }
}

