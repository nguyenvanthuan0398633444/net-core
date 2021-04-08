using Dapper;
using PageReview.DAL.Interface;
using PageReview.Domain.Request.Product;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Product;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.DAL
{
    public class ProductRepository : BaseRepository ,IProductRepository
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
                result = await SqlMapper.QueryFirstOrDefaultAsync<Response>(cnn: connection, sql: "sp_DeletedProduct", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<ProductView> Get(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                var result = await SqlMapper.QueryFirstAsync<ProductView>(cnn: connection, sql: "sp_GetProduct",
                                                                    param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                var product = new ProductView();
                return product;
            }
        }

        public async Task<IEnumerable<ProductView>> Gets()
        {
            return await SqlMapper.QueryAsync<ProductView>(connection, "sp_GetsProduct", CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ProductView>> GetsByBrandId(int brandId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BrandId", brandId);
            var result = await SqlMapper.QueryAsync<ProductView>(cnn: connection, sql: "sp_GetProductbyBrand",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<ProductView>> GetsByCategoryId(int categoryId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@CategoryId", categoryId);
            var result = await SqlMapper.QueryAsync<ProductView>(cnn: connection, sql: "sp_GetProductbyCategory",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<ProductView>> GetsByCharacter(string Keyword)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Search", Keyword);
            var result = await SqlMapper.QueryAsync<ProductView>(cnn: connection, sql: "sp_Search",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<ProductView>> GetsByComment(int Numbercomment)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MucComment", Numbercomment);
            var result = await SqlMapper.QueryAsync<ProductView>(cnn: connection, sql: "sp_GetsProductbyComment",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<ProductView>> GetsByPrice(double Price)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MucGia", Price);
            var result = await SqlMapper.QueryAsync<ProductView>(cnn: connection, sql: "sp_GetsProductbyPrice",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<IEnumerable<ProductView>> GetsByVote(int Numbervote)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MucVote", Numbervote);
            var result = await SqlMapper.QueryAsync<ProductView>(cnn: connection, sql: "sp_GetsProductbyVote",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<Response> Save(SaveProductReq request)
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
                parameters.Add("@ProductName", request.Productname);
                parameters.Add("@CategoryId", request.CategoryId);
                parameters.Add("@BrandId", request.BrandId);
                parameters.Add("@Price", request.Price);
                parameters.Add("@Description", request.Description);
                parameters.Add("@StatusProduct", request.StatusProduct);
                parameters.Add("@DateofSale", request.DateofSale);
                parameters.Add("@UserId", request.UserId);
                parameters.Add("@Image", request.Image);
                parameters.Add("@Images", request.Images);

                result = await SqlMapper.QueryFirstOrDefaultAsync<Response>(cnn: connection, sql: "sp_SaveProduct", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                return result;
            }
        }
    }
}
