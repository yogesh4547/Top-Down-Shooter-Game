using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	public int health = 100;

	

	public void TakeDamage(int damage)
	{
		health -= damage;

		if (health <= 100)
		{
			Die();
		}
	}

	void Die()
	{
		ScoreScript.scoreValue += 5;
		Destroy(gameObject);
	}

}
