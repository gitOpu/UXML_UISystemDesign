using System;

namespace UIToolkitExamples_02
{
    public enum TemperatureUnit
    {
        Celsius,
        Farenheit
    }

    [Serializable]
    public struct Temperature
    {
        public double value;
        public TemperatureUnit unit;
    }
}