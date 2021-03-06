using Admin.Core.Model.Admin;
using Admin.Core.Service.Admin.Auth.Output;
using AutoMapper;

namespace Admin.Core.Service.Admin.Auth
{
    /// <summary>
    /// 映射配置
    /// </summary>
    public class MapConfig : Profile
    {
        public MapConfig()
        {
            CreateMap<UserEntity, AuthLoginOutput>();
        }
    }
}