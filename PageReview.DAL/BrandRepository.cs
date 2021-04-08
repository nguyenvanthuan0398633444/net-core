using Dapper;
using PageReview.DAL.Interface;
using PageReview.Domain.Request.Brand;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Brand;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.DAL
{
    public class BrandRepository : BaseRepository, IBrandRepository
    {
        public async Task<Response> Delete(int id)
        {
            var result = new Response()
            {
                Id = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                result = await SqlMapper.QueryFirstOrDefaultAsync<Response>(cnn: connection, sql: "sp_DeletedBrand", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<BrandView> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            var result = await SqlMapper.QueryFirstAsync<BrandView>(cnn: connection, sql: "sp_GetBrand",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<BrandView>> Gets()
        {
            return await SqlMapper.QueryAsync<BrandView>(connection, "sp_GetsBrand", CommandType.StoredProcedure);
        }

        public async Task<Response> save(SaveBrandReq request)
        {
            var result = new Response()
            {
                Id = 0,
                Message = "Something went wrong, please contact administrator."
            };
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", request.Id);
                parameters.Add("@Brandname", request.BrandName);
                result = await SqlMapper.QueryFirstOrDefaultAsync<Response>(cnn: connection, sql: "sp_SaveBrand", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }
    }
}
