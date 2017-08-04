using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

//componente se dedica a mezclar la lista de materiales d simbolos y devolver una lista desordenada

public class Carga : MonoBehaviour {
	
	public List<Material>listaSimbolos=new List<Material>(); 
	public delegate void finish( Material material_lista);
	public static int index=0;
	//private List<Material>auxListMaterial=new List<Material>();
	//private List<Material>auxListMaterial2=new List<Material>();
	private List<Material>CurrentListaSimbolos=new List<Material>(); 
	//private List<int>currentIndex2=new List<int>();
	private int tamanioLista=0;

	public static event finish onFinish;
	void Awake(){
	//no entiendo porque se me borrar la lista simbolos, ya q la q utilizo es una auxiliar, actua como si estuviesen emparentadas, es una puta variable

	//	auxListMaterial=listaSimbolos;	
	//	auxListMaterial2=listaSimbolos;
		tamanioLista=listaSimbolos.Count;

		Inicio();
	}
	public void Inicio(){
		//print("lista simbolos existencia "+listaSimbolos.Count);
		//print("current SIMBOLOS "+CurrentListaSimbolos.Count);
		List<Material> aux=new List<Material>();
	
		for(int i=0;i<listaSimbolos.Count;i++){
			aux.Add(listaSimbolos[i]);
//			print("var "+aux[i]);
		}


		for(int i=0;i<tamanioLista;i++){
			
		//	print("tamanio lista original "+listaSimbolos.Count);
			Material m =MetodoInicial(aux);//saca una carta al azar
			CurrentListaSimbolos.Add(m);	//la guardas	
			aux.Remove(m);//la removes de la lista	
			print(i+") "+m.name);
			//Debug.Log(string.Format("material{0} ",m.name)); 
		}
	}

	Material MetodoInicial(List<Material>a){
		//devolves una carta al azar
		int n=a.Count;
		int r=Random.Range(0,n);
	
		return a[r];

	}


	public Material GetCarta{

		get{	
			Material m=null;
//			print("cantidad simbolos "+CurrentListaSimbolos.Count);
			if(CurrentListaSimbolos.Count>0){
			 m=CurrentListaSimbolos[0];//saco primer material
			CurrentListaSimbolos.Remove(m);//saco matererial d la lista
			//	CurrentListaSimbolos.
			
			}

			return m;
		}
	}
	public int getCantidadTotalCartas{
		get {
			return tamanioLista;
			}
	} 


}
