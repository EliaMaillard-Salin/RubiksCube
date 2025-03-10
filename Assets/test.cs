using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    GameObject meshObj;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        mesh.name = "Test";

        meshObj = new GameObject("Test Mesh", typeof(MeshRenderer), typeof(MeshFilter));


        mesh.vertices = new Vector3[4];
        mesh.vertices[0] = new Vector3(0,0,0);
        mesh.vertices[1] = new Vector3(0,1,0);
        mesh.vertices[2] = new Vector3(1,1,0);
        mesh.vertices[3] = new Vector3(1,0,0);

        mesh.triangles = new int[6];
        mesh.triangles[0] = 0;
        mesh.triangles[1] = 1;
        mesh.triangles[2] = 2;
        mesh.triangles[3] = 0;
        mesh.triangles[4] = 2;
        mesh.triangles[5] = 3;

        meshObj.GetComponent<MeshFilter>().mesh = mesh;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
