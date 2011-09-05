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
