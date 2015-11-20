using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {


	public Transform target;
	public float distance;

	// Update is called once per frame
	void Update () {
		float positionZ = target.position.z - distance;
		float positionY = target.position.y;
		float positionX = target.position.x;


		transform.position = new Vector3 (positionX, transform.position.y, positionZ);
	}
}
