using Dapper;
using PageReview.DAL.Interface;
using PageReview.Domain.Request.Vote;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Vote;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.DAL
{
    public class VoteRepository : BaseRepository, IVoteRepository
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
                result = await SqlMapper.QueryFirstOrDefaultAsync<Response>(cnn: connection, sql: "sp_DeletedVote", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<VoteView> Get(int productId, string UserId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProductId", productId);
                parameters.Add("@UserId", UserId);
                var result = await SqlMapper.QueryFirstAsync<VoteView>(cnn: connection, sql: "sp_GetVote",
                                                                    param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                var vote = new VoteView();
                vote.ProductId = 0;
                return vote;
            }
        }

        public async Task<Response> Save(SaveVoteReq request)
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
                parameters.Add("@Vote", request.Vote);
                parameters.Add("@ProductId", request.ProductId);
                parameters.Add("@UserId", request.UserId);
                result = await SqlMapper.QueryFirstOrDefaultAsync<Response>(cnn: connection, sql: "sp_SaveVote", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }
    }
}
