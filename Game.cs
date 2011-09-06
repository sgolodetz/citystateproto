/***
 * citystateproto: Game.cs
 * Copyright Stuart Golodetz, 2011. All rights reserved.
 ***/

public class Game
{
	// PRIVATE VARIABLES
	private Model m_model;

	// PUBLIC METHODS
	public Game()
	{
		World world = new World();
		world.AddChild(new City("Tamoma"));
		m_model = new Model(world);
	}

	public void Run()
	{
		m_model.Update();
	}

	public static void Main()
	{
		Game game = new Game();
		game.Run();
	}
}
