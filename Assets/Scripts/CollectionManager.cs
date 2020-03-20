using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectionManager : MonoBehaviour
{
    GameObject[] collection1;
    GameObject[] collection2;
    GameObject[] collection3;

    public static int chosenCollectionId = 0;

    bool modelsAreLoaded = false;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        if (!modelsAreLoaded && SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        {
            modelsAreLoaded = true;
            GetModels();
            SetCollection();
        }
    }

    void GetModels()
    {
        collection1 = GameObject.FindGameObjectsWithTag("Collection1");
        collection2 = GameObject.FindGameObjectsWithTag("Collection2");
        collection3 = GameObject.FindGameObjectsWithTag("Collection3");

        foreach (GameObject go in collection1)
        {
            print(go.name);
        }
    }

    public void SetCollection()
    {
        //changement de la collection en fonction de la sélection
        switch(chosenCollectionId)
        {
            case 1:
                foreach(GameObject model in collection1) model.SetActive(true);
                foreach(GameObject model in collection2) model.SetActive(false);
                foreach(GameObject model in collection3) model.SetActive(false);
                break;
            case 2:
                foreach(GameObject model in collection1) model.SetActive(false);
                foreach(GameObject model in collection2) model.SetActive(true);
                foreach(GameObject model in collection3) model.SetActive(false);
                break;
            case 3:
                foreach(GameObject model in collection1) model.SetActive(false);
                foreach(GameObject model in collection2) model.SetActive(false);
                foreach(GameObject model in collection3) model.SetActive(true);
                break;
            default:
                Debug.LogError("Collection non valide !");
                break;
        }
    }
}
