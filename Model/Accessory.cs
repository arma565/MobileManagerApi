using System.ComponentModel.DataAnnotations;
namespace MobileManager.Model
{
    public class Accessory
    {
        private Guid id;
        private string name = "";
        private string accessory_type = "";
        private string quantity = "";
        private string description = "";
        private string date = DateTime.Now.ToString();

        public Guid Id
        {
            get => id;
            set => id = value;
        }
        [Required]
        public string Name
        {
            get => name;
            set => name = value;
        }
        [Required]
        public string AccessoryType
        {
            get => accessory_type;
            set => accessory_type = value;
        }
        [Required]
        public string Quantity
        {
            get => quantity;
            set => quantity = value;
        }
        public string Description
        {
            get => description;
            set => description = value;
        }
        public string Date
        {
            get => date;
            set => date = value;
        }
    }
}
