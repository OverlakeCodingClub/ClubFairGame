using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : PhysicsObject {
	public float moveDelta = 5f;
	public float speed = 5f;

	protected override void ComputeVelocity() {
		Vector2 move = Vector2.zero;
		float dX = Mathf.PingPong (Time.time * speed, moveDelta);

		move.x = dX;
		

		targetVelocity = move;
	}
}
