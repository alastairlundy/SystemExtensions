namespace AlastairLundy.System.Extensions.BoolArrayExtensions
{
    public static class AllFalseExtension
    {
        public static bool IsAllFalse(this bool[] inputs)
        {
            foreach (var input in inputs)
            {
                if (input.Equals(true))
                {
                    return false;
                }
            }
            return true;
        }
    }
}