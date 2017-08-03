using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour {
	private Comparacion comparacionObj;
	public Carga carga;
	public int timeLoose;
	public delegate void ResetBool();
	public static event ResetBool onResetBool;//evento para activar colliders cartas 
	private List <GameObject> listaCartas=new List<GameObject>();  
	public GameObject objJuego;
	private Gui guiGame;
	private bool guiA=false;
	public GameObject guiLoose;
	public GameObject guiWin;

	public static bool gameOver=false;
	void Awake () {
		comparacionObj=GameObject.FindGameObjectWithTag("comparacion").GetComponent<Comparacion>();
		carga=GameObject.FindGameObjectWithTag("cargaMaterial").GetComponent<Carga>();
		GameObject[] objs=GameObject.FindGameObjectsWithTag("carta");
		for(int i=0;i<objs.Length;i++){
			listaCartas.Add(objs[i]);
		//	print("carta cargada "+listaCartas[i].name);
		}
		guiGame=GetComponent<Gui>();
		if(guiGame!=null){ 
			print("gui cargadda");
		}
		PlayAgain.eventWin+=onWinReset;
		PlayAgain.eventLoose+=onLooseReset;
		gameOver=false;
	}

	
	// Update is called once per frame
	void Update () {

		//print("CORRECTAS "+Gui.correctas);
//		print("TOTAL CARTAS "+carga.getCantidadTotalCartas);
		if(Gui.correctas>=carga.getCantidadTotalCartas/2&&gameOver==false&&Gui.correctas!=0){
		print("ganaste");
		gameOver=true;
		objJuego.SetActive(false);
		guiWin.SetActive(true);
		
		comparacionObj.get_set_timeGame=0;
		}
		if(comparacionObj.get_set_timeGame>timeLoose&&gameOver==false){
			print("perdiste");
			gameOver=true;

			objJuego.SetActive(false);

			guiLoose.SetActive(true);
		
					
		}	
	}
	void onWinReset(){
		print("reset desde game manager win");
	}
	void onLooseReset(){
		print("perdiste desde game manager");
		Reseteo();
	} 
	void Reseteo(){
		

		if(comparacionObj.get_set_timeGame>timeLoose){
			guiLoose.SetActive(false);
		}else if(Gui.correctas>=carga.getCantidadTotalCartas/2){
			guiWin.SetActive(false);
		}

			
		print("cartas cantidad "+listaCartas.Count);
		for(int i=0;i<listaCartas.Count;i++){
			Carta aux=listaCartas[i].GetComponent<Carta>();

			aux.setBoolSalio=false;//booleano q salio la carta
			aux.VueltaCarta();//vuelta carta
			aux.ActiveCollider();//colldiers
			//aux.setSimbol=carga.GetCarta;//obtengo simbolo nuevamente random
			//listaCartas[i].GetComponent<Deteccion>().enabled=true;
			//listaCartas[i].GetComponent<SetCollider>().enabled=true;
			//listaCartas[i].GetComponent<Descarga>().DescargaCarta();
		}
		Comparacion.clicks=0;
		Gui.correctas=0;
		comparacionObj.get_set_timeGame=0;
		objJuego.SetActive(true);
		gameOver=false;
		carga.Inicio();
	}

}
