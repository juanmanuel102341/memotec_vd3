using UnityEngine;

public class SetCollider : MonoBehaviour {
	private BoxCollider2D box;
	private Carta carta;
	void Awake () {
		Comparacion.avisoOff+=OnOfColliders;
		Comparacion.avisoOn+=OnActiveColliders;
		carta=this.transform.gameObject.GetComponent<Carta>();
		box=GetComponent<BoxCollider2D>();
		
	}
	void OnOfColliders(){
//		print("collider of");
		box.enabled=false;
	}
	void OnActiveColliders(){
		
	
		if(carta.getBoolSalio==false){
		//	print("colliders on");
		box.enabled=true;
		}
	} 

}
