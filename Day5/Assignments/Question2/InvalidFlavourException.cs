using System;

namespace CakeWorld;

public class InvalidFlavourException : Exception
{
    public InvalidFlavourException(): base("Flavour not available. Please select the available flavour")
    {
        
    }

    public InvalidFlavourException(string message):base(message)
    {
        
    }
    
}
