public class Some<T>
 {
  	private readonly T t;
  	public Some(T t) 
	{
  		this.t = t;
  	}

  	public bool HasValue() 
	{
 		 return true;
  	}
  	public T Value() 
	{
  		return t;
  	}
}

public class None<T> 
{
  	public bool HasValue() 
	{
 		 return false;
 	}
  	public T Value()
	{
  		throw new NotImplementedException;
  	}
}
