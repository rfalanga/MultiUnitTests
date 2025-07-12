using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class is to provide 3 methods, so we can test using xUnit, nUnit, and MSTest.
 */

namespace SimpleDLL;

public class AddSomeIntegers
{
    public int AddTwo(int a)
    {
        return a + 2;
    }

    public int AddThree(int a)
    {
        return a + 3;
    }

    public int AddFour(int a)
    {
        return a + 4;
    }
}