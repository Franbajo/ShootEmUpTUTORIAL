using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	[SerializeField]private float speed;

	void Start () {

	}

	void Update () {
		this.transform.Translate (Input.GetAxis("Horizontal")*speed*Time.deltaTime, Input.GetAxis("Vertical")*speed*Time.deltaTime, transform.position.z);
	}
}
