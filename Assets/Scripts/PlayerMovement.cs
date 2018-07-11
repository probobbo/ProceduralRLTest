using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public GameObject mBody;
	public float mMovementSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float Xax = Input.GetAxis("Horizontal");
		float Yax = Input.GetAxis("Vertical");

		transform.position += (transform.forward * Yax + transform.right * Xax).normalized * mMovementSpeed * Time.deltaTime;

		float RotX = Input.GetAxis("HorView");
		float RotY = Input.GetAxis("VerView");

		//Debug.Log(RotX + " -- " + RotY);

		Vector3 Viewdirection = (transform.forward * -RotY + transform.right * RotX).normalized;

		if (Viewdirection == Vector3.zero)
			Viewdirection = mBody.transform.forward;

		Debug.Log(Viewdirection);

		mBody.transform.rotation = Quaternion.LookRotation(Viewdirection);
	}
}
