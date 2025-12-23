using System;

namespace Assignments;

public class Laptop: Computer
{
    #region properties
    public int DisplaySize { get; set; }
    public int BatteryVolt { get; set; }
    #endregion


    public int LaptopPrice;
    public int RamPrice = 200;
    public int HardDiskPrice =1500;
    public int GraphicCardPrice = 2500;
    public int BatteryVoltPrice =20;
    public int DisplayPrice = 250;


    public int ProcessorCost;

   

    public double LaptopPriceCalculation()
    {

        switch (Processor)
        {
            case "i3":
                ProcessorCost = 2500;
                break;

            case "i5":
                ProcessorCost = 5000;
                break;

            case "i7":
                ProcessorCost = 6500;
                break;
            
            default:
                System.Console.WriteLine("Invalid processor");
                break;
        }

        LaptopPrice= ProcessorCost+(RamSize*RamPrice)+(HardDiskPrice*HardDiskPrice)+(GraphicCard*GraphicCardPrice)+(DisplayPrice*DisplaySize)+(BatteryVolt*BatteryVoltPrice);
        return LaptopPrice;
    }

         


    
    





}

    

    
