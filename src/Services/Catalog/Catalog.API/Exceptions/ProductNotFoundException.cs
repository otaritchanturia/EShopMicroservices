using BuildingBlocks.Exceptions;

namespace Catalog.API.Exceptions
{
    public class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException(Guid id) : base("Product",id)
        {
            
        }

        public ProductNotFoundException(string msg) : base(msg)
        {
            
        }
    }
}
