using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexContinent : HexGenerate
{



    override public void GenerateMap()
    {
        base.GenerateMap();
        ElevateArea(21, 15, 4);


        // Perlin Noise :

        // Set Mmesh to mountain/hill/flat/wter 

        // Simumate rain fall / moisture and set plain Grassland + forest
        UpdateHexVisuals();
    }
    // Start is called before the first frame update

    void ElevateArea(int q, int r, int radius) 
    {
       // Hex centerHex = GetHexAt(q, r);
       // Debug.Log(centerHex.Elevation);
       // centerHex.Elevation = 0.5f;
    }
}
