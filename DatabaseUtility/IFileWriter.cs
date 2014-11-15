using System.Collections.Generic;

namespace DatabaseUtility {
    public interface IFileWriter {
        void WriteFile(string path, IEnumerable<string> lines);
    }
}
