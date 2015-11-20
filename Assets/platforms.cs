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
	


		refPosition.yMov = Mathf.Abs (refPosition.yMov) > 99 ? 0 : refPosition.yMov;
		
		Vector3 newPosition = new Vector3(gameObject.transform.position.x, transform.position.y + ( refPosition.yMov *0.01f * platformType), gameObject.transform.position.z);



		Debug.Log (newPosition - transform.position);
		gameObject.transform.position = newPosition;





	}
}
