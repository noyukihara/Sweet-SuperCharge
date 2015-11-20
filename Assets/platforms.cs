using UnityEngine;
using System.Collections;

public class platforms : MonoBehaviour {

	public reference refPosition;
	public int platformType;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - refPosition.yMov * platformType, gameObject.transform.position.z);
		gameObject.transform.position = newPosition;
	}
}
