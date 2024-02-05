
using UnityEngine;

public class penal : MonoBehaviour
{
    // Start is called before the first frame update
    BuildManager buildManager;
    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseTurrent()
    {
        buildManager.SetTurretToBuild(buildManager.standardTurrentPrefab);
        return;
    }

    public void PurAnotherchaseTurrent()
    {
        buildManager.SetTurretToBuild(buildManager.standardMissTurrentPrefab);
        return;
    }
}
