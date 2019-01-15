using Autofac;
using Autofac.Integration.Mvc;
using Own.BLL;
using Own.DAL;
using Own.Interface.Repositories;
using Own.Interface.Services;
using System.Web.Mvc;

namespace Own.MVC.App_Start
{
    public class AutofacConfig
    {
        /// <summary>
        /// 负责调用autofac框架实现业务逻辑层和数据仓储层程序集中的类型对象的创建
        /// 负责创建MVC控制器类的对象(调用控制器中的有参构造函数),接管DefaultControllerFactory的工作
        /// </summary>
        public static void Register()
        {
            //实例化一个autofac的创建容器
            var builder = new ContainerBuilder();

            #region 注入service

            builder.RegisterType<StudentService>().As<IStudentService>();

            #endregion

            #region 注入Repository

            builder.RegisterType<StudentRepository>().As<IStudentRepository>();

            #endregion

            //注入控制控制器
            builder.RegisterControllers(typeof(MvcApplication).Assembly);


            //创建一个Autofac的容器
            var container = builder.Build();
            //将MVC的控制器对象实例 交由autofac来创建
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}