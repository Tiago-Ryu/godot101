using Godot;
using System;

public partial class CaveParallax : ParallaxBackground
{
	private double ScrollSpeed = 100;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		this.ScrollOffset += new Vector2((float)(ScrollSpeed  * delta), 0);
	}
}
