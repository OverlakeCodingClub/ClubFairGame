﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject {

        public float speed = 7f;
        public float jumpSpeed = 7f;

        protected override void ComputeVelocity() {
                Vector2 move = Vector2.zero;

                move.x = Input.GetAxis("Horizontal");

                if (Input.GetButtonDown("Jump") && grounded) {
                        velocity.y = jumpSpeed;
                } else if (Input.GetButtonUp("Jump")) {
                        if (velocity.y > 0) {
                                velocity.y = velocity.y * 0.5f;
                        }
                }

                targetVelocity = move * speed;
        }
}
