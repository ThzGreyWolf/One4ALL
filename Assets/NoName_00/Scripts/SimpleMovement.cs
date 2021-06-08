using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
	public float speed = 10;

	private Rigidbody m_rb;

	private void Awake() {
		m_rb = GetComponent<Rigidbody>();
	}

	private void FixedUpdate() {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit)) {
			if (hit.transform.tag == "Ground") {
				transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
			}
		}

		// TODO: Check to see if this can be done with one AddForce.
		Vector3 forwardForce = transform.forward * Input.GetAxis("Vertical");
		Vector3 strafeForce = transform.right * Input.GetAxis("Horizontal");

		m_rb.AddForce(forwardForce * speed);
		m_rb.AddForce(strafeForce * speed);
	}
}
