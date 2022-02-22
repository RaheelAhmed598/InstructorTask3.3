using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SqrCollision : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D col)
	{
		Chain.IsFired = false;

		if (col.tag == "Hurdles")
		{
			col.GetComponent<Hurdles>().Split();
		}
	}
}
