﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class Car
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}
