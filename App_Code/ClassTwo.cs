using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class ClassTwo
{
    /// <summary>
    /// Addition
    /// </summary>
    /// <param name="val1"></param>
    /// <param name="val2"></param>
    /// <returns></returns>
    public int Addition(int val1, int val2)
    {
        return val1 + val2;
    }
    public int Execute()
    {
        int val1 = 1;
        int val2 = 2;
        ClassTwo obj = new ClassTwo();
        return obj.Addition(val1, val2);

    }
}