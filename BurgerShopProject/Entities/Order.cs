using BurgerShopProject.Enums;

namespace BurgerShopProject.Entities
{
    public class Order : Base
    {
        public List<Burger> _burgers { get; set; } = new();
        public List<SideProduct> _sideProducts { get; set; } = new();
        public List<Beverages> _beverages { get; set; } = new ();
        public List<Sauce> _sauces { get; set; } = new();
        public AppUser _appUser { get; set; } = new();


        public Order()
        {
            
        }

        public Order(List<Burger> burgers, List<SideProduct> sideProducts, List<Beverages> beverages, List<Sauce> sauces, AppUser appUser)
        {
            _burgers = burgers;
            _sideProducts = sideProducts;
            _beverages = beverages;
            _sauces = sauces;
            _appUser = appUser;
        }

        private decimal _totalPrice;

        public decimal TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = Calculate();}
        }



        public decimal Calculate()
        {
            decimal totalPrice = 0;

            foreach (var item in _burgers)
            {
                totalPrice += item.Price * item.Quantity;
            }

            foreach (var item in _sideProducts)
            {
                totalPrice += item.Price * item.Quantity;
            }

            foreach (var item in _beverages)
            {
                totalPrice += item.Price * item.Quantity;
            }

            foreach (var item in _sauces)
            {
                totalPrice += item.Price * item.Quantity;
            }


            return totalPrice;

        }

    }
}
