using UnityEngine;
using System.Collections;

public class CreadorChuzos : MonoBehaviour 
{
	[SerializeField]
	private GameObject prefabChuzo;

	private bool lloviendo = true;

	// Update is called once per frame
	void Update () 
	{
		if (lloviendo) 
		{
			GameObject chuzoClone = Instantiate (prefabChuzo) as GameObject;
			chuzoClone.transform.position = new Vector3 (
				Random.Range (-50, 50),
				transform.position.y,
				Random.Range (-50, 50));
		}
	}

	public void pararLluvia()
	{
		lloviendo = false;
	}

	public void reanudarLluvia()
	{
		lloviendo = true;
	}

}
