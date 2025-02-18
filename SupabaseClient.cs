namespace Supa
{
    using Supabase;
    using System.Threading.Tasks;

    public class SupabaseClient
    {
        private static Supabase.Client? _client;
        private const string SupabaseUrl = "https://ecxikkvdqvbdnyboyvmg.supabase.co";
        private const string SupabaseAnonKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImVjeGlra3ZkcXZiZG55Ym95dm1nIiwicm9sZSI6ImFub24iLCJpYXQiOjE3Mzk3NzIyOTAsImV4cCI6MjA1NTM0ODI5MH0.__TVAsMTod45IMiNPrOpgf6bjfeovQXB3klzGsQKjLE";

        public Supabase.Client GetClient()
        {
            if (_client == null)
            {
                _client = new Supabase.Client(SupabaseUrl, SupabaseAnonKey, new SupabaseOptions
                {
                    AutoConnectRealtime = true
                });
            }
            return _client;
        }
    }

}