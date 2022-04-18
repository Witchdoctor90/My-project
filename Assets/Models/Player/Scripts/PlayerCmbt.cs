﻿using System.Collections;
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
	public int health = 20;
	public int damage = 2;
	public int defense = 0;
	public int playerCritDamage;
	public int playerCritChance;
	public float attackRange = 5f;

	public const int PLAYER_DAMAGE = 2;
	public const int PLAYER_MAXHEALTH = 20;
	public const int PLAYER_CRIT_DAMAGE = 4;
	public const int PLAYER_CRIT_CHANCE = 20;
	public const int PLAYER_DEFENSE = 0;
	public void UpdateStats()
	{
		//WEAPON
		if (_equipment.weaponSlot.weapon)
		{ 
			damage = PLAYER_DAMAGE + _equipment.weaponSlot.weapon.damageBoost;
			playerCritDamage = PLAYER_CRIT_DAMAGE + _equipment.weaponSlot.weapon.critDamage;
			playerCritChance = PLAYER_CRIT_CHANCE + _equipment.weaponSlot.weapon.critChance;
		}		
		else
        {
			damage = PLAYER_DAMAGE;
			playerCritDamage = PLAYER_CRIT_DAMAGE;
			playerCritChance = PLAYER_CRIT_CHANCE;
        }
		//WEAPON

		//ARMOR
		if(_equipment.armorSlot.armor)
        {
			defense = PLAYER_DEFENSE + _equipment.armorSlot.armor.defensePoints;
        }
		else
        {
			defense = PLAYER_DEFENSE;
        }
		//ARMOR
	}

	public void Heal(UsableItemData healingItem)
    {
		health += healingItem.healPointsCount;
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

