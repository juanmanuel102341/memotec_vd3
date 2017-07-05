
using UnityEngine;

public class Comparacion : MonoBehaviour {
	public static int clicks=0;
	private Carta c1=null;
	private Carta c2=null;
	private bool active=false;
	private float time=0;
	private bool timeActive=false;
	private float timeGame=0;
	public delegate void AvisoOn();//avisa momoento de comparacion al set collider para q active colliders

	public static event AvisoOn avisoOff;
	void Start () {
		timeGame=0;
		time=0;
	}
	void Update(){
		timeGame+=Time.deltaTime;
		if(timeActive){
		time+=Time.deltaTime;
			if(time>0.5f){
				print("tiempo cumplido");

				if(ComparacionCartas()){
					print("verdadero ");
					c1.DeactiveCollider();
					c2.DeactiveCollider();
					c1=null;
					c2=null;
				}else{
					print("incorrecto");
					c1.VueltaCarta();
					c2.VueltaCarta();
					c1.ActiveCollider();
					c2.ActiveCollider();
					print("CARTA 1 "+c1.getSimbolName);
					print("CARTA 2 "+c2.getSimbolName);
					c1=null;
					c2=null;
				
				}
				active=true;
				time=0;
				timeActive=false;
			
			}

		}


	}
	public bool ComparacionCartas(){
		//active=true;


		print("momento comparacion");
		if(c1!=null||c2!=null){
			print("carta 1 "+c1.getSimbolName);
			print("carta 2 "+c2.getSimbolName);
			if(c1.getSimbolName==c2.getSimbolName){
				Gui.correctas++;
			
				return true;
			}else{

				return false;
			}
		}else{
			return false;
			print("WARNING !cartas nulas");
		}
	
	}
	public Carta setCarta1{
		set{
			print("setiando carta 1");
			c1=value;
		}
	}

	public Carta setCarta2{
		set{
			print("setiando carta 2");
			c2=value;
		}
	}
	public float getTimeGame{
		get{
			return timeGame;
		}
		set{
			timeGame=value;	
		}
	}
	public bool setBool{
		set{
			timeActive=value;

		}
	}
	
}
