namespace UNSTEP.Common
{
    using System;

    public static class ThrowIf
    {
        public static void IsNull(object obj, string parameterName)
        {
            if (obj == null)
                throw new ArgumentNullException(parameterName);
        }

        public static void IsNullOrEmpty(string value, string parameterName)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException(parameterName);
        }

        public static void IsBefore(DateTime value, DateTime dateToPrecede, string parameterName)
        {
            if (value > dateToPrecede)
                throw new ArgumentException(parameterName);
        }
    }
}
