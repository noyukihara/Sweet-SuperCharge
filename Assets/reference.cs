using UnityEngine;
using System.Collections;

public class reference : MonoBehaviour {

	public drag refPosMouse;
	public float yMov;
	float lastY;

	// Use this for initialization
	void Start () {
		lastY = refPosMouse.yPosition;
	}
	
	// Update is called once per frame
	void Update () {
		yMov = lastY - refPosMouse.yPosition;
		lastY = refPosMouse.yPosition;
	}
}
