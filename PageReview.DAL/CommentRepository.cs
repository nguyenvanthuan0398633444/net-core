using Dapper;
using PageReview.DAL.Interface;
using PageReview.Domain.Request.Comment;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Comment;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.DAL
{
    public class CommentRepository : BaseRepository, ICommentRepository
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
                result = await SqlMapper.QueryFirstOrDefaultAsync<Response>(cnn: connection, sql: "sp_DeletedComment", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<IEnumerable<CommentView>> GetsComment(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductId", id);
            var result = await SqlMapper.QueryAsync<CommentView>(cnn: connection, sql: "sp_GetsComment",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<Response> Save(SaveCommentReq request)
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
                parameters.Add("@Text", request.Text);
                parameters.Add("@ProductId", request.ProductId);
                parameters.Add("@UserId", request.UserId);
                result = await SqlMapper.QueryFirstOrDefaultAsync<Response>(cnn: connection, sql: "sp_SaveComment", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }
        public async Task<IEnumerable<CommentView>> GetsReply(int productId, int commentId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductId", productId);
            parameters.Add("@CommentId", commentId);
            var result = await SqlMapper.QueryAsync<CommentView>(cnn: connection, sql: "sp_GetsReply",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public async Task<Response> SaveRep(SaveReplyReq request)
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
                parameters.Add("@Text", request.Text);
                parameters.Add("@ProductId", request.ProductId);
                parameters.Add("@UserId", request.UserId);
                parameters.Add("@CommentId", request.CommentId);
                result = await SqlMapper.QueryFirstOrDefaultAsync<Response>(cnn: connection, sql: "sp_SaveReply", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<CommentView> Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            var result = await SqlMapper.QueryFirstAsync<CommentView>(cnn: connection, sql: "sp_GetComment",
                                                                param: parameters, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
