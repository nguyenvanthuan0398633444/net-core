using System;
using System.Data;
using System.Data.SqlClient;

namespace PageReview.DAL
{
    public class BaseRepository
    {
        protected IDbConnection connection;

        public BaseRepository()
        {
            connection = new SqlConnection(@"workstation id=PageReviewDB.mssql.somee.com;packet size=4096;user id=HoangCG_SQLLogin_1;pwd=p2zpzmscln;data source=PageReviewDB.mssql.somee.com;persist security info=False;initial catalog=PageReviewDB");
            //connection = new SqlConnection(@"Data Source=AITD201507001;Initial Catalog=PageReview;Integrated Security=True");
        }
    }
}
