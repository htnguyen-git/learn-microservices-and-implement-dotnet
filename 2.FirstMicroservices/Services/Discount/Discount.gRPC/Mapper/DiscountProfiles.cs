using AutoMapper;
using Discount.gRPC.Entities;
using Discount.gRPC.Protos;

namespace Discount.gRPC.Mapper
{
    public class DiscountProfiles : Profile
    {
        public DiscountProfiles()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();

        }
    }
}
