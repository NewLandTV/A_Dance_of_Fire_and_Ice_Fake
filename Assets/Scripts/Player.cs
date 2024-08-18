using UnityEngine;

public class Player : MonoBehaviour
{
    // Player
    public GameObject fire;
    public GameObject ice;

    private bool isFireTurn;

    // Components
    private GameManager gameManager;

    // Initialized varables and get components
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.anyKeyDown)
        {
            isFireTurn = !isFireTurn;

            float fx = Mathf.Round(fire.transform.localPosition.x);
            float fy = Mathf.Round(fire.transform.localPosition.y);
            float ix = Mathf.Round(ice.transform.localPosition.x);
            float iy = Mathf.Round(ice.transform.localPosition.y);

            if ((fx == 1f && fy == 1f) || (fx == 1f && fy == -1f) || (fx == -1f && fy == 1f) || (fx == -1f && fy == -1f))
            {
                fx = 0f;
                fy = 0f;
            }
            if ((ix == 1f && iy == 1f) || (ix == 1f && iy == -1f) || (ix == -1f && iy == 1f) || (ix == -1f && iy == -1f))
            {
                ix = 0f;
                iy = 0f;
            }

            fire.transform.localPosition = new Vector3(fx, fy);
            ice.transform.localPosition = new Vector3(ix, iy);
        }

        if (isFireTurn)
        {
            fire.transform.RotateAround(ice.transform.localPosition, -Vector3.forward, gameManager.bpm * Time.deltaTime * 3.6f);
        }
        else
        {
            ice.transform.RotateAround(fire.transform.localPosition, -Vector3.forward, gameManager.bpm * Time.deltaTime * 3.6f);
        }
    }
}
