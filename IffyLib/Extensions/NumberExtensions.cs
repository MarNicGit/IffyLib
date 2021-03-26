namespace IffyLib.Extensions
{
    public static class NumberExtensions
    {
        /// <summary>
        /// Checks if the given value is even or not
        /// </summary>
        public static bool IsEven(this int value)
        {
            if (value == 0) return true; //I read online that zero is even so we don't really have to do anything else I guess

            if (value > 0)
            {
                while (value != 0 && value > 0)
                {
                    value -= 2;
                }
            }
            else //value is below zero
            {
                while (value != 0 && value < 0)
                {
                    value += 2;
                }
            }

            return value == 0;
        }
    }
}
