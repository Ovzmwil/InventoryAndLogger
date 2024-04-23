using Newtonsoft.Json.Linq;

namespace DevProProjectTest
{
    class InventoryManagement
    {
        public void ListAllProducts(List<JObject> productsList, string sortKey, bool ascending)
        {
            if (ascending)
                productsList = productsList.OrderBy(x => x[sortKey]).ToList();
            else
                productsList = productsList.OrderByDescending(x => x[sortKey]).ToList();

            foreach (JObject product in productsList)
            {
                Console.WriteLine(product.ToString());
            }
            
        }
    }
}