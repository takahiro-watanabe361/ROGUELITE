using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
	private float hp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Walk(float x){
		transform.position += Vector3.right * x;
	}

	public void Jump(Rigidbody2D rb, float power){
		rb.AddForce(transform.up * power);
	}
}
