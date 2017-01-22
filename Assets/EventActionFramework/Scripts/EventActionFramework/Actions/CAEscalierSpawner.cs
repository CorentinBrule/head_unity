using UnityEngine;
using System.Collections;

public class CAEscalierSpawner : CustomActionScript {

	public Transform _relativeTransform = null;

	public bool _makeRelativeTransformParent = false;

	public bool _relativePosition = false;

	public Vector3 _position = Vector3.zero;

	public bool _relativeRotation = false;

	public Quaternion _rotation = Quaternion.identity;

	public GameObject _prefab;

	public override IEnumerator DoActionOnEvent (MonoBehaviour sender, GameObject args)
	{

		var escalier = transform.parent.parent;

		Vector3 originPosition = escalier.transform.position;
		Vector3 spawnPosition = originPosition;

		Vector3 originRotation = escalier.transform.localEulerAngles;
		Vector3 spawnRotation = originRotation;

		int de = Random.Range(0,3);

		yield return new WaitForFixedUpdate();
		if (_prefab != null)
		{
			var newGO = (GameObject) GameObject.Instantiate(_prefab,
			                                                spawnPosition,
			                                                _relativeRotation && _relativeTransform != null ?
			                                                _relativeTransform.rotation * _rotation :
			                                                _rotation
			                                                );
			newGO.transform.parent = _makeRelativeTransformParent ? _relativeTransform : null;
			newGO.transform.rotation = Quaternion.Euler(spawnRotation);
			newGO.transform.Translate(0,-2,-4);
			//newGO.transform.Rotate(90,0,0);
			if (de == 0)
			{
				newGO.transform.Rotate(Vector3.up*90);
			}

			if (de == 2)
			{
				newGO.transform.Rotate(Vector3.up*-90);
			}


		}
		yield return null;
	}
}
