﻿using System;

namespace EasyDate
{
    public abstract class TimeSteps
    {
        protected int Value { get; }
        protected TimeSteps(int value) => Value = value;
        public abstract DateTime After(DateTime dateTime);
        public abstract DateTime Before(DateTime dateTime);
        public DateTime Later() => After(DateTime.Now);
        public DateTime Ago() => Before(DateTime.Now);
        public DateTime FromNow() => After(DateTime.Now);
    }
}