﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class Datilografia : MonoBehaviour {

    //variaveis importantes;
    private string texto;
    private char[] letras;
    private string[] falas;

    public string nome;
    // personagens

    [SerializeField] private string sceneName;

    public Text texto_hud,
                nomepersonagem_hud,
                space_hud;

    [SerializeField]
    private float delay;

    public GameObject hud;

    public bool nomepersonagem = true,
                pulardelay = false,
                controle_space = false,
                acabouFala;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (controle_space)
            {
                pulardelay = true;
            }
        }
    }
      

    public void Digitando(string nomeArquivo)
    {
        //ler arquivo .txt
        string filePath = Path.Combine(Application.streamingAssetsPath, nomeArquivo);
        texto = File.ReadAllText(filePath);

        texto_hud.text = "";

        //começar rotina;
        StartCoroutine(Typerwrite());
    }//fim digitando;


    private IEnumerator Typerwrite()
    {

        texto.Replace("\r\n", "");
        falas = texto.Split('@');

        acabouFala = false;

        for (int l = 0; l < falas.Length; l++)
        {

            string[] subFala = falas[l].Split('/');
            nome = subFala[0].Replace("\r\n", "");
            nomepersonagem_hud.text = nome;

            letras = subFala[1].ToCharArray();

            for (int i = 0; i < letras.Length; i++)
            {
                controle_space = true;
                texto_hud.text += letras[i];

                if (pulardelay != true)
                {
                    yield return new WaitForSeconds(delay);
                }
            }
            yield return new WaitForSeconds(0.1f);

            while (Input.GetKeyDown(KeyCode.Space) == false)
            {
                controle_space = false;
                yield return new WaitForSeconds(0.005f);
                space_hud.text = "Aperte Espaço...";
            }

            texto_hud.text = "";
            nomepersonagem_hud.text = "";
            space_hud.text = "";
            pulardelay = false;

        }
        hud.SetActive(false);
        PlayerPrefs.SetInt("objetoDialogo", 1);

        //capitulos;
        acabouFala = true;
        letras = texto.ToCharArray();
        GameManager.Game.blackScreen.Escurecer();
        Invoke("MudarCena", 1f);
        //Fim;
    }//fim typer;

    private void MudarCena(){
        SceneManager.LoadScene(sceneName);

    }
}
