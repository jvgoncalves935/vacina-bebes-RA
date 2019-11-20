using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcadorController : MonoBehaviour {
	public bool marcador01Ativado;
    public bool marcador02Ativado;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void AtivarMarcador01(){
		marcador01Ativado = true;
	}
	public void AtivarMarcador02(){
		marcador02Ativado = true;
	}
	public void DesativarMarcador01(){
		marcador01Ativado = false;
	}
	public void DesativarMarcador02(){
		marcador02Ativado = false;
	}
	public bool MarcadoresAtivados(){
		return marcador01Ativado && marcador02Ativado;
	}
}
