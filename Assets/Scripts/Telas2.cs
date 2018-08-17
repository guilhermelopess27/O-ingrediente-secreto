using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Telas2 : MonoBehaviour {
	[SerializeField] private string nomeCena;
	// Use this for initialization
	void Start () {
		Invoke("MudarCena", 6f);
	}
	
	void MudarCena(){
		SceneManager.LoadScene(nomeCena);
	}
}
