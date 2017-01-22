using UnityEngine;
using System.Collections;

public class CABascule : CustomActionScript {


	public GameObject target;

	public override IEnumerator DoActionOnEvent (MonoBehaviour sender, GameObject args)
	{
		var bascule = transform;

		target = GameObject.Find("Couloir(Clone)(Clone)(Clone)(Clone)");
	  Debug.Log(target);

		target.transform.parent = bascule;

		GameObject escalier = GameObject.Find("Escalier (1)/escalier2");
		MeshRenderer r = escalier.GetComponent<MeshRenderer>();
		r.enabled=true;

		Animation anim = bascule.GetComponent<Animation>();
		anim.Play();
		//var time = anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
		//Debug.Log(time);

		yield return new WaitForFixedUpdate();
		/*if (_prefab != null)
		{

		}*/
		yield return null;
	}
}
