using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public enum UnitClass {Offensive, Defensive, Support};

public class UnitStatsLogic : MonoBehaviour {

	public UnitStats StatsSheet;

	// Use this for initialization
	void Start () {
		WriteStats ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void WriteStats ()
	{
		Transform unitCanvas = transform.GetChild (0);
		unitCanvas.GetChild (0).GetComponent<Text> ().text = StatsSheet.Name;
		unitCanvas.GetChild (1).GetComponent<Text> ().text = StatsSheet.Class.ToString();
		unitCanvas.GetChild (2).GetComponent<Text> ().text = StatsSheet.Health.ToString();
		unitCanvas.GetChild (3).GetComponent<Text> ().text = StatsSheet.Damage.ToString();
		unitCanvas.GetChild (4).GetComponent<Text> ().text = StatsSheet.Kills.ToString();
	}
}
