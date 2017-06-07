using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

//componente se dedica a mezclar la lista de materiales d simbolos y devolver una lista desordenada

public class Carga : MonoBehaviour {
	
	public List<Material>listaSimbolos=new List<Material>(); 
	public delegate void finish( List<Material> material_lista);
	public static int index=0;

	private List<Material>CurrentListaSimbolos=new List<Material>(); 
	private List<int>currentIndex2=new List<int>();

	public static event finish onFinish;
	void Awake(){
		int tamanioLista=listaSimbolos.Count;
		//Random_list();	
		List<Material> aux=listaSimbolos;
		for(int i=0;i<tamanioLista;i++){
			Material m =MetodoInicial(listaSimbolos);
			CurrentListaSimbolos.Add(m);	//guardas	
			listaSimbolos.Remove(m);//removes	
			//Debug.Log(string.Format("material{0} ",m.name)); 
		
		}
		//falta aplicarlo
		onFinish(CurrentListaSimbolos);
	}
	void Start () {
		

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
