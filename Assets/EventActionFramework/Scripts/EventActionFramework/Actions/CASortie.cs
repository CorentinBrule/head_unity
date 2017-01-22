using UnityEngine;
using System.Collections;

public class CASortie : CustomActionScript {


	public GameObject target;

	public override IEnumerator DoActionOnEvent (MonoBehaviour sender, GameObject args)
	{
		GameObject pers = GameObject.Find("PhysicallyBasedFPController");

	  Debug.Log(pers);

		 Physics.gravity = new Vector3(0, -1.0F, 0);

		//pers.transform.localScale += new Vector3(2,2,2);

		//var time = anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
		//Debug.Log(time);

		yield return new WaitForFixedUpdate();
		/*if (_prefab != null)
		{

		}*/
		yield return null;
	}
}
