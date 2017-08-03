using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descarga : MonoBehaviour {
	//clase q vincula material con el objeto carta de la clase carga 
	private Material materialSimbolo=null;
	private Material materialCarta=null;
	public Carga carga;
	private Carta currentCarta;

	void Awake(){
		materialCarta=GetComponent<MeshRenderer>().material;//guardamos material carta
//		print("material carta  c "+materialCarta.name);
		currentCarta=GetComponent<Carta>();
	}
	void Start () {
	//	carga=GameObject.FindGameObjectWithTag("cargaMaterial").GetComponent<Carga>();
		//Carga.onFinish+=OnSimboloCarga;

		DescargaCarta();
	}

	public void DescargaCarta(){
		materialSimbolo=carga.GetCarta;
		currentCarta.setSimbol=materialSimbolo;
		//print("carta "+gameObject.name+": "+materialSimbolo.name);

		//GetComponent<MeshRenderer>().material=materialSimbolo;
		}



}
