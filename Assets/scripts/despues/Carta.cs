
using UnityEngine;

public class Carta : MonoBehaviour {
	private MeshRenderer mesh;
	private Material materialSimbolo;
	private Material materialCarta;


	void Awake () {
		mesh=GetComponent<MeshRenderer>();
		materialCarta=mesh.material;
		}
	public void VueltaCarta(){
		print("carta vuelta");
		mesh.material=materialCarta;	
	
	}
	public void VueltaSimbolo(){
		mesh.material=materialSimbolo;
	}


	public void DeactiveCollider(){
		
		BoxCollider2D aux=this.GetComponent<BoxCollider2D>();
		aux.enabled=false;
	}
	public void ActiveCollider(){

		BoxCollider2D aux=this.GetComponent<BoxCollider2D>();
		aux.enabled=true;
	}
	public string getSimbolName{
		get{
			return materialSimbolo.name;
		}
	}
	public Material setSimbol{
		set {
			materialSimbolo=value;
		}
	}


}
