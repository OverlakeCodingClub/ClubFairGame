using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

        public float speed;
        private Rigidbody2D rigid2d;

        void Start () {
                rigid2d = GetComponent<Rigidbody2D>();
        }       
	
	void FixedUpdate () {
                float moveHorizontal = Input.GetAxisRaw("Horizontal");
                float moveVertical = Input.GetAxisRaw("Vertical");
                Vector2 movement = new Vector2(moveHorizontal, moveVertical);
                rigid2d.AddForce(movement*speed);
	}
}
