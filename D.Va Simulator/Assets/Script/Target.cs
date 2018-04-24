using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public float health = 100;
    public bool dead = false;
	public bool isPlayer = false;
	public GameObject scoreManager;

    public void TakeDamage(float damage)
    {
        health -= damage;
    }
	
	// Update is called once per frame
	void Update () {
		if (dead == true)
        {
			if (isPlayer == false) {
				scoreManager.GetComponent<Score>().addScore(3);
				Destroy(gameObject);
			}
        }
	}
}
