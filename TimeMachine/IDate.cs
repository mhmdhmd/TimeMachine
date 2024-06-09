﻿using System;

namespace TimeMachine
{
    public interface IDate
    {
        int Year { get; }
        Month Month { get; }
        Day Day { get; }
        DateTime LetsGo();
    }
}