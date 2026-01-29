using System.Security.Cryptography;
using System.Text.Json;

namespace NaaS;

public class Program {
    private static readonly RandomNumberGenerator Rng = RandomNumberGenerator.Create();

    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);

        var app = builder.Build();
        //app.UseHttpsRedirection();

        IWebHostEnvironment _env = builder.Environment;
        string dataPath = Path.Combine(_env.ContentRootPath, "reasons.json");
        string data = File.ReadAllText(dataPath);
        string[] reasons = JsonSerializer.Deserialize<string[]>(data)!;

        app.MapGet("/", () => {
            string no = reasons[GetRandom(reasons.Length-1)];
            return Results.Json(no);
        });

        app.Run();
    }
    private static int GetRandom(int max, int min = 0) {
        if (max <= min) {
            throw new ArgumentOutOfRangeException(nameof(max), "max must be greater than min.");
        }

        byte[] bytes = new byte[4];
        Rng.GetBytes(bytes);
        uint val = BitConverter.ToUInt32(bytes, 0);

        int range = max - min;
        uint maxValid = uint.MaxValue - (uint.MaxValue % (uint)range);

        while (val > maxValid) {
            Rng.GetBytes(bytes);
            val = BitConverter.ToUInt32(bytes, 0);
        }

        return (int)(min + (val % range));
    }
}
