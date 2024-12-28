using System.ComponentModel.DataAnnotations;

public class Debtor
{
    private int id = 0;

    private string name = "";

    private string phone_number = "";

    private string debt_amount = "";

    private string date = DateTime.Now.ToString();

    public int Id
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
