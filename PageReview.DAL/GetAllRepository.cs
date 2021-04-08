using Dapper;
using PageReview.DAL.Interface;
using PageReview.Domain.Response.GetAll;
using PageReview.Domain.Response.Product;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.DAL
{
    public class GetAllRepository : BaseRepository, IGetAllRepository
    {
        public async Task<ProductView> GetProductCommingFirst()
        {
            try
            {
                return await SqlMapper.QueryFirstAsync<ProductView>(connection, "sp_GetProductCommingfirst", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                var product = new ProductView();
                return product;
            }
        }

        public async Task<ProductView> Gets1ProductComment()
        {
            return await SqlMapper.QueryFirstAsync<ProductView>(connection, "sp_Gets1ProductComment", CommandType.StoredProcedure);
        }

        public async Task<ProductView> Gets1ProductVote()
        {
            return await SqlMapper.QueryFirstAsync<ProductView>(connection, "sp_Gets1ProductVote", CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ProductView>> Gets5GetsExpensive()
        {
            return await SqlMapper.QueryAsync<ProductView>(connection, "sp_Gets6ProductExpensive", CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ProductView>> Gets5ProductComment()
        {
            return await SqlMapper.QueryAsync<ProductView>(connection, "sp_Gets5ProductComment", CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ProductView>> Gets5ProductCommingsoon()
        {
            return await SqlMapper.QueryAsync<ProductView>(connection, "sp_Gets5ProductCommingsoon", CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ProductView>> Gets5Productnew()
        {
            return await SqlMapper.QueryAsync<ProductView>(connection, "sp_Gets5Productnew", CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ProductView>> Gets5Productrandom()
        {
            return await SqlMapper.QueryAsync<ProductView>(connection, "sp_Gets5Productrandom", CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ProductView>> Gets5ProductVote()
        {
            return await SqlMapper.QueryAsync<ProductView>(connection, "sp_Gets5ProductVote", CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ProductView>> Gets6ProductsameBrand(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BrandId", id);
            var result = await SqlMapper.QueryAsync<ProductView>(cnn: connection, sql: "sp_Gets6ProductsameBrand",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<ProductView>> Gets6ProductsameCategory(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CategoryId", id);
            var result = await SqlMapper.QueryAsync<ProductView>(cnn: connection, sql: "sp_Gets6ProductsameCategory",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<GetsImage>> GetsGetsImage(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductId", id);
            var result = await SqlMapper.QueryAsync<GetsImage>(cnn: connection, sql: "sp_GetsImage",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<StatusProduct>> GetsProductStatus()
        {
            return await SqlMapper.QueryAsync<StatusProduct>(connection, "sp_GetStatusProduct", CommandType.StoredProcedure);
        }
    }
}
