using System.Collections.Generic;
using Microsoft.SqlServer.Management.Smo;

namespace DatabaseUtility {
    public interface IDbScripter {
        void ScriptObject(Table table, Options options);

        void ScriptObject(View view, Options options);

        void ScriptObject(StoredProcedure storedProcedure, Options options);

        void ScriptObject(UserDefinedFunction function, Options options);

        void ScriptObject(IEnumerable<Trigger> tableTriggers, string tableName, Options options);
    }
}
