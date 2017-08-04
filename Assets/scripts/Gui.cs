
using UnityEngine;
using UnityEngine.UI;
public class Gui : MonoBehaviour {

	public static int correctas=0;
	public Text numCorrectas;
	public Text numTime;
	private Comparacion comparacion;


	void Awake () {
		comparacion=GameObject.FindGameObjectWithTag("comparacion").GetComponent<Comparacion>();

	}
	
	// Update is called once per frame
	void Update () {
	
		numCorrectas.text=correctas.ToString();
		numTime.text=comparacion.get_set_timeGame.ToString();
	}


}
