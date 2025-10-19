public class House
{
    public int Floors { get; set; }

    public House(int floors)
    {
        Floors = floors;
    }

    public override string ToString()
    {
        string floorWord = Floors switch
        {
            1 => "этажом",
            _ => "этажами"
        };
        return $"дом с {Floors} {floorWord}";
    }
}