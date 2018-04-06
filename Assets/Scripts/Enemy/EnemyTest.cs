using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyTest : MonoBehaviour {

	int health = 100;
	public Text healthDisplay;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (health > 0)
			healthDisplay.text = "Enemy Health: " + health;
		else if (health <= 0)
			healthDisplay.text = "Enemy is Dead";
		
	
	}

	public void takeDamage(int toTake){
		health = health - toTake;
	}
}
