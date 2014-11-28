using UnityEngine;
using System.Collections;

public class ChuzoDestructor : MonoBehaviour 
{
	public GameObject miniChuzo;

	void OnCollisionEnter(Collision collision)
	{
		GameObject chuzitoClone;
		Vector3 rndDirection;
		int fragmentCount = Random.Range (4,7);

		for (int i = 0; i < fragmentCount; i++ )
		{
			chuzitoClone = Instantiate(miniChuzo) as GameObject;
			chuzitoClone.transform.position = transform.position;
			rndDirection = Random.insideUnitSphere;

			chuzitoClone.transform.Rotate(rndDirection);
			Destroy(chuzitoClone,1);
		}

		Destroy (this.gameObject);
	}
}