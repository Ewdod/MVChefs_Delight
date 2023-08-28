namespace BurgerShopProject.Entities
{
    public class Menu : Base
    {
        public List<Burger> _burgers { get; set; } = new();
        public List<SideProduct> _sideProducts { get; set; } = new();
        public List<Beverages> _beverages { get; set; } = new();
        public List<Sauce> _sauces { get; set; } = new();
        public List<AppUser> AppUsers { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
        public Menu()
        {
            
        }
        public Menu(List<Burger> burgers, List<SideProduct> sideProducts, List<Beverages> beverages, List<Sauce> sauces)
        {
            _burgers = burgers;
            _sideProducts = sideProducts;
            _beverages = beverages;
            _sauces = sauces;
        }





    }
}
