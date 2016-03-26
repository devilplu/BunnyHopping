using UnityEngine;
using System.Collections;

public class RankItemScript : MonoBehaviour {

	public GameObject RankItem;
	public GameObject GridRank;
	public GameObject Prefab;

	// Use this for initialization
	void Start () {
		for (int vI = 0; vI < 10; vI++) {
			Prefab = NGUITools.AddChild (GridRank, RankItem);
			Prefab.GetComponent<ItemScript> ().Label1.text = vI + "Test!";
		}
	}
		
	// Update is called once per frame
	void Update () {
	
	}
}
