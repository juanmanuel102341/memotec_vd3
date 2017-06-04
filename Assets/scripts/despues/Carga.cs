using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

//componente se dedica a mezclar la lista de materiales d simbolos y devolver una lista desordenada

public class Carga : MonoBehaviour {
	
	public List<Material>listaSimbolos=new List<Material>(); 
	public delegate void finish(List<Material>lista);
	private List<Material>listaSimbolos2=new List<Material>(); 
	private List<int>currentIndex2=new List<int>();
	//public static event finish onFinish;
	void Awake(){
		
	}
	void Start () {
		int tamanioLista=listaSimbolos.Count;
		//Random_list();	
		List<Material> aux=listaSimbolos;

		for(int i=0;i<tamanioLista;i++){
			Debug.Log(string.Format("lista anterior{0}",aux[i])); 
		}

		for(int i=0;i<tamanioLista;i++){

		Material m =MetodoInicial(listaSimbolos);
		listaSimbolos2.Add(m);	//guardas	
		listaSimbolos.Remove(m);//removes	
		Debug.Log(string.Format("material agregado {0},lista final{1}",m,listaSimbolos2)); 
		}

	//	Debug.Log("");
		for(int i=0;i<listaSimbolos2.Count;i++){
			Debug.Log(string.Format("lista final{0}",listaSimbolos2[i])); 
		}

	}
	Material MetodoInicial(List<Material>l){
		//hacer un random de lo q te mandan
		//ggeneras una salida random
		int n=l.Count;
		int r=Random.Range(0,n);

		return l[r];

	}
	// Update is called once per frame




}
