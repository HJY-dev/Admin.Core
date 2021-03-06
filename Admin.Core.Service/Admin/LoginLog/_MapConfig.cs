using Admin.Core.Model.Admin;
using Admin.Core.Service.Admin.LoginLog.Input;
using AutoMapper;

namespace Admin.Core.Service.Admin.LoginLog
{
    /// <summary>
    /// 映射配置
    /// </summary>
    public class MapConfig : Profile
    {
        public MapConfig()
        {
            CreateMap<LoginLogAddInput, LoginLogEntity>();
        }
    }
}