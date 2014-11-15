namespace DatabaseUtility {
    public interface IDirectoryService {
        string GetTablesDirectory(string root);

        string GetViewsDirectory(string root);

        string GetStoredProceduresDirectory(string root);

        string GetFunctionsDirectory(string root);

        string GetForeignKeysDirectory(string root);

        string GetTriggersDirectory(string root);

        void CreateTablesDirectory(string root);

        void CreateViewsDirectory(string root);

        void CreateStoredProceduresDirectory(string root);

        void CreateFunctionsDirectory(string root);

        void CreateForeignKeysDirectory(string root);

        void CreateTriggersDirectory(string root);
    }
}
