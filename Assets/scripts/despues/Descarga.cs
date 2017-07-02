using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descarga : MonoBehaviour {
	//clase q vincula material con el objeto carta 
	private Material materialSimbolo=null;
	private Carga carga;
	void Start () {
		carga=GameObject.FindGameObjectWithTag("cargaMaterial").GetComponent<Carga>();
		//Carga.onFinish+=OnSimboloCarga;
		DescargaCarta();
	}
	void OnSimboloCarga( Material m){
		//Debug.Log(string.Format("avisador!{0}",m.Count)); 
		//Debug.Log(string.Format("material agregado {0}))",m[Carga.index].name)); 
		//if(materialSimbolo==null){
		//materialSimbolo=m;
		//}
		//Carga.index+=1;
	//	GetComponent<MeshRenderer>().material=materialSimbolo;
	}
	void DescargaCarta(){
		materialSimbolo=carga.GetCarta;
		GetComponent<MeshRenderer>().material=materialSimbolo;

	}

}
