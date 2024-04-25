namespace BlazorApp1.CarModels
{
  public interface ITool
  {
    string GetDescription();
    decimal GetCost();
  }

  public class BasicTool : ITool
  {
    public string GetDescription() => "Basic Tool";

    public decimal GetCost() => 10.00m;
  }
  public abstract class ToolDecorator : ITool
  {
    protected ITool _tool;

    public ToolDecorator(ITool tool)
    {
      _tool = tool;
    }

    public virtual string GetDescription() => _tool.GetDescription();

    public virtual decimal GetCost() => _tool.GetCost();
  }
  public class LaserUpgrade : ToolDecorator
  {
    public LaserUpgrade(ITool tool) : base(tool) { }

    public override string GetDescription() => $"{_tool.GetDescription()}, with Laser";

    public override decimal GetCost() => _tool.GetCost() + 20.00m;
  }

  public class ExtendedWarrantyUpgrade : ToolDecorator
  {
    public ExtendedWarrantyUpgrade(ITool tool) : base(tool) { }

    public override string GetDescription() => $"{_tool.GetDescription()}, with Extended Warranty";

    public override decimal GetCost() => _tool.GetCost() + 5.00m;
  }

}
