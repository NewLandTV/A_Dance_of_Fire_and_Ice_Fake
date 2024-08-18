using UnityEngine;

public class Tile : MonoBehaviour
{
    private GameManager gameManager;

    public bool LobbyTile;
    private bool isHit;
    public Type type;

    public float bpm;

    private float lobbySpeedCount;

    public enum Type
    {
        Basic,
        LevelEditor,
        Continue,
        Correction,
        CustomLevel,
        ChangeBPM
    }

    // Initialized varables and get components
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (LobbyTile)
        {
            isHit = false;
        }
        if ((collision.CompareTag("Fire") || collision.CompareTag("Ice")) && Input.anyKeyDown && !isHit)
        {
            isHit = true;

            Debug.Log(type);

            switch (type)
            {
                case Type.LevelEditor:
                    break;
                case Type.Continue:
                    break;
                case Type.Correction:
                    break;
                case Type.CustomLevel:
                    break;
                case Type.ChangeBPM:
                    if (LobbyTile)
                    {
                        gameManager.bpm *= lobbySpeedCount % 2 == 0 ? 2f : 0.5f;
                        lobbySpeedCount++;
                    }
                    else
                    {
                        gameManager.bpm = bpm;
                    }
                    break;
            }
        }
    }
}
