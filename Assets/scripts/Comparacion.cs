
using UnityEngine;
//COMPONENTE Q SE ENCARGA DE COMPARA LOS SIMBOLOS D LAS 2 CARTAS Y SUS EFECTOS TANTO SI ES VERDADERO ACTIVO SONIDO, DESACTIVO COLLIDERS Y COMPONENTES COMO FALSO
//ACTIVO SONIDO, RESETEO VALORES A LO ULTIMO
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
	public SoundManager sound;

	void Awake(){
		
	}
	void Start () {
		timeGame=0;
		time=0;
	}
	void Update(){
		if(GameManager.gameOver==false){
		timeGame+=Time.deltaTime;
		}
		if(timeActive){
		time+=Time.deltaTime;
			if(time>0.5f){
				print("tiempo cumplido");

				if(ComparacionCartas()){
					//COMPARACION VERDADERA
					print("verdadero ");
					sound.PlaySoundCorrect();//SONIDO CORRECTO
					compC1.DeactiveCollider();//DESACTIVO COLLIDER DE LA CARTA 1
					compC2.DeactiveCollider();//IDEM CARTA 2
					compC1.setBoolSalio=true;//BOLEANO INTERNO DE LA CARTA PROPIEDAD Q ESPECIFICA Q SALIO
					compC2.setBoolSalio=true;//IDEM
					//c1.GetComponent<SetCollider>().enabled=false;//DESATIVO COMPONENTE COLLIDER
					//c2.GetComponent<SetCollider>().enabled=false;//IDEM
					//c1.GetComponent<Deteccion>().enabled=false;//IDEM CON DETECCION C1
					//c2.GetComponent<Deteccion>().enabled=false;//IDEM CON C2

				}else{
					//falso cartas disimiles
					print("incorrecto");

					sound.PlaySoundInCorrect();
					compC1.VueltaCarta();
					compC2.VueltaCarta();
					print("CARTA 1 "+compC1.getSimbolName);
					print("CARTA 2 "+compC2.getSimbolName);

				}
				avisoOn();//aviso a set colliders para q se activen colliders de cartas

				active=true;
				time=0;
				timeActive=false;
				c1=null;
				c2=null;
				compC1=null;
				compC2=null;
				//RESETEAMO LOS VALORES
			}

		}


	}
	public bool ComparacionCartas(){
		//active=true;
		print("momento comparacion");
		if(c1!=null&&c2!=null){
			//click 2da carta

			print("carta 1 "+compC1.getSimbolName);
			print("carta 2 "+compC2.getSimbolName);

			if(compC1.getSimbolName==compC2.getSimbolName){
				Gui.correctas++;
			return true;
			}else{

				return false;
			}
		}else{
			print("WARNING !cartas nulas");
			return false;
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

	public float get_set_timeGame{
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
			print("fuera colliders");
			avisoOff();
		}
	}

}
