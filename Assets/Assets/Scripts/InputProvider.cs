using UnityEngine;

public static class InputProvider  {
	/*...........PARA EL MOVIMIENTO...................*/
	public delegate void Direction(Vector3 direction);
	public static event Direction OnDirection;
	/*....................................*/
	/*...........PARA EL DISPARO...................*/
	public delegate void HaveShoot ();
	public static event HaveShoot OnHasShoot;
	/*...............................................*/
	/*...........PARA EL MOVIMIENTO...................*/
	public static void TriggerDirection(Vector3 direction){
		if(OnDirection != null){
			OnDirection.Invoke (direction);
		}
	}
	/*....................................*/
	/*...........PARA EL DISPARO...................*/
	public static void TriggerOnHasShoot(){
		if (OnHasShoot != null) {
			OnHasShoot.Invoke ();
		}
	}
	/*...............................................*/

}
