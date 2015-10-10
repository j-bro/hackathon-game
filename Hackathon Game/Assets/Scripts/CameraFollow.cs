using UnityEngine;
using System.Collections;

public class CameraFollow: MonoBehaviour {
	public Transform target;

	void LateUpdate (){

		float speed = 5f;
		float smooth = 1.0f - Mathf.Pow (0.5f, Time.deltaTime * speed);
		Vector3 fakedPlayerPos = new Vector3 (target.position.x, target.position.y + 2, transform.position.z);
		transform.position = Vector3.Lerp (transform.position, fakedPlayerPos, smooth);
	}
} 