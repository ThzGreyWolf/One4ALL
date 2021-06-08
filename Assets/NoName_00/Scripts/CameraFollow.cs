using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform target;

	private void Awake() {
		if(target == null) {
			Debug.LogError("CAMERA GOT NO TARGET!!!!");
		}
	}

	private void FixedUpdate() {
		transform.LookAt(target.transform.position);
	}
}
