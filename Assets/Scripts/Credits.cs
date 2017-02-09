using UnityEngine;
using System.Collections;
using System;

[ExecuteInEditMode]
public class Credits : MonoBehaviour {

	string credits = ("af Nicolaj Schweitz (legoleg.com) " +
	                  "med musik af Kevin MacLeod (incompetech.com): Organ Filler, Brightly Fancy, Beach Party\n" +
	                  "Godt Nytår til " +
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
	                  "og alle jer andre!\n");

	void Update ()
	{
		GetComponent<GUIText>().text = credits;
	}
}
