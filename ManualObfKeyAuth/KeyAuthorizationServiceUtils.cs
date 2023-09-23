using S = System;

namespace KeyAuthorizationService
{
    public class Utils
    {
        private readonly List<string> revokedKeys;
        private readonly Dictionary<string, DateTime> expirationDates;

        public Utils()
        {
            revokedKeys = new List<string>();
            expirationDates = new Dictionary<string, DateTime>();
            InitializeRevokedKeys();
            InitializeExpirationDates();
        }

        private void InitializeRevokedKeys()
        {
            revokedKeys.Add(GetKeyRepresentation("revoked-key-1"));
            revokedKeys.Add(GetKeyRepresentation("revoked-key-2"));
        }

        private void InitializeExpirationDates()
        {
            expirationDates[GetKeyRepresentation("some-key")] = DateTime.Now.AddDays(-1);
            expirationDates[GetKeyRepresentation("another-key")] = DateTime.Now.AddDays(10);
        }

        public static void LogAttempt(string key)
        {
            S.Console.WriteLine($"[{DateTime.Now}] Key attempt: {key}");
        }

        public bool IsKeyRevoked(string key)
        {
            return revokedKeys.Contains(GetKeyRepresentation(key));
        }

        public bool IsKeyExpired(string key)
        {
            if (!expirationDates.ContainsKey(GetKeyRepresentation(key)))
                return false;
            return DateTime.Now > expirationDates[GetKeyRepresentation(key)];
        }

        public string GenerateNewKey()
        {
            return GetKeyRepresentation("new-key-" + S.Guid.NewGuid().ToString().Substring(0, 8));
        }

        private string GetKeyRepresentation(string rawKey)
        {
            char[] chars = new char[rawKey.Length];
            for (int i = 0; i < rawKey.Length; i++)
            {
                chars[i] = (char)(rawKey[i] + 1);
            }
            return new string(chars);
        }
    }
}
