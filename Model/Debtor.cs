using System.ComponentModel.DataAnnotations;
namespace MobileManager.Model
{
    public class Debtor
    {
        private Guid id;

        private string name = "";

        private string phone_number = "";

        private string debt_amount = "";

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
        public string PhoneNumber
        {
            get => phone_number;
            set => phone_number = value;
        }
        [Required]
        public string DebtAmount
        {
            get => debt_amount;
            set => debt_amount = value;
        }
        public string Date
        {
            get => date;
            set => date = value;
        }
    }

}
