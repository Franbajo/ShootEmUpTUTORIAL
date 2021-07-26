using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour {

	[SerializeField]private Move moverComponenete;

	void Update () {
		Vector3 desplazamiento = new Vector3 (UnityEngine.Random.Range(-1f,1f), UnityEngine.Random.Range(-1,1),transform.position.z);
		//moverComponenete.DoMove (desplazamiento);
	}
}
