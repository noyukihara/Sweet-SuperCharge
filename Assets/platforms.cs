using UnityEngine;
using System.Collections;

public class platforms : MonoBehaviour {

	reference refPosition;
	public float platformType;

	// Use this for initialization
	void Start () {
	

		refPosition = (reference)FindObjectOfType (typeof (reference));
	}
	
	// Update is called once per frame
	void Update () {
	

		refPosition.yMov = Mathf.Abs (refPosition.yMov) > 99 ? 0 : refPosition.yMov;
		
		Vector3 newPosition = new Vector3(gameObject.transform.position.x, transform.position.y + ( refPosition.yMov *0.01f * platformType), gameObject.transform.position.z);
		gameObject.transform.position = newPosition;

	
	}
}
