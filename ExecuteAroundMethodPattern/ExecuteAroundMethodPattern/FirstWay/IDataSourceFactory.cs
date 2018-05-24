using System;

namespace ExecuteAroundMethodPattern
{
    public interface IDataSourceFactory<T> where T : IDisposable
    {
        T Create();
    }
}
