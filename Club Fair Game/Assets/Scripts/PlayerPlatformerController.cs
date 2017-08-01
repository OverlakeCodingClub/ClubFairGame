﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject {

	public float maxSpeed = 7f;
	public float jumpTakeoffSpeed = 7f;

	void Start() {

	}

	protected override void ComputeVelocity() {
		Vector2 move = Vector2.zero;

		move.x = Input.GetAxis("Horizontal");

		if (Input.GetButtonDown("Jump") && grounded) {
			velocity.y = jumpTakeoffSpeed;
		} else if (Input.GetButtonUp("Jump")) {
			if (velocity.y > 0) {
				velocity.y = velocity.y * 0.5f;
			}
		}

		targetVelocity = move * maxSpeed;
	}
}
