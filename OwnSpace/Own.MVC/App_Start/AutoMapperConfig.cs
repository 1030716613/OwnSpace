using System;
using AutoMapper;

namespace Own.MVC
{
    public class AutoMapperConfig
    {
        private static volatile bool _mappedBefore;
        private static readonly object _lock = new object();

        public static void InitMappings()
        {
            lock (_lock)
            {
                if (_mappedBefore)
                {
                    return;
                }

                CreateMappingsInternal();
                _mappedBefore = true;
            }
        }

        private static void CreateMappingsInternal()
        {
            Mapper.Initialize(config =>
            {
                #region Basic Types

                // 为AutoMapper配置基本数据类型之间的Map方式。
                // 涉及到具体类型的成员Map时，如有其他需要（如指定decimal的特殊精度），
                // 可在该类型的CreateMap()中使用ForMember()/ResolveUsing()等方法覆盖本段配置中提供的转换方法。
                config.CreateMap<int?, string>().ConvertUsing(src => src.HasValue ? src.Value.ToString() : None);
                config.CreateMap<decimal, string>().ConvertUsing(src => src.ToString("N2"));
                config.CreateMap<decimal?, string>().ConvertUsing(src => src.HasValue ? src.Value.ToString("N2") : None);
                config.CreateMap<double?, string>().ConvertUsing(src => src.HasValue ? src.Value.ToString("N2") : None);
                config.CreateMap<DateTime, string>().ConvertUsing(src => src.ToString("yyyy-MM-dd"));
                config.CreateMap<DateTime?, string>().ConvertUsing(src => src.HasValue ? src.Value.ToString("yyyy-MM-dd") : None);

                #endregion

                #region User => UserViewModel

                //config.CreateMap<User, UserViewModel>()
                //    .ForMember(d => d.Birthday, opt => opt.MapFrom(src => src.Birthday.ToString("yyyy-MM-dd HH:mm")));

                #endregion
            });
        }
    }
}