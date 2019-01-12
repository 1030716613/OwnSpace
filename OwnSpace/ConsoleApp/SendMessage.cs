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

            int i = 0;

            foreach (var student in studentList)
            {
                string insert = $@"insert into student (Name,Age,Address,Birthday)
                              values('{student.Name}+{i}',{student.Age},'{student.Address}','{student.BirthDay}')";

                SqlHelper.Execute(insert);

                i++;

            }
        }
    }
}
