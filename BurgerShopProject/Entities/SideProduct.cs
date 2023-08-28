using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace BurgerShopProject.Entities
{
    public class SideProduct : Base
    {
        [NotMapped]
        public Size Size { get; set; }
        public List<AppUser> AppUsers { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
        public List<Menu> Menus { get; set; } = new();

    }
}
