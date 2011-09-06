/***
 * citystateproto: CompositeEntity.cs
 * Copyright Stuart Golodetz, 2011. All rights reserved.
 ***/

using System;

internal abstract class CompositeEntity : IEntity
{
	// PROPERTIES
	public IEntity[] Children { get { throw new Exception(); } }
	public IEntity Parent { get; set; }

	// PUBLIC METHODS
	public void AddChild(IEntity e)
	{
		// TODO
	}

	public void RemoveChild(IEntity e)
	{
		// TODO
	}

	public void Visit(IEntityVisitor v)
	{
		// TODO
	}
}
