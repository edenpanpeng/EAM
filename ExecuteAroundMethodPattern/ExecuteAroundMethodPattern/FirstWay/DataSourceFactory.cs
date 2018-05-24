namespace ExecuteAroundMethodPattern
{
    public sealed class DataSourceFactory : IDataSourceFactory<DataSource>
    {
        public DataSource Create() => new DataSource();
    }
}
