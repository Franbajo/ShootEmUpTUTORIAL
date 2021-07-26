using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputeable{
	/*.....ESTO ES PARA LOS CONTROLES DEL DISPARO....*/
	void ShootPressed();
	/*...............................................*/
	/*.....ESTO ES PARA LOS CONTROLES DEL MOVIMIENTO....*/
	void GetDirection(Vector3 direction);
	/*...............................................*/
}
