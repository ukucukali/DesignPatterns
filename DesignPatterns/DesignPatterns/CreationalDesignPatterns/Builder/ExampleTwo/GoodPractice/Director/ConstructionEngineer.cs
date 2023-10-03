namespace Builder.ExampleTwo.GoodPractice.Director;

public class ConstructionEngineer
{
    private readonly IHouseBuilder _houseBuilder;

    public ConstructionEngineer(IHouseBuilder houseBuilder)
    {
        _houseBuilder = houseBuilder;
    }

    public House BuildHouse()
    {
        _houseBuilder.BuildFoundation();
        _houseBuilder.BuildWalls();
        _houseBuilder.BuildRoof();
        _houseBuilder.BuildWindows();
        _houseBuilder.BuildDoors();
        _houseBuilder.BuildGarden();
        _houseBuilder.BuildSwimmingPool();
        return _houseBuilder.GetHouse();
    }
}