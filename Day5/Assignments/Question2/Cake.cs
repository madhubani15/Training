using System;

namespace CakeWorld;

public class Cake
{
    #region properties

    public string Flavour { get; set; }
    public int QuantityInKg { get; set; }
    public double PricePerKg{ get; set; }

    #endregion

    public bool CakeOrder()
    {
        if(Flavour=="Chocolate" || Flavour == "Red Velvet" || Flavour == "Vanilla")
        {
            if (QuantityInKg > 0)
            {
                return true;
            }
            else
            {
                throw new InvalidQuantityException();
                return false;
            }
        }
        else
        {
            throw new InvalidFlavourException();
            return false;
        }
        
    }
    int discount;
    double totalPrice, discountPrice;

    public double CalculatePrice()
    {
        // Total Price = Quantity In Kg * Price Per Kg
        // Discounted Price = Total Price - (Total Price * Discount /100)
        switch (Flavour)
        {
            case "Vanilla":
            {
                discount =3;
                break;    
            }

            case "Chocolate":
            {
                discount =5;
                break;    
            }

            case "Red Velvet":
            {
                discount =10;
                break;    
            }

        }

        totalPrice = QuantityInKg*PricePerKg;
        discountPrice = totalPrice - ((totalPrice*discount)/100);

        return discountPrice;

    }
}


