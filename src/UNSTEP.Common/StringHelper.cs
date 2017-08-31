namespace UNSTEP.Common
{
    using System;

    public static class StringHelper
    {
        public static bool CompareIgnoreCase(string value, string compareTo) =>
            string.Compare(value, compareTo, StringComparison.OrdinalIgnoreCase) == 0;
    }
}
