namespace SmartHome;

public class SmartAppliance
{
  protected uint nUsed;

  protected string name;

  public SmartAppliance(string name) 
  {
    nUsed = 0;
    this.name = name;
  }
}