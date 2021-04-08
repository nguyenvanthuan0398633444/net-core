using Dapper;
using PageReview.DAL.Interface;
using PageReview.Domain.Request.Category;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Category;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.DAL
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
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
                result = await SqlMapper.QueryFirstOrDefaultAsync<Response>(cnn: connection,
                                                                        sql: "sp_DeletedCategory",
                                                                        param: parameters,
                                                                        commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<CategoryView> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            var result = await SqlMapper.QueryFirstAsync<CategoryView>(cnn: connection,
                                                                    sql: "sp_GetCategory",
                                                                    param: parameters,
                                                                    commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<CategoryView>> Gets()
        {
            DynamicParameters parameters = new DynamicParameters();
            var result = await SqlMapper.QueryAsync<CategoryView>(cnn: connection,
                                                                    sql: "sp_GetsCategory",
                                                                    commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<Response> Save(SaveCategoryReq request)
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
                parameters.Add("@CategoryName", request.CategoryName);

                result = await SqlMapper.QueryFirstOrDefaultAsync<Response>(cnn: connection,
                                                                    sql: "sp_SaveCategory",
                                                                    param: parameters,
                                                                    commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {

                return result;
            }
        }
    }
}
