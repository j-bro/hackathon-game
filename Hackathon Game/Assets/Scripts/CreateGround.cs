using UnityEngine;
using System.Collections;

public class CreateGround : MonoBehaviour {
	public GameObject groundPiece;

	// Use this for initialization
	void Start () {
		for (int i = -10; i < 100; i++) {
			Instantiate (groundPiece, new Vector3 (i, groundPiece.transform.position.y, groundPiece.transform.position.z), new Quaternion(0, 0, 0, 0));
		}
	}

	void createDeepGroundBlock(Vector3 position) {
		
	}

	void createSurfaceBlock(Vector3 position) {

	}

	void createPlatformOfLength(Vector3 position) {

	}

	// Update is called once per frame
	void Update () {
	
	}
}
