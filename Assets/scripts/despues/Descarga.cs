using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descarga : MonoBehaviour {
	//clase q vincula material con el objeto carta 
	private Material materialSimbolo;
	void Awake () {
		Carga.onFinish+=OnSimboloCarga;
		
	}
	void OnSimboloCarga( List<Material> m){
		Debug.Log(string.Format("avisador!{0}",m.Count)); 
		Debug.Log(string.Format("material agregado {0}))",m[Carga.index].name)); 
		materialSimbolo=m[Carga.index];
		Carga.index+=1;
		GetComponent<MeshRenderer>().material=materialSimbolo;
	}

}
