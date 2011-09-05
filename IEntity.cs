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
	IEntity[] GetChildren();
	IEntity GetParent();
	void Visit(IEntityVisitor v);
}
