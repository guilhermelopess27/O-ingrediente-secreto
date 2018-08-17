using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Telas : MonoBehaviour {

	[SerializeField] private GameObject Tela1;
	void Start () {
		Invoke("Desativar", 3f);
	}
	
	
	void Desativar(){
		gameObject.SetActive(false);
	}

}
