using ItShop.Models.Models;
using ItShop.Web.Models;

namespace ItShop.Web.Infastructure.Extensions
{
    public static class EntityExtentions
    {
        public static void UpdatePost(this Post post, PostViewModel postVm)
        {
            post.ID = postVm.ID;
            post.Name = postVm.Name;
            post.CategoryID = postVm.CategoryID;
            post.Alias = postVm.Alias;
            post.Content = postVm.Content;
            post.Descaption = postVm.Descaption;
            post.Image = postVm.Image;
            post.HomeFlag = postVm.HomeFlag;
            post.HotFlag = postVm.HotFlag;
            post.ViewCount = postVm.ViewCount;
            post.MetaKeyword = postVm.MetaKeyword;
            post.MetaDescaption = postVm.MetaDescaption;
            post.CreateAt = postVm.CreateAt;
            post.UpdateAt = postVm.UpdateAt;
            post.Status = postVm.Status;
        }

        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVm)
        {

            postCategory.ID = postCategoryVm.ID;
            postCategory.Name = postCategoryVm.Name;
            postCategory.Descaption = postCategoryVm.Descaption;
            postCategory.Image = postCategoryVm.Image;
            postCategory.Alias = postCategoryVm.Alias;
            postCategory.ParentId = postCategoryVm.ParentId;
            postCategory.DisplayOrder = postCategoryVm.DisplayOrder;
            postCategory.HomeFlag = postCategoryVm.HomeFlag;
        }
    }
}