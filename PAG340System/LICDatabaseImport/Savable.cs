namespace LICDatabaseImport
{
    abstract class Savable
    {
        public abstract void saveToDatabase();
        public abstract void parseInfo(string s);
    }
}
