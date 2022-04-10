using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
	weapon,
	usable,
	armor,
}

public abstract class Item_data : ScriptableObject
{
	
	public Type itemType { get; }

	public Sprite item_sprite;
	public Sprite item_icon;

	public string item_name;
	public string item_desc;
	public int item_id;





}
