
namespace Builder.ExampleTwo.GoodPractice;

public interface IHouseBuilder
{
    void BuildFoundation();
    void BuildWalls();
    void BuildRoof();
    void BuildWindows();
    void BuildDoors();
    void BuildGarden();
    void BuildSwimmingPool();
    House GetHouse();
}