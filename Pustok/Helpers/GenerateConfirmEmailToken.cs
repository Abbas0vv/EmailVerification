namespace Pustok.Helpers
{
    public static class GenerateConfirmEmailToken
    {
        public static string GetConfirmEmailToken()
        {
            string token = Guid.NewGuid().ToString();
            return token;
        }

    }
}
