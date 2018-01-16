using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitStats {
	public string Name;
	public UnitClass Class;
	public float Health;
	public float Damage;
	public string Other;
	//
	[HideInInspector]
	public int Kills;
}
