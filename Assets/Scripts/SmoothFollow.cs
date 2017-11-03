using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    private Vector3 offset;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}