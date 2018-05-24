namespace ExecuteAroundMethodPattern
{
    public class LearnService : DataSourceAccessor<DataSource>, ILearnService
    {
        public LearnService(IDataSourceFactory<DataSource> dataSourceFactory) : base(dataSourceFactory)
        {
        }

        public void StartLearning()
            => OnAction(x => x.Get());

        public Author InterviewAuthor()
            => OnFunction(x => x.Post());
    }
}