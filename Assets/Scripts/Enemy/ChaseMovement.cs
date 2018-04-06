using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseMovement : MonoBehaviour {

	public bool isOn;
	public int speed = 2;
	private Rigidbody2D rb2d;
	private Vector2 moveDir;
	public Rigidbody2D fakie;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		begin (new Vector2(fakie.transform.position.x,fakie.transform.position.y));
	}

	public void stop(){
		isOn = false;
		this.enabled = false;
	}

	public void begin(Vector2 md){
		moveDir = md;
	}
	
	// Update is called once per frame
	void Update () {
		//moveDir = new Vector2(fakie.position.x,fakie.position.y);
		rb2d.MovePosition (rb2d.position + ( moveDir * Time.fixedDeltaTime));
	}
}
