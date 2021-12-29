using System.Net;

namespace DotNet6WhatsNew
{
    internal static class HTTP3Demo
    {

        // <ItemGroup>
        //      <RuntimeHostConfigurationOption Include = "System.Net.SocketsHttpHandler.Http3Support" Value="true" />
        // </ItemGroup>

        public static async Task Run()
        {
            Console.WriteLine();
            Console.WriteLine("--->8 HTTP3Demo 8<---");

            var client = new HttpClient()
            {
                DefaultRequestVersion = HttpVersion.Version30,
                DefaultVersionPolicy = HttpVersionPolicy.RequestVersionExact
            };

            Console.WriteLine("--- get https://cloudflare-quic.com/ ---");
            HttpResponseMessage resp = await client.GetAsync("https://cloudflare-quic.com/");
            string body = await resp.Content.ReadAsStringAsync();
            Console.WriteLine(
                $"status: {resp.StatusCode}, version: {resp.Version}, " +
                $"body: {body.Substring(0, Math.Min(100, body.Length))}");
        }
    }
}
