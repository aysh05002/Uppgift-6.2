using System;

class program
{
    static int Störst(int tal1, int tal2)
    {
        int x = 0;
        if (tal1 > tal2)
        {
            x = tal1;
        }
        else if (tal2 > tal1)
        {
            x = tal2;
        }
        else if (tal1 == tal2)
        {
            x = tal1;
        }
        return x;
    }
}