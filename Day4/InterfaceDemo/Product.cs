using System;

namespace InterfaceDemo;
// Entity class => class containing only fields and properties
// Product entity class for demo purposes
public class Product
{
    public int ProdID { get; set; } 
    // SHORTCUT = prop
    public string Name { get; set; }
    public int Price { get; set; }
}
