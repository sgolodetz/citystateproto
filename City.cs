/***
 * citystateproto: City.cs
 * Copyright Stuart Golodetz, 2011. All rights reserved.
 ***/

internal class City : CompositeEntity
{
	// PROPERTIES
	public string Name { get; set; }

	// CONSTRUCTORS
	public City(string name)
	{
		Name = name;
	}
}
