using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIWorldMap : MonoBehaviour
{
    public GameObject panel;
    public KeyCode hotKey = KeyCode.M;
    public float zoomMin = 5;
    public float zoomMax = 50;
    public float zoomStepSize = 5;
    public Text sceneText;
    public Button plusButton;
    public Button minusButton;
    public Camera WorldMapCamera;
    public Button resetButton;
    private Vector3 camoriginposition;

    void Start()
    {
        plusButton.onClick.SetListener(() => {
            WorldMapCamera.orthographicSize = Mathf.Max(WorldMapCamera.orthographicSize - zoomStepSize, zoomMin);
        });
        minusButton.onClick.SetListener(() => {
            WorldMapCamera.orthographicSize = Mathf.Min(WorldMapCamera.orthographicSize + zoomStepSize, zoomMax);
        });
        resetButton.onClick.SetListener(() => {
            WorldMapCamera.transform.localPosition = camoriginposition;
        });

    }

    public void Update()
    {
        Player player = Player.localPlayer;
        if (player)
        {
            // hotkey (not while typing in chat, etc.)
            if (Input.GetKeyDown(hotKey) && !UIUtils.AnyInputActive())
                panel.SetActive(!panel.activeSelf);
            sceneText.text = SceneManager.GetActiveScene().name;
        }
        else panel.SetActive(false);
    }
}