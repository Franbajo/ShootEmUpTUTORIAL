using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*............CLASE PARA CREAR LOS LÍMITES DE LA PANTALLA........*/
[System.Serializable]
public class posiciones{
	public float izquierdaX, derechaX, abajoY, arribaY;
}
/*...............................................................*/

public class PlayerController : MonoBehaviour {
	[SerializeField]private Move moverComponenete;
	[SerializeField]private float speed;
	public posiciones posi;
	public Transform shootOrigin;
	public GameObject shootPrefab;

	private void Start () {
		moverComponenete.speed = speed;
		/*......PARA EL DISPARO.......*/
		InputProvider.OnHasShoot += Instance_OnHasShoot;
		/*...............................*/
		/*......PARA EL MOVIMIENTO.......*/
		InputProvider.OnDirection += Movement;
		/*...............................*/

	}

	/*....................MÉTODO PARA EL DISPARO...........................*/
	public void Instance_OnHasShoot(){
		Instantiate (shootPrefab, shootOrigin, false);
	}
	/*.............................................................*/
	void Update () {
		/*..................LÍMITES PARA LA PANTALLA.............*/
		float ejeX = Mathf.Clamp (transform.position.x, posi.izquierdaX, posi.derechaX);
		float ejeY = Mathf.Clamp (transform.position.y, posi.abajoY, posi.arribaY);
		transform.position = new Vector3 (ejeX, ejeY, 0);
		/*......................................................*/
	}
	/*......PARA EL MOVIMIENTO.......*/
	private void Movement(Vector3 direction){
		moverComponenete.direction = direction;
	}
	/*...............................*/
}
