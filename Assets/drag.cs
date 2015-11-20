using UnityEngine;
using System.Collections;

public class drag : MonoBehaviour {
	Vector3 dist;
	float yOrigin;
	float posY;
	public float yPosition;

	void OnMouseDown(){
		dist = Camera.main.WorldToScreenPoint(transform.position);
		posY = Input.mousePosition.y - dist.y;
	}
	
	void OnMouseDrag(){
		yPosition = Input.mousePosition.y;

		Vector3 curPos =	new Vector3(dist.x, Input.mousePosition.y - posY, dist.z);  
		Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
		transform.position = worldPos;
	}
}