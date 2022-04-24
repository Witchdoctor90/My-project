using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnHitEvents : UnityEvent<int>
{
	
}

public class EnemyAI : MonoBehaviour
{
	[SerializeField] private Animator anim;
	[SerializeField] private Rigidbody2D _rb;
			
	public new BoxCollider2D collider;
	public int health = 20;
	public int damage = 2;
	public OnHitEvents OnHit;
	public UnityEvent OnDeath;

	void Start ()
	{
		anim.SetFloat ("Health", health);
		
		
	}
    private void Update()
    {
		
    }


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



		

    public void Death() => Destroy(gameObject);

}
