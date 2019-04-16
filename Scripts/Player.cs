using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {
	[SerializeField] float _walkSpd, _jumpPower;
	[SerializeField] KeyCode _jumpKey;

	Rigidbody2D _rb;

	// Use this for initialization
	void Start () {
		_rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		Walk(Input.GetAxisRaw("Horizontal") * _walkSpd);
		if(Input.GetKeyDown(_jumpKey)) Jump(_rb, _jumpPower);
	}

	void OnTriggerEnter2D(Collider2D col){
		
	}
}
