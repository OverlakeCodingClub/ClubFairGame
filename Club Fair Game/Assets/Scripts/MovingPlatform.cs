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

	// Update is called once per frame
	void Update () {
		float dX = Mathf.PingPong (Time.time * speed, moveDelta);
		transform.position = new Vector3 (baseX + dX, transform.position.y, transform.position.z);
	}
}
