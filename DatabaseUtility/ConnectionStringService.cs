namespace DatabaseUtility {
    public class ConnectionStringService {
        public string GetDatabaseConnectionString(Options options) {
            return string.Format("Server={0};Initial Catalog={1};Integrated Security=SSPI", options.Server, options.Name);
        }

        public string GetServerConnectionString(Options options) {
            return string.Format("Server={0};Integrated Security=SSPI", options.Server);
        }

    }
}
