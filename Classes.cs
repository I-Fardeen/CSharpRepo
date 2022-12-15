//Author: Fardeen Ahmad Khan
using System;
//namespace CsharpRepo{
interface IDevice
{
    string DeviceId { get; set; }
    string DeviceType { get; set; }
}

public class Computer : IDevice{ 
    public string DeviceId { get; set; }
    public string DeviceType { get; set; } 
    public bool SetDeviceId(string deviceId){ 
        try
        {
                DeviceId = deviceId;
                return true;
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }

    }

    public bool SetDeviceType(string deviceType){
        try
        {
            DeviceType = deviceType;
            return true;
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }

    public void GetDetails(){
        Console.WriteLine("---------------------------");
        Console.WriteLine("Device Id: " + DeviceId);
        Console.WriteLine("Device Type: " + DeviceType);
    }
    public static void Main(string[] args){
        Computer cp = new Computer();
        Console.WriteLine("Enter the type for your Device");
        string deviceType = Console.ReadLine();
        cp.SetDeviceType(deviceType);
        Console.WriteLine("Enter the device id for your "+deviceType);
        string deviceId =Console.ReadLine();
        cp.SetDeviceId(deviceId);
        Console.WriteLine("Displaying the Details of your "+deviceType);
        cp.GetDetails();
        Console.ReadLine();
    }
}

//}