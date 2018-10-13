using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public SkinnedMeshRenderer Renderer;
    public Material instancedMaterial;
	// Use this for initialization
	void Start () {

        //J'accede au renderer et au material
        Renderer = gameObject.GetComponent<SkinnedMeshRenderer>();
        instancedMaterial = Renderer.material;
	}
	
	// Update is called once per frame
	void Update () {

        //Je change le float avec l'axe horizontal
        if (Input.GetKeyDown("a"))
        {

        
            instancedMaterial.SetFloat("_Speed", speed);
        }
       

        
        //Je set le float qui me fait progresser la dematerialisation
        //instancedMaterial.SetFloat("_Speed", speed);
	}
}
