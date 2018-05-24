using System;

namespace ExecuteAroundMethodPattern
{
    public class DataSourceAccessor<T> where T : IDisposable
    {
        private IDataSourceFactory<T> _dataSourceFactory;

        public DataSourceAccessor(IDataSourceFactory<T> dataSourceFactory)
        {
            _dataSourceFactory = dataSourceFactory;
        }

        public void OnAction(Action<T> act)
        {
            using (var dataContext = _dataSourceFactory.Create())
            {
                act(dataContext);
            }
        }

        public R OnFunction<R>(Func<T, R> func)
        {
            using (var dataContext = _dataSourceFactory.Create())
            {
                return func(dataContext);
            }
        }
    }
}
