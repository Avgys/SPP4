
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading.Tasks;

namespace TestsGenerator.Stream
{
    public static class AsyncFileStream
    {
        const string directory = "../../../../GeneratedClasses";
        public static async Task<string> ReadFromFile([DisallowNull] string path)
        {
            using var reader = new StreamReader(path);
            return await reader.ReadToEndAsync();
        }

        public static async Task WriteToFile([DisallowNull] string relativePath, [DisallowNull] string content)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var fullPath = Path.Combine(directory, relativePath);
            await using var writer = new StreamWriter(fullPath);
            await writer.WriteAsync(content);
        }
    }
}
