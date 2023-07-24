using Microsoft.EntityFrameworkCore;
using PCT.Backened.Entities;

namespace PCT.Backened.Repository
{
    public class CMSContentPageItemRepository : Repository<CMSContentPageItem>
    {
        public CMSContentPageItemRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public int UpdateContentPageItemOrder(object[] OrderObjects)
        {
            string customQuery = "";
            int afectados = 0;

            if (OrderObjects != null)
            {
                for (int i = 0; i < OrderObjects.Length; i++)
                {
                    string idIterate = OrderObjects[i].ToString().Replace("[", "").Replace("]", "").Replace("\"", "").Split(',')[0];
                    string orderCount = OrderObjects[i].ToString().Replace("[", "").Replace("]", "").Replace("\"", "").Split(',')[1];

                    customQuery += "update cms_content_page_item set \"Order\"='" + orderCount + "' where \"Id\"='" + idIterate + "'; ";
                }
                afectados = _dataContext.Database.ExecuteSqlRaw(customQuery);
                _dataContext.SaveChanges();
            }
            return afectados;
        }

        public IQueryable<CMSContentPageItem> GetContentPageItemBySectionId(string Section_Id)
        {
            string customQuery = "select cci.* from cms_content_page_item cci\r\n" +
                " where  \"Id_section\"='" + Section_Id + "';";

            var resultData = _dataContext.CMSContentPageItem.FromSqlRaw<CMSContentPageItem>(customQuery);
            return resultData;
        }
        public IQueryable<CMSContentPageItem> GetContentPageItemById(string Id)
        {
            string customQuery = "select cci.* from cms_content_page_item cci\r\n" +
                " where  \"Id\"='" + Id + "';";

            var resultData = _dataContext.CMSContentPageItem.FromSqlRaw<CMSContentPageItem>(customQuery);
            return resultData;
        }
        public IQueryable<CMSContentPageItem> GetContentPageItemByRol(string roleId)
        {
            string customQuery = "select cci.* from cms_content_page_item cci\r\ninner join " +
                "(select * from cms_content_roles where \"Id_roles\"='"+roleId+"' and \"Type\"=4 and \"Status\"=true) ccr on cci.\"Id\"=ccr.\"Id_content\";";

            var resultData = _dataContext.CMSContentPageItem.FromSqlRaw<CMSContentPageItem>(customQuery);
            return resultData;
        }
        public IQueryable<CMSContentPageItem> GetContentPageItemByName(string name)
        {
            string customQuery = "select cci.* from cms_content_page_item cci\r\ninner join " +
                "( select t1.* from cms_content_roles t1\r\n  inner join icl_roles t2 on t1.\"Id_roles\"=t2.\"Id\" " +
                "where t2.\"Name\"='" + name + "' and t1.\"Type\"=1\r\n and t1.\"Status\"=true ) ccr on cci.\"Id\"=ccr.\"Id_content\";  ";

            var resultData = _dataContext.CMSContentPageItem.FromSqlRaw<CMSContentPageItem>(customQuery);
            return resultData;
        }
    }
}
