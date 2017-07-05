using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descarga : MonoBehaviour {
	//clase q vincula material con el objeto carta 
	private Material materialSimbolo=null;
	private Material materialCarta=null;
	private Carga carga;
	private Carta currentCarta;

	void Awake(){
		materialCarta=GetComponent<MeshRenderer>().material;//guardamos material carta
		print("material carta  c "+materialCarta.name);
		currentCarta=GetComponent<Carta>();
	}
	void Start () {
		carga=GameObject.FindGameObjectWithTag("cargaMaterial").GetComponent<Carga>();
		//Carga.onFinish+=OnSimboloCarga;

		DescargaCarta();
	}

	void DescargaCarta(){
		materialSimbolo=carga.GetCarta;
		currentCarta.setSimbol=materialSimbolo;

		//GetComponent<MeshRenderer>().material=materialSimbolo;
		}



}
