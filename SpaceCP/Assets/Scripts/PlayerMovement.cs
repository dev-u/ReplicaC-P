using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private Vector2 diretion;
    private Rigidbody2D player;
    private Vector2 moveVelocity;
    public float velocity = 1.0f;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        //Movimentaca de acordo com imput do teclado(o Raw faz parar imediatamente dps de soltar a tecla)
        diretion.y = Input.GetAxisRaw("Vertical");
        diretion.x = Input.GetAxisRaw("Horizontal");
        moveVelocity = diretion * velocity;


        Vector3 mouseLocation = Input.mousePosition;
        mouseLocation = Camera.main.ScreenToWorldPoint(mouseLocation);


        Vector2 Location = new Vector2(mouseLocation.x - transform.position.x, mouseLocation.y - transform.position.y);
        transform.up = Location;
  
	}
	private void FixedUpdate()
	{
        //Forca desse movimento 
        player.velocity = moveVelocity;

	}

}
