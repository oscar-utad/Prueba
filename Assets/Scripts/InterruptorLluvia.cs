using UnityEngine;
using System.Collections;

public class InterruptorLluvia : MonoBehaviour {

	private GameObject nube;
	private CreadorChuzos creadorChuzos;

	// Use this for initialization
	void Start () 
	{
		nube = GameObject.Find ("Nube") as GameObject;
		creadorChuzos = nube.GetComponent<CreadorChuzos> ();
	}


	void OnTriggerEnter(Collider otro)
	{
		if (otro.tag == "player") 
		{
			creadorChuzos.pararLluvia ();
		}
	}

	void OnTriggerExit(Collider otro)
	{
		if (otro.name == "player") 
		{
			creadorChuzos.reanudarLluvia ();
		}
	}
}
