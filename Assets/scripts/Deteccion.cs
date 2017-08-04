using UnityEngine;
public class Deteccion : MonoBehaviour {
	//detecta el click q se le hace a la carta , obteiendo el gameObect de la carta resepectiva, tanto para 
	//el primer click como para el segundo
	private Descarga descarga;
	private MeshRenderer mesh;
	private Comparacion comparacion;
	private Carta currentCarta;
	void Awake() {
		descarga=GetComponent<Descarga>();
		mesh=GetComponent<MeshRenderer>();
		comparacion=GameObject.FindGameObjectWithTag("comparacion").GetComponent<Comparacion>();
		if(comparacion==null){
			print("objeto comparacion no encontrado");
		}
		currentCarta=GetComponent<Carta>();
	}
	void OnMouseDown() {
		Comparacion.clicks++;
		currentCarta.VueltaSimbolo();
		print("click "+Comparacion.clicks);
		switch(Comparacion.clicks){
		case 1:
			print("entrando 1");
			comparacion.setCarta1=this.gameObject;
			currentCarta.DeactiveCollider();//desactivamos collider
			break;
		case 2:
			print("entrando 2");
			//currentCarta.DeactiveCollider();//desactivo collider 2da carta

			comparacion.setCarta2=this.gameObject;
			comparacion.setBool=true;//activamos bolleano del timer, cuando cumple tiempo ahi se compara
		
			Comparacion.clicks=0;//reset contador
		
			break;
		}
	}
}
