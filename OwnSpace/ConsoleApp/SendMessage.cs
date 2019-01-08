using ConsoleApp.Models;
using log4net;

namespace ConsoleApp
{
    public class SendMessage : IWork
    {
        ILog Logger = LogManager.GetLogger(typeof(SendMessage));

        public void DoWork()
        {
            Logger.Info("开始工作");
            const string query = @"SELECT * FROM Student";

            var studentList = SqlHelper.Query<Student>(query);
        }
    }
}
