using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	[SerializeField]
	private int health;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		health -= collision.gameObject.GetComponent<Damage> ().getDamage ();
		Debug.Log ( health );
	}
}
