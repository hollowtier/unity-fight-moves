using UnityEngine;
using System.Collections;

public class salto : MonoBehaviour {
	public int saltar = 400;
	public float movspeed = 5.0f;
	public bool tierra = true;
	public static float distanceTraveled;
	public Texture2D gear;
	public bool boton=true;


	void Update () {

		distanceTraveled = transform.localPosition.y;

		if (Input.GetKey("left") || Input.GetKey ("a"))
				{ transform.position -= Vector3.right * movspeed * Time.deltaTime; }
		
		if (Input.GetKey("right") || Input.GetKey ("d"))
				{ transform.position -= Vector3.left * movspeed * Time.deltaTime; }


		//Salto
				/*Plataformero*/ if(Input.GetButtonDown("Jump") || Input.GetKey("w") /*&& tierra==true*/)
			//if(Input.GetButtonDown("Jump") || Input.GetKey("w") && tierra==true && boton==true)
			{ rigidbody.AddForce (new Vector3 (0,saltar,0), ForceMode.Force);	}

	}

	/*
	//Estructura Saltar
	void Jump ()  { 		
							if ((tierra==true) && (boton==true))
							rigidbody.AddForce (new Vector3 (0,saltar,0), ForceMode.Force);
							tierra=false;
							boton=false;
				  }


	//Collision con objeto plataformas
	void OnCollisionEnter (Collision col)
				  {
							if (col.gameObject.tag=="Plataformas")
							tierra=true;
			   	  
	              }


	//Buttons

	void OnGUI () {
		
		
		
		//Left Button
		//GUI.backgroundColor=Color.clear
		if (GUI.Button (new Rect (0,50,Screen.width/2,Screen.height), "")) 
		{
			boton=true;	
			print ("1"); 
			Jump();
		}
		
		
		//Right Button
		//GUI.backgroundColor=Color.clear;
		if (GUI.Button (new Rect (Screen.width/2,50, Screen.width/2,Screen.height), "")) {
			print ("2"); 
		}
		
		//Escape Button
		//GUI.backgroundColor=Color.clear;
		if (GUI.Button (new Rect (Screen.width-40, 0 ,30,30), gear)) {
			Application.Quit(); print ("Salir de la aplicacion");
		} 
		
	} */


	}

/ / s a l t o  
 