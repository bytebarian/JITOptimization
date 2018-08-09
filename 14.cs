Employee e = employees.get(name);
  if(e == null)
  {
  	return new None<Employee>();  	
  }
return new Some<Employee>(e);
