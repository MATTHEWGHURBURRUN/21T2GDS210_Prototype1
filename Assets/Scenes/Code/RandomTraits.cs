using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomTraits : MonoBehaviour
{
	int trait1;
	int trait2;
	string[] traits;
	Text uiText;
	
    // Start is called before the first frame update
    void Start()
    {
        traits = new string[]{"Gluttonous","Likes Pizza","Not Potty Trained", "Reclusive","Sclerotic"};
		
		trait1= Random.Range(0,4);
		trait2= Random.Range(0,4);
		
		
		while (trait1 == trait2){
			
			trait2= Random.Range(0,4);
		}
		Debug.Log(traits[trait1]);
		Debug.Log(traits[trait2]);
		
		uiText = GameObject.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
		uiText.text = "The traits you are looking for are " + traits[trait1]+ " and " + traits[trait2] ;
		
		
    }

}