using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public  partial class WorldMap : MonoBehaviour

{
    public Camera WorldMapCamera;
    public Button OpenWorldMapButton;
    public GameObject OpenWorldMapPanel;
    public Vector3 cameraoriginposition;

 void Update()
    {
       
        {
            OpenWorldMapButton.onClick.SetListener(() => {
                OpenWorldMapPanel.SetActive(!OpenWorldMapPanel.activeSelf);
                WorldMapCamera.transform.localPosition = cameraoriginposition;
            });
           
        }
       
    }
}

