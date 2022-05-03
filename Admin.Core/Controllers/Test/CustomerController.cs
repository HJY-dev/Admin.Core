using Admin.Core.Common.Dbs;
using Admin.Core.Common.Output;
using Admin.Core.Model.Test;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Admin.Core.Controllers.Test
{
    /// <summary>
    /// 客户管理
    /// </summary>
    public class CustomerController : AreaController
    {
        IFreeSql<PgSqlDb> _freeSql;
        public CustomerController(IFreeSql<PgSqlDb> freeSql)
        {
            _freeSql = freeSql;
        }

        /// <summary>
        /// 查询全部员工
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public IResponseOutput GetAllCustomers()
        {
            var result = _freeSql.Select<Customers>().ToList();
            return ResponseOutput.Ok(result);
        }

        /// <summary>
        /// 查询单条员工
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public IResponseOutput GetCustomers(string id)
        {

            #region 控制器层获取用户信息
            var uid = this.User.FindFirstValue("id");
            var uName = this.User.FindFirstValue("na");
            var uNickName = this.User.FindFirstValue("nn");
            var uTenantId = this.User.FindFirstValue("tt");
            var uTenantType = this.User.FindFirstValue("dit");
            #endregion

            var result = _freeSql.Select<Customers>().Where(x => x.Id == id).First();
            return ResponseOutput.Ok(result);
        }

    }
}
