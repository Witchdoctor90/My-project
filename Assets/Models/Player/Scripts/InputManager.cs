using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputManager : MonoBehaviour
{
	[SerializeField]private PlayerCtrl _playerCtrl;
	[SerializeField]private PlayerCmbt _playerCmbt;
	[SerializeField]private Animator _anim;
	[SerializeField]private GameObject inventory;




	private void Update ()
	{
		_playerCtrl._movement.x = Input.GetAxisRaw ("Horizontal");
		_playerCtrl._movement.y = Input.GetAxisRaw ("Vertical");

		if (Input.GetAxisRaw ("Horizontal") != 0 || Input.GetAxisRaw ("Vertical") != 0) {
			_playerCtrl.MovePosition ();
			_anim.SetFloat ("lastMoveX", Input.GetAxisRaw ("Horizontal"));
			_anim.SetFloat ("lastMoveY", Input.GetAxisRaw ("Vertical"));
		}

		if (Input.GetMouseButtonDown (0)) {
			_playerCtrl.OnAttack.Invoke ();
		}

		if (Input.GetKeyDown (KeyCode.I)) {
			if (inventory.activeInHierarchy) {
				inventory.SetActive (false);
			} else {
				inventory.SetActive (true);
			}
		}
			



	}
}
