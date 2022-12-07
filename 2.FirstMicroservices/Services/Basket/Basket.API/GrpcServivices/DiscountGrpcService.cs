using Discount.gRPC.Protos;

namespace Basket.API.GrpcServivices
{
    public class DiscountGrpcService
    {
        private readonly DiscountProtoServices.DiscountProtoServicesClient _client;

        public DiscountGrpcService(DiscountProtoServices.DiscountProtoServicesClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }
        public async Task<CouponModel> GetDiscount(string productName)
        {
            var discountRequest = new GetDiscountRequest
            {
                ProductName = productName
            };
            return await _client.GetDiscountAsync(discountRequest ?? new GetDiscountRequest { });
        }
    }
}
