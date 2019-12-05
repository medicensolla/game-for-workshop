using static Utils.Constantes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class colorRandom : MonoBehaviour
{

    public MeshRenderer meshRenderer = new MeshRenderer();
    // Start is called before the first frame update
    void Start()
    {
        this.CambiarColor(meshRenderer, Random.ColorHSV());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
