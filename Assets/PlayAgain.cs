
using UnityEngine;

public class PlayAgain : MonoBehaviour {
	public delegate void PlayAgain_D();
	public static event PlayAgain_D eventWin;
	public static event PlayAgain_D eventLoose; 
	void Start () {
		
	}
	
	public void OnWinClick(){
		print("click win");
		eventWin();
		
	}
	public void OnLoseClick(){
		print("click loose");
		eventLoose();
	}
}
