using System;
using System.Numerics;
namespace InterfaceDemo;

// every interface nomenclature is started with CAPITAL letter
// Microsoft says for every class and interface, seperate files should be created

interface IAdd
{
    int AddMe(int num1, int num2);
    // int AddMe(int num1, int num2){} >>> empty body, not an abstract method
    // abstract methods and functions HAVE to be OVERWRITTEN
    

}

interface ISub
{
    int SubMe(int num1, int num2);
}

interface IDiv
{
    float DivMe(int num1, int num2);
}

interface IProd
{
    int ProdMe(int num1, int num2);
}

interface IAddSub: IAdd, ISub // interface supports multiple inheritance
{
    
}

interface IAddProdDiv : IAdd, IProd, IDiv
{
    
}

interface IAll: IAdd, ISub, IProd, IDiv
{
    
}