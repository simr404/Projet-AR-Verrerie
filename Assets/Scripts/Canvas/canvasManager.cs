using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour
{
    public GameObject accueil_canvas, collections_canvas, ma_collection_canvas;

    int chosenCollectionId;

    public Text textNomCollection;
    public Text textNomCollectionBis;
    public Text textDescription;

    CollectionManager collectionManager;

    void Start()
    {
        collectionManager = GameObject.Find("CollectionManager").GetComponent<CollectionManager>();
    }

    public void changeMyCanvas(int choice)
    {
        chosenCollectionId = choice;
        switch (choice)
        {
            case 0:
                break;
            case 1:
                textNomCollection.text = "Collection 1";
                textNomCollectionBis.text = "Collection 1";
                textDescription.text = "Vous pourrez profiter d'une collection raffinée inspirée de l'époque Victorienne.";
                CollectionManager.chosenCollectionId = 1;
                break;
            case 2:
                textNomCollection.text = "Collection 2";
                textNomCollectionBis.text = "Collection 2";
                textDescription.text = "Faites apparaître une collection simpliste et élégante.";
                CollectionManager.chosenCollectionId = 2;
                break;
            case 3:
                textNomCollection.text = "Collection 3";
                textNomCollectionBis.text = "Collection 3";
                textDescription.text = "Essayez une magnifique collection aux allures arrondies.";
                CollectionManager.chosenCollectionId = 3;
                break;
            default:
                Debug.LogError("Choix de collection non valide !");
                break;
        }
    }

    public void EnableAccueilCanvas()
    {
        accueil_canvas.SetActive(true);
        collections_canvas.SetActive(false);
        ma_collection_canvas.SetActive(false);
    }
    public void EnableCollectionsCanvas()
    {
        accueil_canvas.SetActive(false);
        collections_canvas.SetActive(true);
        ma_collection_canvas.SetActive(false);
    }

    public void EnableMaCollectionCanvas()
    {
        accueil_canvas.SetActive(false);
        collections_canvas.SetActive(false);
        ma_collection_canvas.SetActive(true);
    }

    public void clickValider()
    {
        SceneManager.LoadScene(1);
    }

    public void clickMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void quitButton()
    {
        Application.Quit();
        Debug.Log("on quite l'application");
    }
}
