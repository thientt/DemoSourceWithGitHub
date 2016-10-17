﻿using System;

public class Math : IMath
{
    public double Add(double x, double y)
    {
        return x + y;
    }

    public double Div(double x, double y)
    {
        if (y == 0)
            throw new DivideByZeroException();

        return x / y;
    }

    public double Mul(double x, double y)
    {
        return x * y;
    }

    public double Sub(double x, double y)
    {
        return x - y;
    }
}
