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
	public UnityEvent OnAttack;
	public OnItemPickup PickupEvent;


	
	[SerializeField] private Rigidbody2D _rb;
	[SerializeField] private Animator _anim;


    

	private void Update ()
	{
		_anim.SetFloat ("moveX", _movement.x);
		_anim.SetFloat ("moveY", _movement.y);
		_anim.SetFloat ("moving", _movement.sqrMagnitude);
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
		if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
		{
			MovePosition();
			_anim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
			_anim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
		}
	}

    



	public void MovePosition ()
	{
		
		_rb.MovePosition (_rb.position + _movement * _speed * Time.fixedDeltaTime);

	}

}
