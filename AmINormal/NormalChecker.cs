using System;

namespace AmINormal
{
    public static class NormalChecker
    {
        private static readonly Random Random = new Random();

        private static readonly string[] Responses =
        {
            "Yes, you are normal!",
            "No, but that's okay!",
            "Why ask? Just be yourself!",
            "Sometimes normal is overrated."
        };

        public static string IsNormal()
        {
            int index = Random.Next(Responses.Length);
            return Responses[index];
        }
    }
}
