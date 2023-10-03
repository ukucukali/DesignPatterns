namespace Builder.ExampleTwo.GoodPractice.Builder;

public class CottageBuilder : IHouseBuilder
{
    private House _house = new();

    public void BuildFoundation()
    {
        _house.Foundation = "Concrete";
    }

    public void BuildWalls()
    {
        _house.Walls = "Brick";
    }

    public void BuildRoof()
    {
        _house.Roof = "Shingles";
    }

    public void BuildWindows()
    {
        _house.Windows = "Glass";
    }

    public void BuildDoors()
    {
        _house.Doors = "Wood";
    }

    public void BuildGarden()
    {
        _house.Garden = "Flower Garden";
    }

    public void BuildSwimmingPool()
    {
        _house.SwimmingPool = "No Swimming Pool";
    }

    public House GetHouse()
    {
        return _house;
    }
}