using ItShop.Models.Models;
using ItShop.Services;
using ItShop.Web.Infastructure.Core;
using System.Net.Http;
using System.Web.Http;
using ItShop.Web.Infastructure.Extensions;
using AutoMapper;
using ItShop.Web.Models;
using System.Collections.Generic;

namespace ItShop.Web.API
{
    [RoutePrefix("Api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;

        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) : base(errorService)
        {
            this._postCategoryService = postCategoryService;

        }

        public HttpResponseMessage Create(HttpRequestMessage requestMessage, PostCategoryViewModel postCategoryVM)
        {
            return CreateResponse(requestMessage, () =>
            {
                HttpResponseMessage responseMessage = null;

                if (!ModelState.IsValid)
                {
                    responseMessage = requestMessage.CreateResponse(System.Net.HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    PostCategory newPostCategory = new PostCategory();
                    newPostCategory.UpdatePostCategory(postCategoryVM);

                    var data = _postCategoryService.Add(newPostCategory);
                    _postCategoryService.Save();
                    responseMessage = requestMessage.CreateResponse(System.Net.HttpStatusCode.Created, data);
                }
                return responseMessage;
            });
        }

        [Route("Getall")]
        public HttpResponseMessage Get(HttpRequestMessage requestMessage)
        {
            return CreateResponse(requestMessage, () =>
            {

                var data = _postCategoryService.GetAll();
                var listVM = Mapper.Map<List<PostCategoryViewModel>>(data);
                HttpResponseMessage responseMessage = requestMessage.CreateResponse(System.Net.HttpStatusCode.OK ,listVM);
                return responseMessage;
            });
        }
    }
}