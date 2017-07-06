using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// this class is for changing the text with a text controller.

public class TextController : MonoBehaviour {

	// List the states we can be in
	private enum States
	{	hangar, control, escape, mess, capt, crew, weapons, medical, engineering, nuclear,
    	death, communication, freedom, wallHR, wallCR, wallES, wallCQ, wallCW, wallMD,
		wallEE, wallCO}

	// This will be used to determine which state that I am in.
	private States myState;

	// Variable named text using Unity Engine.UI
	public Text text;

	// Use this for initialization
	void Start(){myState = States.mess;}
	
	// Update is called once per frame
	void Update () 
	{
	
		print (myState);
		if 		(myState == States.hangar)			{hangar();}
		else if (myState == States.control)      	{control_panel();}
		else if (myState == States.escape)       	{escape_pod();}
		else if (myState == States.mess)         	{mess_hall();}
		else if (myState == States.capt)         	{capt_quarters();}
		else if (myState == States.crew)         	{crew_quarters();}
		else if (myState == States.weapons)      	{weapons_depot();}
		else if (myState == States.medical)      	{medical_bay();}
		else if (myState == States.engineering)  	{engineering();}
		else if (myState == States.nuclear)      	{nuclear_reactor();}
		else if (myState == States.death)        	{death();}
		else if (myState == States.communication)	{communication();}
		else if (myState == States.freedom)      	{freedom();}
		else if (myState == States.wallHR)       	{wall_HR();}
		else if (myState == States.wallCR)       	{wall_CR();}
		else if (myState == States.wallES)	 	 	{wall_ES();}
		else if (myState == States.wallCQ)       	{wall_CQ();}
		else if (myState == States.wallCW)       	{wall_CW();}
		else if (myState == States.wallMD)       	{wall_MD();}
		else if (myState == States.wallEE)			{wall_EE();}
		else if (myState == States.wallCO)			{wall_CO();}
	}

	void hangar(){
		text.text = "You find yourself in an abandoned Space Freighter hangar bay.  " +
			"Red lights are flashing, indicating low air supply and abandonship " +
			"The escape pods in the hangar all look like they have been evacutated.\n\n" +
			"Press N to go North, S to go South, E to go East, and W to go West";
		if (Input.GetKeyDown (KeyCode.N)) 
			myState = States.control;
		else if (Input.GetKeyDown (KeyCode.E))
			myState = States.mess;
		else if (Input.GetKeyDown (KeyCode.S)) 
			myState = States.escape;
		else if (Input.GetKeyDown (KeyCode.W))
			myState = States.wallHR;
	}
			
	void control_panel(){
		text.text = "you have found the control panel for the hangar, most of the gadgets" +
			" are broken or it would appear that the power is out. Does not seem to be helpful" +
			"\n\nPress N to go North, S to go South, E to go East, and W to go West";
			if (Input.GetKeyDown (KeyCode.N)) 
				myState = States.wallCR;
			else if (Input.GetKeyDown (KeyCode.E))
				myState = States.wallCR;
			else if (Input.GetKeyDown (KeyCode.S)) 
				myState = States.hangar;
			else if (Input.GetKeyDown (KeyCode.W))
				myState = States.wallCR;
	}

	void escape_pod(){
		text.text = "the escape pod docks all seem to be evacutated, there is one still left" +
			" but by the look of it does not seem to have any chance of repair.\n\n" +
			"Press N to go North, S to go South, E to go East, and W to go West";
		if (Input.GetKeyDown (KeyCode.N)) 
			myState = States.hangar;
		else if (Input.GetKeyDown (KeyCode.E))
			myState = States.wallES;
		else if (Input.GetKeyDown (KeyCode.S)) 
			myState = States.wallES;
		else if (Input.GetKeyDown (KeyCode.W))
			myState = States.wallES;
	}

	void mess_hall(){
		text.text = "you find the messhall, the worst messhall you have ever seen." +
			"the majority of the things you find here are useless.  however there are four " +
			"doors in the room leading to the crew and captains quarters and the weapons depot.\n\n" +
			"Press N to go North, S to go South, E to go East, and W to go West";
		if (Input.GetKeyDown (KeyCode.N)) 
			myState = States.crew;
		else if (Input.GetKeyDown (KeyCode.E))
			myState = States.weapons;
		else if (Input.GetKeyDown (KeyCode.S)) 
			myState = States.capt;
		else if (Input.GetKeyDown (KeyCode.W))
			myState = States.hangar;
	}

	void capt_quarters(){
		text.text = "you find the captains quarters like all other places of the ship with the " +
			"abandoned feeling the ship has the captain still there.  He had decided in your" +
			" opionion to go down with the ship\n\n" +
			"Press N to go North, S to go South, E to go East, and W to go West";
		if (Input.GetKeyDown (KeyCode.N)) 
			myState = States.mess;
		else if (Input.GetKeyDown (KeyCode.E))
			myState = States.wallCQ;
		else if (Input.GetKeyDown (KeyCode.S)) 
			myState = States.wallCQ;
		else if (Input.GetKeyDown (KeyCode.W))
			myState = States.wallCQ;
	}

	void crew_quarters(){
		text.text = "What a mess, people actually live here.  The crew quarters are all gone, perhaps" +
			" most of the crew got away in the escape pods.\n\n" +
			"Press N to go North, S to go South, E to go East, and W to go West";
		if (Input.GetKeyDown (KeyCode.N)) 
			myState = States.wallCW;
		else if (Input.GetKeyDown (KeyCode.E))
			myState = States.wallCW;
		else if (Input.GetKeyDown (KeyCode.S)) 
			myState = States.mess;
		else if (Input.GetKeyDown (KeyCode.W))
			myState = States.wallCW;
	}

