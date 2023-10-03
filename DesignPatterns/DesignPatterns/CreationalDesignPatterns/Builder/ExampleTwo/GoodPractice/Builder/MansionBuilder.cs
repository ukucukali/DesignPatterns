namespace Builder.ExampleTwo.GoodPractice.Builder;

public class MansionBuilder : IHouseBuilder
{
    private House _house = new House();

    public void BuildFoundation()
    {
        _house.Foundation = "Reinforced Concrete";
    }

    public void BuildWalls()
    {
        _house.Walls = "Marble";
    }

    public void BuildRoof()
    {
        _house.Roof = "Luxury Tiles";
    }

    public void BuildWindows()
    {
        _house.Windows = "Double-Glazed Glass";
    }

    public void BuildDoors()
    {
        _house.Doors = "Ornate Wood";
    }

    public void BuildGarden()
    {
        _house.Garden = "Huge Landscape Garden";
    }

    public void BuildSwimmingPool()
    {
        _house.SwimmingPool = "Olympic-sized Swimming Pool";
    }

    public House GetHouse()
    {
        return _house;
    }
}