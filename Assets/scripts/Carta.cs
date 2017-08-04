
using UnityEngine;

public class Carta : MonoBehaviour {
	private MeshRenderer mesh;
	private Material materialSimbolo;
	private Material materialCarta;
	private bool salio=false;

	void Awake () {
		mesh=GetComponent<MeshRenderer>();
		materialCarta=mesh.material;
		salio=false;
		}

	public void VueltaCarta(){
//		print("carta vuelta");
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
		if(!salio){
		BoxCollider2D aux=this.GetComponent<BoxCollider2D>();
		aux.enabled=true;
		}
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
	public bool setBoolSalio{
		set{
			salio=value;
		}

	}
	public bool getBoolSalio{
		get{
			return salio;
		}
	}


}
