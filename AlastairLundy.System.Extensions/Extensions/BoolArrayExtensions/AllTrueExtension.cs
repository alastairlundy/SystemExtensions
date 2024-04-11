namespace AlastairLundy.System.Extensions.BoolArrayExtensions
{
    public static class AllTrueExtension
    {
        public static bool IsAllTrue(this bool[] inputs)
        {
            foreach (var input in inputs)
            {
                if (input.Equals(false))
                {
                    return false;
                }
            }

            return true;
        }
    }
}