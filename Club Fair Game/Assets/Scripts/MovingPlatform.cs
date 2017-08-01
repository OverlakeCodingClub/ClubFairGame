using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
	public float moveDelta = 5f;
	public float speed = 5f;
	private float baseX = 0;

	void Awake() {
		baseX = transform.position.x;
	}

	void FixedUpdate() {
		float dX = Mathf.PingPong(Time.time * speed, moveDelta);
		Vector3 newPos = new Vector3(baseX + dX, transform.position.y, transform.position.z);
		transform.position = newPos;
	}
}
