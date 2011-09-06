/***
 * citystateproto: Model.cs
 * Copyright Stuart Golodetz, 2011. All rights reserved.
 ***/

internal class Model
{
	// PRIVATE VARIABLES
	private IEntity m_tree;

	// PROPERTIES
	public IEntity Tree { get { return m_tree; } }

	// CONSTRUCTORS
	public Model(IEntity tree)
	{
		m_tree = tree;
	}

	// PUBLIC METHODS
	public void Update()
	{
		// TODO
	}

	// PRIVATE METHODS
	// TODO
}
