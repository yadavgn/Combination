using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Text;

namespace Brick.MSTestRunner
{
    /// <summary>
    /// Facade for the test runner application.
    /// </summary>
    public class Facade
    {
        /// <summary>
        /// Validates the command-line args.
        /// </summary>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        public bool ValidateArgs(string[] args)
        {
            if (args.Count() != 1)
            {
                WriterHeader("Brick.MSTestRunner alpha 0.1");
                Console.WriteLine("This tool executes unit tests created with the MSTest framework.");
                Console.WriteLine("Usage: Brick.MSTestRunner.exe [AssemblyName(.dll)]");
                Console.WriteLine("       AssemblyName - name of the assembly containing the unit tests.");
                Console.WriteLine("                      The assembly must be in the same directory.");
                Console.WriteLine();
                Console.WriteLine("Examples:");
                Console.WriteLine("Brick.MSTestRunner.exe Brick.DemoTest.UnitTest");
                Console.WriteLine("Brick.MSTestRunner.exe Brick.DemoTest.UnitTest.dll");
                return false;
            }

            string assemblyPath = GetFullAssemblyPath(args[0]);
            if (!File.Exists(assemblyPath))
            {
                Console.WriteLine("The specified assembly could not be found at '{0}'.", assemblyPath);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Runs the tests.
        /// </summary>
        /// <param name="assemblyName">Name of the assembly.</param>
        public void RunTests(string assemblyName)
        {
            WriterHeader("Brick.MSTestRunner alpha 0.1");
            Console.WriteLine();

            try
            {
                // 1. Load the assembly.
                Assembly assembly = GetAssembly(GetAssemblyName(assemblyName));

                // 2. Get test classes.
                var classes = assembly.GetTypes()
                    .Where(t => t.GetCustomAttributes(typeof(TestClassAttribute), false).Count() != 0)
                    .OrderBy(t => t.Name);

                if (classes == null || classes.Count() == 0)
                    return;

                // 3. Get test methods for each class.
                Stats stats = new Stats();
                foreach (var current in classes)
                {
                    var methods = current.GetMethods()
                        .Where(m => m.GetCustomAttributes(typeof(TestMethodAttribute), false).Count() != 0)
                        .OrderBy(m => m.Name);

                    if (methods == null || methods.Count() == 0)
                        continue;

                    string title = String.Format("{0}: {1} test(s)", current.FullName, methods.Count());
                    WriterHeader(title);
                    Console.WriteLine();

                    object instance = assembly.CreateInstance(current.FullName);

                    // 4. Run test methods.
                    foreach (var method in methods)
                    {
                        try
                        {
                            stats.AddGlobalCount();
                            Console.WriteLine("Running test: {0}", method.Name);
                            stats.StartLocalTime();
                            method.Invoke(instance, null);
                            Console.WriteLine("  Passed ({0} s).", stats.LocalTime.TotalSeconds);
                            stats.AddGlobalPassCount();
                        }
                        catch (Exception ex)
                        {
                            stats.AddGlobalFailCount();
                            // Check for a failing assert.
                            if (ex.InnerException != null && ex.InnerException.GetType() == typeof(AssertFailedException))
                            {
                                Console.WriteLine("  Failed: {0} ({1} s).", ex.InnerException.Message, stats.LocalTime.TotalSeconds);
                                continue;
                            }

                            // Unexpected error.
                            Console.WriteLine("  An unexpected error occured: {0}", ex.Message);
                            if (ex.InnerException != null)
                                Console.WriteLine("  Reason: {0}", ex.InnerException.Message);
                        }
                        finally
                        {
                            stats.ResetLocalTime();
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine(stats.GetFinalResult());
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                // Unexpected error.
                Console.WriteLine("  An unexpected error occured: {0}", ex.Message);
                if (ex.InnerException != null)
                    Console.WriteLine("  Reason: {0}", ex.InnerException.Message);
            }
        }

        private static Assembly GetAssembly(string name)
        {
            Assembly assembly = Assembly.Load(name);
            string location = assembly.Location + ".config";
            string configFileName = name + ".config";

            if (File.Exists(location))
            {
                AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", location);
                Console.WriteLine(String.Format("Configuration file loaded from: '{0}'", configFileName));
                Console.WriteLine();
            }
            return assembly;
        }

        private void WriterHeader(string title)
        {
            Console.WriteLine(title);
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (++i < title.Length + 1)
                sb.Append("-");

            Console.WriteLine(sb);
        }

        private string GetFullAssemblyPath(string path)
        {
            if (path.ToLower().EndsWith(".dll"))
                return Path.Combine(Environment.CurrentDirectory, path);

             return Path.Combine(Environment.CurrentDirectory, path + ".dll");
        }

        private string GetAssemblyName(string assemblyName)
        {
            if (assemblyName.ToLower().EndsWith(".dll"))
                return assemblyName.Replace(".dll", String.Empty);

            return assemblyName;
        }
    }
}
