using UnityEngine; 
using System.Collections; 
using System.Collections.Generic; 
using System.Text; 
using System.IO; 
using System.Net;

public class ItemScript : MonoBehaviour {

	public UILabel Label1;
	public UILabel Label2;
	public UILabel Label3;
	public UILabel Label4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Dictionary<string, string> PostDic = new Dictionary <string, string> {
			{ "userid", "test" },
			{ "score", "2000" }
		};

		POST("http://ikunew.iptime.org:8000/new", PostDic);
	}

	public void GET(string url) 
	{ 
		WWW www = new WWW(url); 

		StartCoroutine(WaitForRequest(www));
	} 

	public void POST(string url, Dictionary<string, string> post) 
	{ 
		WWWForm form = new WWWForm(); 

		foreach (KeyValuePair<string, string> post_arg in post) 
		{ 
			form.AddField(post_arg.Key, post_arg.Value); 
		} 

		WWW www = new WWW(url, form); 

		StartCoroutine(WaitForRequest(www));
	} 


	private IEnumerator WaitForRequest(WWW www) 
	{ 
		yield return www; 

		// check for errors 
		if (www.error == null) 
		{ 
			Debug.Log("WWW Ok!: " + www.text); 
		} 
		else 
		{ 
			Debug.Log("WWW Error: " + www.error); 
		} 
	}

	void OnMouseDown(){
		Debug.Log("Click!");
		/*
		 * Dictionary<string, string> PostDic = new Dictionary <string, string> {
			{ "userid", "test" },
			{ "score", "2000" }
		};

		POST("http://ikunew.iptime.org:8000/new", PostDic);		*/
	}
}
