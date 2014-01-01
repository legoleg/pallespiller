using UnityEngine;
using System.Collections;
using System;

[ExecuteInEditMode]
public class Credits : MonoBehaviour {

	string credits = ("The game is made by Nicolaj Schweitz (legoleg.com)\n" +
	                  "Happy New Year to: " +
	                  "Albert, " +
	                  "Alma, " +
	                  "Ellen, " +
	                  "Hedvig, " +
	                  "Ingeborg, " +
	                  "Jesper, " +
	                  "Laura, " +
	                  "Liv, " +
	                  "Kasper, " +
	                  "Maj, " +
	                  "Morten, " +
	                  "Oskar, " +
	                  "Rikke, " +
	                  "Sigrid, " +
	                  "Tina, " +
	                  "Trine, " +
	                  "& everyone else!\n" +
	                  "The music is made by Kevin MacLeod (incompetech.com): Organ Filler (main menu), Brightly Fancy (in-game), Beach Party (score)\n");

	void Update ()
	{
		guiText.text = credits;
	}
}
