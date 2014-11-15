using System;
using CommandLine.Text;
using DatabaseUtility;

namespace DatabaseInstaller {
    public class Program {
        public static void Main(string[] args) {
            Options options = new Options();
            if (args.Length == 0) {
                options.Help = true;
            } else if (!CommandLine.Parser.Default.ParseArguments(args, options)) {
                return;
            }

            if (options.Help) {
                HelpText helpText = HelpText.AutoBuild(options);
                Console.WriteLine(helpText.ToString());
                return;
            }

            if (options.Export) {
                ISchemaExporter exporter =
                    new TextFileSchemaExporter(new DbScripter(new FileWriter(), new DirectoryService()), new DirectoryService());

                exporter.Export(options);
                return;
            }

            if (options.Install)
            {
                Installer installer = new Installer();
                installer.Create(options);
            }
        }
    }
}
