using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform personagem;
    private float cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        CameraSegue();
    }

    void CameraSegue()
    {
        transform.position = new Vector3(personagem.position.x + 0.5f, 0, cam);
    }

}
