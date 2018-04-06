using UnityEngine;
using System.Collections;

public class AttackMelee : MonoBehaviour {

	//public Weapons wep;
	public Transform holdPoint;

	//declares the player object
	GameObject playerObj;
	//PlayerData player;

	//declares the amount of damage the player is going to do and the range up to
	public int damage;
	public float range = 1f; //temp

	// Use this for initialization
	void Start () {
		//player = gameObject.GetComponent<PlayerData> ();
		findWeapon ();
	}
	
	// Update is called once per frame
	void Update () {
		findWeapon ();
		determineDamage ();

		//if player pressed left mouse (attack)
		if (Input.GetMouseButtonDown(0)) {
			Physics2D.queriesStartInColliders = false;
			//uses raycast at the moment. May change later
			RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), Vector2.right * transform.localScale.x, range);
			if (hit.collider != null && hit.collider.gameObject.layer == 10){ //enemy layer is 10
				Debug.Log ("Player Done: " + damage + " damage");
				EnemyTest enem = hit.collider.gameObject.GetComponent<EnemyTest> ();
				enem.takeDamage (damage);
			}
		}

	
	}

	//calculates the damage that is going to be dealt
	void determineDamage(){
		//damage = player.getDamage () + wep.getDamage ();
	}

	//temporary, will probably have more advanced way to look for weapon
	void findWeapon(){
		//wep = gameObject.GetComponent<Weapons> ();
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawLine (transform.position, new Vector3 (transform.localScale.x * range + transform.position.x, transform.position.y, transform.position.z));
	}
}
