using System;

namespace LICDatabaseImport
{
    class baseClass : Savable
    {
        public override void saveToDatabase()
        {
            throw new NotImplementedException();
        }

        public override void parseInfo(string s)
        {
            throw new NotImplementedException();
        }
    }
}
