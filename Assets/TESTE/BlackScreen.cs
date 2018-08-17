using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackScreen : MonoBehaviour {

	public Animator blackScreenAnim;
	

	// Use this for initialization
	void Start () {
		blackScreenAnim = GetComponent<Animator>();
		blackScreenAnim.SetBool("Clarear",true);
	}
	
	public void Escurecer() {
		blackScreenAnim.SetBool("Clarear",false);
	}
}
