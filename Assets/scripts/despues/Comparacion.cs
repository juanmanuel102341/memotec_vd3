
using UnityEngine;

public class Comparacion : MonoBehaviour {
	public static int clicks=0;
	private Carta c1=null;
	private Carta c2=null;
	void Start () {
		//n se me da vuelta la carta 2 cuando es incorrecto
	}

	public void ComparacionCartas(){
		print("momento comparacion");

		if(c1!=null||c2!=null){
			print("carta 1 "+c1.getSimbolName);
			print("carta 2 "+c2.getSimbolName);
			if(c1.getSimbolName==c2.getSimbolName){
				
				Gui.correctas++;
				print("correcto");
				c1.DeactiveCollider();
				c2.DeactiveCollider();
				c1=null;
				c2=null;
			}else{
				print("incorrecto");
				c1.VueltaCarta();
				c2.VueltaCarta();
				c1=null;
				c2=null;
			
			}
		}else{
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
}
