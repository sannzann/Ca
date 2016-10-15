using UnityEngine;
using System.Collections;

public class SceneLoadScript : MonoBehaviour {
	public GameObject botanname;
	public void SceneLoad (){

		if(botanname.name=="Stert"){
			Application.LoadLevel ("main");
		}
		if(botanname.name=="restert"){
			Application.LoadLevel ("main");
		}
		if(botanname.name=="gotostert"){
			Application.LoadLevel ("Stert");
		}

	}

}