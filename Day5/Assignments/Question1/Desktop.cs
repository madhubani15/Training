using System;
namespace Assignments;
public class Desktop:Computer
{
    #region properties
    public int MonitorSize { get; set; }
    public int PowerSupplyVolt { get; set; }

    #endregion

    public int DesktopPrice;
    public int RamPrice = 200;
    public int HardDiskPrice =1500;
    public int GraphicCardPrice = 2500;
    public int PowerSupplyPrice =20;
    public int MonitorPrice = 250;


    public int ProcessorCost;

    /// Formula for DesktopPriceCalculation()
    /// <summary>
    /// Desktop Price = Processor Cost + (RamSize * Ram Price) 
    ///+ (HardDiskSize * Hard Disk Price) + (GraphicCard * Graphic Card Price) +
    ///(MonitorSize * Monitor Price) + (PowerSupplyVolt * Power Supply Volt Price);
    /// </summary>
    public double DesktopPriceCalculation()
    {
        switch (Processor)
        {
            case "i3":
                ProcessorCost = 1500;
                break;

            case "i5":
                ProcessorCost = 3000;
                break;

            case "i7":
                ProcessorCost = 4500;
                break;
            
            default:
                System.Console.WriteLine("Invalid processor");
                break;
        }

        DesktopPrice= ProcessorCost+(RamSize*RamPrice)+(HardDiskPrice*HardDiskPrice)+(GraphicCard*GraphicCardPrice)+(MonitorPrice*MonitorSize)+(PowerSupplyPrice*PowerSupplyVolt);
        return DesktopPrice;
    }

}