	void weapons_depot(){
		text.text = "there are some of the largest and heaviest guns and armor you have ever" +
			" seen in your life in here.  nothing of use, but there is a door to the north for engineering " +
			"to the east is the comm room, and south is the med bay\n\n" +
			"Press N to go North, S to go South, E to go East, and W to go West";
		if (Input.GetKeyDown (KeyCode.N)) 
			myState = States.engineering;
		else if (Input.GetKeyDown (KeyCode.E))
			myState = States.communication;
		else if (Input.GetKeyDown (KeyCode.S)) 
			myState = States.medical;
		else if (Input.GetKeyDown (KeyCode.W))
			myState = States.mess;
	}

	void medical_bay(){
		text.text = "the med bay is empty, not a single syrine or drug, it looks like it was looted," +
			" perhaps the medics thought they better take everything before going down, to the escape pods." +
			" \n\n" +
			"Press N to go North, S to go South, E to go East, and W to go West";
		if (Input.GetKeyDown (KeyCode.N)) 
			myState = States.weapons;
		else if (Input.GetKeyDown (KeyCode.E))
			myState = States.wallMD;
		else if (Input.GetKeyDown (KeyCode.S)) 
			myState = States.wallMD;
		else if (Input.GetKeyDown (KeyCode.W))
			myState = States.wallMD;	
	}

	void engineering(){
		text.text = "you walk into the egineering room which seems to have the main problem.  the main problem" +
			"with the ship seems to be coming from behind the door to the east.\n\n" +
			"Press N to go North, S to go South, E to go East, and W to go West";
		if (Input.GetKeyDown (KeyCode.N)) 
			myState = States.wallEE;
		else if (Input.GetKeyDown (KeyCode.E))
			myState = States.nuclear;
		else if (Input.GetKeyDown (KeyCode.S)) 
			myState = States.weapons;
		else if (Input.GetKeyDown (KeyCode.W))
			myState = States.wallEE;
	}

	void nuclear_reactor(){
		text.text = "you walked thought the door from enigeering only to discover you have found" +
			" the ships main power source, its nuclear reactor.  strange it seems to be cracked down the" +
			" center of the shell.\n\n" +
			"Press N to go North, S to go South, E to go East, and W to go West";
		if (Input.GetKeyDown (KeyCode.N)) 
			myState = States.death;
		else if (Input.GetKeyDown (KeyCode.E))
			myState = States.death;
		else if (Input.GetKeyDown (KeyCode.S)) 
			myState = States.death;
		else if (Input.GetKeyDown (KeyCode.W))
			myState = States.death;
	}

	void death(){
		text.text = "You try to get out any way you can only to find you have been locked in with the contamination." +
			" your fate is sealed and now you will die, a slow and painful death.\n\n" +
			"Press Space to play Again";
		if (Input.GetKeyDown (KeyCode.Space)) 
			myState = States.hangar;
	}

	void communication(){
		text.text = "We are at communications Array\n\n" +
			"Press N to go North, S to go South, E to go East, and W to go West";
		if (Input.GetKeyDown (KeyCode.N)) 
			myState = States.wallCO;
		else if (Input.GetKeyDown (KeyCode.E))
			myState = States.wallCO;
		else if (Input.GetKeyDown (KeyCode.S)) 
			myState = States.freedom;
		else if (Input.GetKeyDown (KeyCode.W))
			myState = States.weapons;
	}

	void freedom(){
		text.text = "We are at the communications array, which seems to be still" +
			"functioning, you make a call out to be rescued and are intercepted by" +
			"a passing freighter who tells you that they can help, congratualtions you are" +
			"saved!\n\n" +
			"Press Space to playAgain";
		if (Input.GetKeyDown (KeyCode.Space)) 
			myState = States.hangar;
	}

	void wall_HR(){
		text.text = "Does not seem to be anything more then a blank wall.\n\n" +
					"Press space to continue roaming the hangar";
		if (Input.GetKeyDown (KeyCode.Space))
			myState = States.hangar;
	}

	void wall_CR(){	
			text.text = "Another Wall with gadgets and gizmo's that seem to appear broken.\n\n" +
						"Press space to continue roaming the hangar";
			if (Input.GetKeyDown (KeyCode.Space))
				myState = States.control;
		}	

	void wall_ES(){	
		text.text = "All of the escape pods on the freighter are evacutated no help here.\n\n" +
			"Press space to continue roaming the hangar";
		if (Input.GetKeyDown (KeyCode.Space))
			myState = States.escape;
	}	

	void wall_CQ(){	
		text.text = "The captain must of had a thing for alien women. Nothing useful in this room.\n\n" +
			"Press space to continue roaming the hangar";
		if (Input.GetKeyDown (KeyCode.Space))
			myState = States.capt;
	}	

	void wall_CW(){	
		text.text = "The crew's quarters is a total mess, These living conditions are terrible.\n\n" +
			"Press space to continue roaming the hangar";
		if (Input.GetKeyDown (KeyCode.Space))
			myState = States.crew;
	}	

	void wall_MD(){	
		text.text = "Other then the blood on the wall and empty cabinets nothing helpful here.\n\n" +
			"Press space to continue roaming the hangar";
		if (Input.GetKeyDown (KeyCode.Space))
			myState = States.medical;
	}	

	void wall_EE(){	
		text.text = "There an alert button about the power generator, best not go in there.\n\n" +
			"Press space to continue roaming the hangar";
		if (Input.GetKeyDown (KeyCode.Space))
			myState = States.engineering;
	}	

	void wall_CO(){	
		text.text = "There is enought power to broadcast thankfully. Perhaps you can be rescued.\n\n" +
			"Press space to continue roaming the hangar";
		if (Input.GetKeyDown (KeyCode.Space))
			myState = States.communication;
	}	

}
