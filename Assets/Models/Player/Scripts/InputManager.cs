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



		if (Input.GetMouseButtonDown (0) && _playerCtrl.isActiveAndEnabled) {
			_playerCtrl.OnAttack.Invoke ();
		}

		if (Input.GetKeyDown (KeyCode.I)) {
			if (inventory.activeInHierarchy) {
				GetComponent<PlayerCtrl>().enabled = true;
				inventory.SetActive (false);
			} else {
				GetComponent<PlayerCtrl>().enabled = false;
				inventory.SetActive (true);
			}
		}
			



	}
}
