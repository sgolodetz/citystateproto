using System;

internal abstract class EntityComposite : IEntity
{
	public IEntity[] GetChildren()
	{
		// NYI
		throw new Exception();
	}

	public IEntity GetParent()
	{
		// NYI
		throw new Exception();
	}

	public void Visit(IEntityVisitor v)
	{
		// TODO
	}
}