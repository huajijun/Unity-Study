using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transport : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {   // 加载新的场景  索引 或者名字
    //     //SceneManager.LoadScene(1);
    //     // 获取当前场景
    //     Scene  scene = SceneManager.GetActiveScene();
    //     // 获取名字
    //     Debug.Log(SceneManager.GetActiveScene().name);
    //     // 场景是否被加载了
    //     Debug.Log(scene.isLoaded);
    //     // 场景路径
    //     Debug.Log(scene.path);
    //     // 场景的索引
    //     Debug.Log(scene.buildIndex);

    //     GameObject[] gos = scene.GetRootGameObjects();
    //     Debug.Log(gos);

    //     // 场景管理类
    //     Debug.Log(SceneManager.sceneCount);
    //     Scene script_scene = SceneManager.CreateScene("script scene");
    //     SceneManager.UnloadSceneAsync(script_scene);

    //     // SceneManager.LoadScene(1,LoadSceneMode.Single);
    //     // 叠加
    //     SceneManager.LoadScene(1,LoadSceneMode.Additive);

    // }

    //异步加载
    // 通过Transform 来维持父子关系
    AsyncOperation operation;
    float time = 0;
    IEnumerator zzyloadScene() {
       operation =  SceneManager.LoadSceneAsync(1);
       // 加载完 后不要自动跳转
       operation.allowSceneActivation = false;
       yield return operation;
    }
    void Start()
    {
        StartCoroutine(zzyloadScene());
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(operation.progress);
        time += Time.deltaTime;
        if (time > 5) {
            operation.allowSceneActivation = true;
        }
    }
}
