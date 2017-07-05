
using UnityEngine;

public class Comparacion : MonoBehaviour {
	public static int clicks=0;
	private GameObject c1=null;
	private GameObject c2=null;
	private Carta compC1=null;
	private Carta compC2=null;
	private bool active=false;
	private float time=0;
	private bool timeActive=false;
	private float timeGame=0;
	public delegate void AvisoOn();//avisa momoento de comparacion al set collider para q active colliders
	public static event AvisoOn avisoOff;
	public static event AvisoOn avisoOn;
	public static event AvisoOn SetObjetOff;//apago el vento de la carta cuando salio, para q despues n se active



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
					compC1.DeactiveCollider();
					compC2.DeactiveCollider();
					compC1.setBoolSalio=true;
					compC2.setBoolSalio=true;
					c1.GetComponent<SetCollider>().enabled=false;
					c2.GetComponent<SetCollider>().enabled=false;
					c1.GetComponent<Deteccion>().enabled=false;
					c2.GetComponent<Deteccion>().enabled=false;


				//	c1=null;
				//	c2=null;
				//	compC1=null;
				//	compC2=null;
				}else{
					print("incorrecto");
					compC1.VueltaCarta();
					compC2.VueltaCarta();
					//c1.ActiveCollider();
					//c2.ActiveCollider();
					print("CARTA 1 "+compC1.getSimbolName);
					print("CARTA 2 "+compC2.getSimbolName);

				//	avisoOn();//aviso a set colliders para q se activen colliders de cartas
				}
				avisoOn();//aviso a set colliders para q se activen colliders de cartas
				active=true;
				time=0;
				timeActive=false;
				c1=null;
				c2=null;
				compC1=null;
				compC2=null;
			}

		}


	}
	public bool ComparacionCartas(){
		//active=true;


		print("momento comparacion");
		if(c1!=null||c2!=null){
			print("carta 1 "+compC1.getSimbolName);
			print("carta 2 "+compC2.getSimbolName);
			if(compC1.getSimbolName==compC2.getSimbolName){
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
	public GameObject setCarta1{
		set{

			c1=value;
			print("setiando carta 1 "+c1.name);
			compC1=c1.GetComponent<Carta>();

		}
	}

	public GameObject setCarta2{
		set{
			
			c2=value;
			print("setiando carta 2 "+c2.name);
			compC2=c2.GetComponent<Carta>();
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
	public void SetCollidersOf(){
		avisoOff();
	}
	public void SetCollidersOn(){
		avisoOn();
	}
}
