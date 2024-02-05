
using UnityEngine;
using UnityEngine.EventSystems;


public class Node : MonoBehaviour
{
    // Start is called before the first frame update
    public Color newColor;


    public Vector3 offSet;

    private Renderer rend;

    private GameObject turret;
    

    private Color startColor;

    BuildManager buildManager;
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor =  rend.material.color;
        buildManager = BuildManager.instance;
    }

    void OnMouseDown() 
    {
        if (buildManager.GetTurretToBuild() == null)
            return;
        
        if(turret != null)
        {
            return;
        }
        GameObject turrentToBuild = buildManager.GetTurretToBuild();
        turret = Instantiate(turrentToBuild, transform.position + offSet, transform.rotation);

    }
    void OnMouseEnter() 
    {

        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (buildManager.GetTurretToBuild() == null)
            return;
        rend.material.color = newColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
