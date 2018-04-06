using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour {

	private BaseMovement bm;
	private ChaseMovement cm;
	private Rigidbody2D rb2d;

	void Start(){
		/*
		bm = GetComponent<BaseMovement> ();
		cm = GetComponent<ChaseMovement> ();
		rb2d = GetComponent<Rigidbody2D> ();
		bm.stop ();
		cm.stop ();
		*/
	}

	void Update(){

		RaycastHit2D hit = Physics2D.CircleCast ( rb2d.position, 100, bm.moveDir, 100);
		/*
		Debug.Log (hit.collider.gameObject.layer);
		if (hit.collider.gameObject.layer == 12 && !(cm.isOn)) {
			Debug.Log ("Enter");
			float player = hit.collider.gameObject.transform.localScale.x;
			Debug.Log (player);
			cm.begin (player);

		} else if (hit.collider.gameObject.layer != 12 && cm.isOn) {
			Debug.Log ("Exit");
			cm.stop ();
		}
		*/
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawLine (transform.position, new Vector3 (transform.localScale.x * 200 + transform.position.x, transform.position.y, transform.position.z));
	}
}
