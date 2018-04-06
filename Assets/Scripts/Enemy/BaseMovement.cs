using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BaseMovement : MonoBehaviour {

	public int speed = 5;
	public Vector2 moveDir = Vector2.right;
	private Rigidbody2D rb2d;
	private Collider2D collider;
	private float originalPos;
	private float distanceTraveled;
	public bool isOn = true;

	void Start() {
		rb2d = GetComponent<Rigidbody2D> ();
		collider = GetComponent<Collider2D> ();
		originalPos = rb2d.position.x;
		distanceTraveled = rb2d.position.x;
	}

	public void stop(){
		isOn = false;
		this.enabled = false;
	}

	public void start (){
		isOn = true;
		this.enabled = true;
	}

	void FixedUpdate(){
		
		RaycastHit2D hitRight = Physics2D.Raycast ((Vector2)(collider.bounds.min) + new Vector2(collider.bounds.extents.x * 2,0), (Vector2.down + Vector2.right), 1 );
		Debug.DrawRay ((Vector2)(collider.bounds.min) + new Vector2(collider.bounds.extents.x * 2,0), (Vector2.down + Vector2.right), Color.red);

		RaycastHit2D hitLeft = Physics2D.Raycast ((Vector2)(collider.bounds.min), (Vector2.down + Vector2.left), 1 );
		Debug.DrawRay ((Vector2)(collider.bounds.min) , (Vector2.down + Vector2.left), Color.red);

		if (hitRight.collider == null)
			moveDir = Vector2.left;
		else if (hitLeft.collider == null)
			moveDir = Vector2.right;
		
		rb2d.MovePosition (rb2d.position + ( moveDir * speed * Time.fixedDeltaTime));
		
	}
		
}
