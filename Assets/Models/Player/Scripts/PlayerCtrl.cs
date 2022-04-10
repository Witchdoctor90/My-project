using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



[System.Serializable]
public class OnItemPickup : UnityEvent<Item_data>
{
	
}


public class PlayerCtrl : MonoBehaviour
{
	private int _speed = 5;
	public Vector2 _movement;
	private int damage = 2;
	private PlayerCmbt _playerCmbt;
	public UnityEvent OnAttack;
	public OnItemPickup PickupEvent;


	[SerializeField] private Rigidbody2D rb;
	[SerializeField] private Animator anim;


    

	private void Update ()
	{
		anim.SetFloat ("moveX", _movement.x);
		anim.SetFloat ("moveY", _movement.y);
		anim.SetFloat ("moving", _movement.sqrMagnitude);
	}

	public void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Item") {
			PickupEvent.Invoke (col.gameObject.GetComponent<PickableItem> ().item_data);	
			Destroy (col.gameObject);
		}

	}

	

	private void LateUpdate ()
	{

	}

    



	public void MovePosition ()
	{
		
		rb.MovePosition (rb.position + _movement * _speed * Time.fixedDeltaTime);

	}

}
