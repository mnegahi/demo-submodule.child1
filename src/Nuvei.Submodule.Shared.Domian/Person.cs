namespace Nuvei.Submodule.Shared.Domian;
public class Person
{
    public static int Version = 1;
    public string Name { get; set; } = "";
    public int Age { get; set; } = 0;

    public string Gender { get; set; } = "Female";


    public override string ToString()
    {
        return $"{Name}({Age})";
    }
}
