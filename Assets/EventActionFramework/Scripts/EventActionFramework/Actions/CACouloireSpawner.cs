using UnityEngine;
using System.Collections;

public class CACouloireSpawner : CustomActionScript {

	public Transform _relativeTransform = null;

	public bool _makeRelativeTransformParent = false;

	public bool _relativePosition = false;

	public Vector3 _position = Vector3.zero;

	public bool _relativeRotation = false;

	public Quaternion _rotation = Quaternion.identity;

	public GameObject _prefab;

	public override IEnumerator DoActionOnEvent (MonoBehaviour sender, GameObject args)
	{
		var couloire=transform.parent;

		Vector3 originPosition = couloire.transform.position;
		Vector3 spawnPosition = originPosition;

		Animation anim = couloire.GetComponent<Animation>();
		anim.Play();
		//var time = anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
		//Debug.Log(time);

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
			newGO.transform.Translate(0,0,-13);
			//Animator animTarget= newGO.GetComponent<Animator>;
		}
		yield return null;
	}
}
