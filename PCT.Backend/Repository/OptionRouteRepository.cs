using Microsoft.EntityFrameworkCore;
using PCT.Backend;
using PCT.Backend.Repository;
using PCT.Backened.Entities;
using System.Linq;

namespace PCT.Backened.Repository
{
    public class OptionRouteRepository : Repository<OptionRoute>
    {
        public OptionRouteRepository(DataContext dataContext) : base(dataContext)
        {
        }
        public IQueryable<OptionRoute> GetOptionRouteById(Guid id)
        {
            return _dataContext.OptionRoutes.Where(o => o.Id == id && o.IsDeleted == false);
        }

        public IQueryable<OptionRoute> GetOptionRoutesByUserId(Guid id)
        {
            string customQuery = "  select tb1.\"Id\", tb1.\"Category\", tb1.\"Name\", tb1.\"Route\", tb1.\"CreateDate\", tb1.\"IsDeleted\"\r\n  " +
                "from icl_options_routes tb1 inner join icl_role_options tb2 on tb1.\"Id\" =tb2.\"OptionId\"\r\n   " +
                " inner join icl_user_roles tb4 on tb2.\"RoleId\"=tb4.\"RoleId\" inner join icl_users tb5 on tb4.\"UserId\"=tb5.\"Id\"\r\n  " +
                "where tb1.\"IsDeleted\" is false and tb2.\"IsDeleted\" is false  and tb4.\"IsDeleted\" is false and tb5.\"IsDeleted\" is false \r\n    " +
                "and tb2.\"ReadPermission\" is true and tb4.\"Enabled\" is true and tb5.\"Id\" = '" + id + "'\r\n  \r\n ";
            var resultData = _dataContext.OptionRoutes.FromSqlRaw<OptionRoute>(customQuery).ToList();
            resultData.ForEach(item => item.Category = "Read");

            customQuery = " select tb1.\"Id\", tb1.\"Category\", tb1.\"Name\", tb1.\"Route\", tb1.\"CreateDate\", tb1.\"IsDeleted\"\r\n  from icl_options_routes tb1 " +
                "inner join icl_role_options tb2 on tb1.\"Id\" =tb2.\"OptionId\"\r\n    inner join icl_user_roles tb4 on tb2.\"RoleId\"=tb4.\"RoleId\" " +
                "inner join icl_users tb5 on tb4.\"UserId\"=tb5.\"Id\"\r\n  where tb1.\"IsDeleted\" is false and tb2.\"IsDeleted\" is false  and tb4.\"IsDeleted\" " +
                "is false and tb5.\"IsDeleted\" is false \r\n    and tb2.\"WritePermission\" is true and tb4.\"Enabled\" is true and tb5.\"Id\" = '" + id + "'\r\n ";
            var resultData2 = _dataContext.OptionRoutes.FromSqlRaw<OptionRoute>(customQuery).ToList();
            resultData2 = resultData2.Select(item => new OptionRoute { Id = item.Id, Category = item.Category, Name=item.Name, Route=item.Route, CreateDate=item.CreateDate, IsDeleted=item.IsDeleted }).ToList();
            resultData2.ForEach(item => item.Category = "Write");

            customQuery = " \r\n  select tb1.\"Id\", tb1.\"Category\", tb1.\"Name\", tb1.\"Route\", tb1.\"CreateDate\", tb1.\"IsDeleted\"\r\n  " +
                "from icl_options_routes tb1 inner join icl_role_options tb2 on tb1.\"Id\" =tb2.\"OptionId\"\r\n    " +
                "inner join icl_user_roles tb4 on tb2.\"RoleId\"=tb4.\"RoleId\" inner join icl_users tb5 on tb4.\"UserId\"=tb5.\"Id\"\r\n  " +
                "where tb1.\"IsDeleted\" is false and tb2.\"IsDeleted\" is false  and tb4.\"IsDeleted\" is false and tb5.\"IsDeleted\" is false \r\n   " +
                " and tb2.\"UpdatePermission\" is true and tb4.\"Enabled\" is true and tb5.\"Id\" = '"+ id + "'";
            var resultData3 = _dataContext.OptionRoutes.FromSqlRaw<OptionRoute>(customQuery).ToList();
            resultData3 = resultData3.Select(item => new OptionRoute { Id = item.Id, Category = item.Category, Name = item.Name, Route = item.Route, CreateDate = item.CreateDate, IsDeleted = item.IsDeleted }).ToList();
            resultData3.ForEach(item => item.Category = "Update");



            var combinedResult = resultData.Concat(resultData2).Concat(resultData3);
            return combinedResult.AsQueryable();
        }

    }
}
