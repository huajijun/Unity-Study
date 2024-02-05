using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static BuildManager instance;
    public GameObject standardTurrentPrefab;
    public GameObject standardMissTurrentPrefab;
    
    private GameObject turrentToBuild;

    void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }

   
    public GameObject GetTurretToBuild()
    {
       return turrentToBuild;
    }
    public void SetTurretToBuild(GameObject turret)
    {
        turrentToBuild = turret;
    }
}
