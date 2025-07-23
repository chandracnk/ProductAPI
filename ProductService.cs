using ProductAPI.Model;
using System.Text.Json;

namespace ProductAPI
{
    public class ProductService
    {
        private readonly Product6205 _product;

        public ProductService(IWebHostEnvironment env)
        {
            var jsonPath = Path.Combine(env.ContentRootPath, "Data", "6205.json");
            var json = File.ReadAllText(jsonPath);
            _product = JsonSerializer.Deserialize<Product6205>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public string QueryProducts(string userInput)
        {
            userInput = userInput.ToLower();

            // Check in Dimensions  
            var dimension = _product.Dimensions.FirstOrDefault(d => d.Name.ToLower().Contains(userInput));

            // Check in Properties  
            var properties = _product.Properties.FirstOrDefault(p => p.Name.ToLower().Contains(userInput));

            if (dimension != null)
            {
                return $"The {dimension.Name} of 6205 bearing is {dimension.Value} {dimension.Unit}";
            }
            else if (properties != null)
            {
                return $"{properties.Name} of 6205 bearing is {properties.Value}";
            }
            else
            {
                return "Sorry, I could not find the requested information about 6205.";
            }
        }
    }
}
