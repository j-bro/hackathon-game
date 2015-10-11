using UnityEngine;
using System.Collections;

public class CreateGround : MonoBehaviour {

	public int groundLevel;

	public GameObject groundPiece;

	public GameObject deepGroundPiece;
	public GameObject topGrassBlock;
	public GameObject topLeftGrassBlock;
	public GameObject topRightGrassBlock;

	public GameObject platformMiddle;
	public GameObject platformLeft;
	public GameObject platformRight;

	// Use this for initialization
	void Start () {
		groundLevel = -4;
		createGroundOfLength (100, 0);

		createPlatformOfLength (new Vector3 (0, 0, 0), 5);

		createPlatformOfLength (new Vector3 (10, 4, 0), 15);

		createMountainOfHeight (10, 20);
	}

	void createDeepGroundBlock(Vector3 position) {
		Instantiate (deepGroundPiece, position, new Quaternion (0, 0, 0, 0));
	}

	void createSurfaceBlock(Vector3 position) {
		Instantiate (topGrassBlock, position, new Quaternion (0, 0, 0, 0));
	}

	void createGroundOfLength(int length, int topLevel) {
		for (int i = -10; i < length - 10; i++) {
			Instantiate (groundPiece, new Vector3 (i, groundPiece.transform.position.y, groundPiece.transform.position.z), new Quaternion (0, 0, 0, 0));
		}
	}

	void createMountainOfHeight(int height, int xPos) {
		// first half of mountain
		for (int i = 0; i < height; i++) {
			for (int j = 0; j < i; j++) {
				createDeepGroundBlock(new Vector3(xPos + i, groundLevel + j, 0));
			}
			Instantiate (topLeftGrassBlock, new Vector3(xPos + i, groundLevel + i, 0), new Quaternion(0, 0, 0, 0));
		}
		// second half of mountain
		for (int i = height; i < 0; i--) {
			for (int j = 0; j < i; j++) {
				createDeepGroundBlock(new Vector3(xPos + i, groundLevel + j, 0));
			}
			Instantiate (topRightGrassBlock, new Vector3(xPos + i, groundLevel + i, 0), new Quaternion(0, 0, 0, 0));
		}
	}

	void createPlatformOfLength(Vector3 position, int length) {
		Instantiate (platformLeft, position, new Quaternion(0, 0, 0, 0));
		for (int i = 1; i <= length; i++) {
			Vector3 piecePosition = new Vector3 (position.x + i, position.y, position.z);
			Instantiate (platformMiddle, piecePosition, new Quaternion(0, 0, 0, 0));
		}
		Vector3 rightPosition = new Vector3 (position.x + length + 1, position.y, position.z);
		Instantiate (platformRight, rightPosition, new Quaternion(0, 0, 0, 0));
	}

	// Update is called once per frame
	void Update () {
	
	}
}
