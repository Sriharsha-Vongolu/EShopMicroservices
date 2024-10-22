namespace Catalog.Api.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
         : ICommand<CreateProuctResult>;
    public record CreateProuctResult(Guid Id);
    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProuctResult>
    {
        public async Task<CreateProuctResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            //Create product entity
            var product = new Product
            { 
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price,
            };

            //Todo: Save data to DB
            //Return CreateProuctResult Result
            return new CreateProuctResult(Guid.NewGuid());
        }
    }
}
