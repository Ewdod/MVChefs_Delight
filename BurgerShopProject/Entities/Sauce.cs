namespace BurgerShopProject.Entities
{
    public class Sauce : Base
    {
        public List<AppUser> AppUsers { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
        public List<Menu> Menus { get; set; } = new();
    }
}
