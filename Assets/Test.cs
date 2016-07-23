using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Test : MonoBehaviour {

	public GameObject targetText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnSave()
	{
		PlayerPrefs.SetString ("testme", "testme");
		PlayerPrefs.Save ();
	}

	public void OnLoad()
	{
		Text target = targetText.GetComponent<Text> ();
		target.text = PlayerPrefs.GetString ("testme");
	}

	public void OnClean()
	{
		Caching.CleanCache ();
	}
}
