using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private Vector2 diretion;
    private Rigidbody2D player;
    public float velocity = 1.0f;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        diretion.y = Input.GetAxis("Vertical");
        diretion.x = Input.GetAxis("Horizontal");


        player.AddForce(diretion * velocity);
	}
}
