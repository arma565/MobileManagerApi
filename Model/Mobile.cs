using System.ComponentModel.DataAnnotations;

public class Mobile
{
    private int id = 0;
    private string brand = "";
    private string name = "";
    private string problem_description = "";
    private string problem_type = Type.HARDWARE.ToString();
    private string date = DateTime.Now.ToString();

    public int Id
    {
        get => id;
        set => id = value;
    }
    [Required]
    public string Brand
    {
        get => brand;
        set => brand = value;
    }
    [Required]
    public string Name
    {
        get => name;
        set => name = value;
    }
    [Required]
    public string ProblemDescription
    {
        get => problem_description;
        set => problem_description = value;
    }
    public string Date
    {
        get => date;
        set => date = value;
    }
    public string ProblemType
    {
        get => problem_type;
        set => problem_type = value;
    }
}
