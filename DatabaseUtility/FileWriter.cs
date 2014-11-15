using System.Collections.Generic;
using System.IO;

namespace DatabaseUtility {
    public class FileWriter : IFileWriter {
        public void WriteFile(string path, IEnumerable<string> lines) {
            using (StreamWriter streamWriter = new StreamWriter(path)) {
                string script = string.Join("\r\nGO\r\n", lines);
                streamWriter.Write(script);
            }
        }
    }
}
