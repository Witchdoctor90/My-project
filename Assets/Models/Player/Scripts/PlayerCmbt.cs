using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class AttackEvent : UnityEvent
{
	
}

public class PlayerCmbt : MonoBehaviour
{
	[SerializeField] Animator anim;
	[SerializeField]private Transform _player;
	[SerializeField] private PlayerStats _playerStats;
	[SerializeField] private Equipment _equipment;
	public LayerMask enemyLayer;
	public int damage = 2;
	public int playerCritDamage;
	public int playerCritChance;
	public float attackRange = 5f;
	



	public void Equip(Weapon_item_data _weapon)
    {
		_equipment.weapon = _weapon;
    }

	public void Attack ()
	{ 
		anim.SetTrigger ("Attack"); 	
		Collider2D[] targets = Physics2D.OverlapCircleAll (_player.position, attackRange, enemyLayer);
		foreach (Collider2D element in targets) {
			element.gameObject.GetComponent<Enemy> ().OnHit.Invoke (damage);
		}

	}



}

