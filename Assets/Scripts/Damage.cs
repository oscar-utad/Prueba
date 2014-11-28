using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour 
{
	[SerializeField]
	private int value;

	public int getDamage()
	{
		return value;
	}
}
