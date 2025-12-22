// See https://aka.ms/new-console-template for more information
using InterfaceDemo;

Console.WriteLine("Demo on interfaces");

/*
MathClass m1 = new MathClass();
/// User1 is looking for Add method but because there is no individual functionality present yet
/// he is paying for only one thing but getting access to all features


MathClass m2 = new MathClass();
// User2 is looking for Addition and Sub

MathClass m3 = new MathClass();
// User3 is looking for add, sub, div, prod

*/

/* 

IAdd m1 = new MathClass(); //user1
IAddSub m2 = new MathClass(); //user2
IAll m3 = new MathClass(); //user3
// now only the paid things can be used
*/

// Approach 1
Product pObj = new Product();
pObj.ProdID = 101;
pObj.Name = "Borosil Flask";
pObj.Price=850;

// Approach 2
Product pObj1 = new Product(){ProdID = 102, Name = "Marker", Price=25};
// Object Initialiser

//Approach 3

// Genereric = smart phones (non gender oriented)
// Non Generic = Phone cases (gender oriented)
// ArrayList and List are dynamic but ArrayList degrades performance due to boxing and unboxing,
// so we use List instead. List( generic) & ArrayList(non generic)

List<Product> prodList = new List<Product>()
{
    new Product(){ProdID = 101, Name = "Body Lotion", Price=600},
    new Product(){ProdID = 102, Name = "Face Wash", Price=250},
    new Product(){ProdID = 103, Name = "Shampoo", Price=800},
    new Product(){ProdID = 104, Name = "Face Mosturizer", Price=457},
    new Product(){ProdID = 105, Name = "Perfume", Price=756},
    new Product(){ProdID = 106, Name = "Lip Balm", Price=350},
}; // Collection Initialiser

foreach (var item in prodList)
{
    System.Console.WriteLine($"{item.ProdID}\t{item.Name}\t{item.Price}"); //string intercollation
}
