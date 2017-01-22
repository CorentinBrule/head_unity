using UnityEngine;
using System.Collections;

public class CAChangeGravity : CustomActionScript {

	public ForceMode _forceMode = ForceMode.VelocityChange;

	public float _force = 30f;

	public Transform _transformReference;

	public override IEnumerator DoActionOnEvent (MonoBehaviour sender, GameObject args)
	{
		var bumpedRigidbody = args.GetComponent<Rigidbody>();
		if (bumpedRigidbody != null && !bumpedRigidbody.isKinematic)
		{
			yield return new WaitForFixedUpdate ();
			Physics.gravity = new Vector3(6.0F, 0, 0);
		}
		yield return null;
	}
}
