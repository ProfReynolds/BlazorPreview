namespace BlazorWebAssemblyDemo
{
    class MaintainCurrentCount
    {
        private static int _currentCount = 0;

        public static int GetCurrentCount()
        {
            return _currentCount;
        }

        public static void IncrementCurrentCount()
        {
            _currentCount++;
        }
    }

}
