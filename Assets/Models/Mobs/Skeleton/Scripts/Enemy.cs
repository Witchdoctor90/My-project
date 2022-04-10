using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnHitEvents : UnityEvent<int>
{
	
}


public class Enemy : MonoBehaviour
{

	[SerializeField] private Animator anim;

	
	public new BoxCollider2D collider;
	[Range (0, 100)]public int health = 20;
	public OnHitEvents OnHit;
	public UnityEvent OnDeath;



	public void TakeDamage (int damage)
	{
		health -= damage;
		Debug.Log (health);
		anim.SetTrigger ("Hit");
		anim.SetFloat ("Health", health);
        
		if (health <= 0) {
			anim.SetTrigger ("Death");
		}
	}

	void Start ()
	{
		anim.SetFloat ("Health", health);
	}



	public void Death ()
	{
		Destroy(gameObject);
	}

	void Update ()
	{


       
	}
}
