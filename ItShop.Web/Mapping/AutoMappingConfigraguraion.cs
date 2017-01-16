using AutoMapper;
using ItShop.Models.Models;
using ItShop.Web.Models;

namespace ItShop.Web.Mapping
{
    public class AutoMappingConfigraguraion
    {
        // khai báo static :
        // - no không phụ thuộc vào đối tượng nào . chỉ cần gọi tên lớp.tên pt
        //- sử dụng để lưu trữ giá trị xuyên xuốt trong 1 quá trình nào đó
        public static void Config()
        {
            Mapper.Initialize(mp=>mp.CreateMap<Footer, FooterViewModel>());
            Mapper.Initialize(mp=>mp.CreateMap<Menu, MenuViewModel>());
            Mapper.Initialize(mp=>mp.CreateMap<MenuGroup, MenuGroupViewModel>());
            Mapper.Initialize(mp=>mp.CreateMap<Order, OrderViewModel>());
            Mapper.Initialize(mp=>mp.CreateMap<PostCategory, PostCategoryViewModel>());
            Mapper.Initialize(mp=>mp.CreateMap<PostTag, PostTagViewModel>());
            Mapper.Initialize(mp=>mp.CreateMap<Post, PostTagViewModel>());
            Mapper.Initialize(mp=>mp.CreateMap<Tag, TagViewModel>());
        }
    }
}