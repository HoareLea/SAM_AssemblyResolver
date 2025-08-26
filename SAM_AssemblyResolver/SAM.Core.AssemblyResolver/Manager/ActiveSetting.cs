using System.IO;
using System.Reflection;

namespace SAM.Core.AssemblyResolver
{
    public static partial class ActiveSetting
    {
        private static Classes.AssemblyResolver assemblyResolver = Load();

        private static Classes.AssemblyResolver Load()
        {
            Classes.AssemblyResolver result = new Classes.AssemblyResolver();
            result.Enable();


            return result;
        }

        public static void AddManagedDirectory(string? directory)
        {
            assemblyResolver.AddManagedDirectory(directory);
        }

        public static void AddNativeDirectory(string? directory)
        {
            assemblyResolver.AddNativeDirectory(directory);
        }

        public static void AddAssembly(Assembly? assembly)
        {
            if(assembly is null)
            {
                return;
            }

            string path = assembly.Location;
            string directory_Subdirectory = Path.GetDirectoryName(path)!;

            AddManagedDirectory(directory_Subdirectory);
            AddNativeDirectory(Path.Combine(directory_Subdirectory, "runtimes", "win-x64", "native"));

            string directory = Path.GetDirectoryName(directory_Subdirectory)!;

            AddManagedDirectory(directory);
            AddNativeDirectory(Path.Combine(directory, "runtimes", "win-x64", "native"));

        }
    }
}
