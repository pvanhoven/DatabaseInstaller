using System;
using System.IO;

namespace DatabaseUtility {
    public class DirectoryService : IDirectoryService {
        public string GetTablesDirectory(string root) {
            return Path.Combine(root, "Tables");
        }

        public string GetViewsDirectory(string root) {
            return Path.Combine(root, "Views");
        }

        public string GetStoredProceduresDirectory(string root) {
            return Path.Combine(root, "StoredProcedures");
        }

        public string GetFunctionsDirectory(string root) {
            return Path.Combine(root, "Functions");
        }

        public string GetForeignKeysDirectory(string root) {
            return Path.Combine(root, "ForeignKeys");
        }

        public string GetTriggersDirectory(string root) {
            return Path.Combine(root, "Triggers");
        }

        public void CreateTablesDirectory(string root) {
            CreateDirectory(() => GetTablesDirectory(root));
        }

        public void CreateViewsDirectory(string root) {
            CreateDirectory(() => GetViewsDirectory(root));
        }

        public void CreateStoredProceduresDirectory(string root) {
            CreateDirectory(() => GetStoredProceduresDirectory(root));
        }

        public void CreateFunctionsDirectory(string root) {
            CreateDirectory(() => GetFunctionsDirectory(root));
        }

        public void CreateForeignKeysDirectory(string root) {
            CreateDirectory(() => GetForeignKeysDirectory(root));
        }

        public void CreateTriggersDirectory(string root) {
            CreateDirectory(() => GetTriggersDirectory(root));
        }

        private static void CreateDirectory(Func<string> getPathFunc) {
            string path = getPathFunc();
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
        } 
    }
}
