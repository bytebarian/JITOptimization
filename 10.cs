class Employee
{
 	static readonly Employee Null = new NullEmployee();
 	private class NullEmployee : Employee
 	{
	  public override void SomeMethod()
	  {
		//purposfully provides no behavior
	  }
 	}
}
