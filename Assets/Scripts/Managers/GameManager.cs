using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private float BPM = 120;
    public float bpm
    {
        get
        {
            return BPM;
        }
        set
        {
            BPM = value;
        }
    }

    public GameObject TitleUI;
    public GameObject TitleObject;
    public Text TitleText;
    
    // Components
    private Player player;

    // Initialized varables and get components
    private void Awake()
    {
        Application.targetFrameRate = 60;

        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if(player.fire.transform.position == Vector3.zero || player.ice.transform.position == Vector3.zero)
        {
            TitleUI.SetActive(true);
            TitleObject.SetActive(true);
        }
        else
        {
            TitleUI.SetActive(false);
            TitleObject.SetActive(false);
        }
    }

    private void LateUpdate()
    {
        TitleText.text = "A DANCE OF\n<color=#ff0000>FIRE</color> AND <color=#0000ff>ICE</color>";
    }
}
