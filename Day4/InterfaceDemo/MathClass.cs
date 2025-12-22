using System;
namespace InterfaceDemo;

public class MathClass:IAll, IAddSub
{
    
    public int AddMe( int num1, int num2)
    // Instance method >>> It's not static but it can be
    {
        return num1+num2;

    }

    public int SubMe( int num1, int num2)
    // Instance method >>> It's not static but it can be
    {
        return num1-num2;

    }

    public float DivMe( int num1, int num2)
    // Instance method >>> It's not static but it can be
    {
        return (float) num1/num2;

    }

    public int ProdMe( int num1, int num2)
    // Instance method >>> It's not static but it can be
    {
        return num1*num2;

    }


}


/*
public class MathClass
{
    
    public int AddMe( int num1, int num2)
    // Instance method >>> It's not static but it can be
    {
        return num1+num2;

    }

    public int SubMe( int num1, int num2)
    // Instance method >>> It's not static but it can be
    {
        return num1-num2;

    }

    public float DivMe( int num1, int num2)
    // Instance method >>> It's not static but it can be
    {
        return (float) num1/num2;

    }

    public int ProdMe( int num1, int num2)
    // Instance method >>> It's not static but it can be
    {
        return num1*num2;

    }


}
*/