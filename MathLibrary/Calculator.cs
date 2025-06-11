namespace MathLibrary
{
    public static class Calculator
    {
        /// <summary>
        /// يقوم بضرب عددين
        /// </summary>
        /// <param name="a">العدد الأول</param>
        /// <param name="b">العدد الثاني</param>
        /// <returns>ناتج ضرب a و b</returns>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// يقوم بقسمة عددين
        /// </summary>
        /// <param name="a">العدد الأول</param>
        /// <param name="b">العدد الثاني</param>
        /// <returns>ناتج قسمة a على b، أو 0 إذا كان b = 0</returns>
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a / b;
        }

        /// <summary>
        /// يتحقق مما إذا كان العدد زوجيًا
        /// </summary>
        /// <param name="a">العدد المراد التحقق منه</param>
        /// <returns>true إذا كان a زوجيًا، و false إذا كان فرديًا</returns>
        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }
    }
}