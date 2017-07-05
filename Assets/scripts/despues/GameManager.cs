
using UnityEngine;

public class GameManager : MonoBehaviour {
	private Comparacion comparacionObj;
	private Carga carga;
	public int timeLoose;
	// Use this for initialization
	void Awake () {
		comparacionObj=GameObject.FindGameObjectWithTag("comparacion").GetComponent<Comparacion>();
		carga=GameObject.FindGameObjectWithTag("cargaMaterial").GetComponent<Carga>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Gui.correctas>=carga.getCantidadTotalCartas){
		
			print("ganaste");
		}
		if(comparacionObj.getTimeGame>timeLoose){
			print("perdiste");	
		}	
	}
}
