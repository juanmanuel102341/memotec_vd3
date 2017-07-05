using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

//componente se dedica a mezclar la lista de materiales d simbolos y devolver una lista desordenada

public class Carga : MonoBehaviour {
	
	public List<Material>listaSimbolos=new List<Material>(); 
	public delegate void finish( Material material_lista);
	public static int index=0;

	private List<Material>CurrentListaSimbolos=new List<Material>(); 
	private List<int>currentIndex2=new List<int>();
	private int tamanioLista;
	public static event finish onFinish;
	void Awake(){
		tamanioLista=listaSimbolos.Count;
		//Random_list();	
		print("tamanio "+tamanioLista);
		for(int i=0;i<tamanioLista;i++){
			Material m =MetodoInicial(listaSimbolos);//saca una carta al azar
			CurrentListaSimbolos.Add(m);	//la guardas	
			listaSimbolos.Remove(m);//la removes de la lista 	
			//Debug.Log(string.Format("material{0} ",m.name)); 
		}
	
	}

	Material MetodoInicial(List<Material>l){
		//devolves una carta al azar
		int n=l.Count;
		int r=Random.Range(0,n);
		return l[r];

	}
	// Update is called once per frame

	public Material GetCarta{

		get{	
			Material m=null;
			if(CurrentListaSimbolos.Count>0){
			 m=CurrentListaSimbolos[0];//saco primer material
			CurrentListaSimbolos.Remove(m);//saco matererial d la lista
			print("material "+m.name);
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
