/***
 * citystateproto: IEntity.cs
 * Copyright Stuart Golodetz, 2011. All rights reserved.
 ***/

internal interface IEntityVisitor
{
	// TODO
}

internal interface IEntity
{
	// ABSTRACT PROPERTIES
	IEntity[] Children { get; }
	IEntity Parent { get; }

	// PUBLIC ABSTRACT METHODS
	void Visit(IEntityVisitor v);
}
