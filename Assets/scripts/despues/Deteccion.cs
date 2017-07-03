//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Deteccion : MonoBehaviour {
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
			comparacion.setCarta1=currentCarta;
			currentCarta.DeactiveCollider();//desactivamos collider
			break;
		case 2:
			print("entrando 2");
			comparacion.setCarta2=currentCarta;
			comparacion.ComparacionCartas();//comparamos
			Comparacion.clicks=0;//reset contador
			break;

		}
				//comparacion.ComparacionCartas(current);

	}




}
