using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubicksCube : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Color m_colorFace1;
    [SerializeField] private Color m_colorFace2;
    [SerializeField] private Color m_colorFace3;

    public MeshFilter m_filter;

    private Mesh m_mesh;

    GameObject m_line1;
    GameObject m_line2;
    GameObject m_line3;

    GameObject m_column1;
    GameObject m_column2;
    GameObject m_column3;

    public int line;
    public int column;

    void Start()
    {
        m_mesh = new Mesh();
        m_mesh.name = "Custom Face";

        m_mesh.vertices = new Vector3[24];
        m_mesh.vertices[0] = new Vector3( -0.5f, -0.5f, -0.5f ); //Face
        m_mesh.vertices[1] = new Vector3(0.5f, -0.5f, -0.5f);
        m_mesh.vertices[2] = new Vector3(0.5f, 0.5f, -0.5f);
        m_mesh.vertices[3] = new Vector3(-0.5f, 0.5f, -0.5f);

        m_mesh.vertices[4] = new Vector3(0.5f, -0.5f, -0.5f); //right
        m_mesh.vertices[5] = new Vector3(0.5f, -0.5f, 0.5f);
        m_mesh.vertices[6] = new Vector3(0.5f, 0.5f, 0.5f);
        m_mesh.vertices[7] = new Vector3(0.5f, 0.5f, -0.5f);

        m_mesh.vertices[8] = new Vector3(0.5f, -0.5f, 0.5f); // Back
        m_mesh.vertices[9] = new Vector3(-0.5f, -0.5f, 0.5f);
        m_mesh.vertices[10] = new Vector3(-0.5f, 0.5f, 0.5f);
        m_mesh.vertices[11] = new Vector3(0.5f, 0.5f, 0.5f);

        m_mesh.vertices[12] = new Vector3(-0.5f, -0.5f, 0.5f); // Left
        m_mesh.vertices[13] = new Vector3(-0.5f, -0.5f, -0.5f);
        m_mesh.vertices[14] = new Vector3(-0.5f, 0.5f, -0.5f);
        m_mesh.vertices[15] = new Vector3(-0.5f, 0.5f, 0.5f);

        m_mesh.vertices[16] = new Vector3(-0.5f, 0.5f, -0.5f); // top
        m_mesh.vertices[17] = new Vector3(0.5f, 0.5f, -0.5f);
        m_mesh.vertices[18] = new Vector3(0.5f, 0.5f, 0.5f);
        m_mesh.vertices[19] = new Vector3(-0.5f, 0.5f, 0.5f);

        m_mesh.vertices[20] = new Vector3(-0.5f, -0.5f, 0.5f); // bottom
        m_mesh.vertices[21] = new Vector3(0.5f, -0.5f, 0.5f);
        m_mesh.vertices[22] = new Vector3(0.5f, -0.5f, -0.5f);
        m_mesh.vertices[23] = new Vector3(-0.5f, -0.5f, -0.5f);

        m_mesh.colors = new Color[24];
        m_mesh.colors[0] = m_colorFace1;
        m_mesh.colors[1] = m_colorFace1;
        m_mesh.colors[2] = m_colorFace1;
        m_mesh.colors[3] = m_colorFace2;

        m_mesh.colors[4] = m_colorFace2;
        m_mesh.colors[5] = m_colorFace2;
        m_mesh.colors[6] = m_colorFace2;
        m_mesh.colors[7] = m_colorFace2;

        m_mesh.colors[8] = m_colorFace1;
        m_mesh.colors[9] = m_colorFace1;
        m_mesh.colors[10] = m_colorFace1;
        m_mesh.colors[11] = m_colorFace1;
        
        m_mesh.colors[12] = m_colorFace2;
        m_mesh.colors[13] = m_colorFace2;
        m_mesh.colors[14] = m_colorFace2;
        m_mesh.colors[15] = m_colorFace2;
        
        m_mesh.colors[16] = m_colorFace3;
        m_mesh.colors[17] = m_colorFace3;
        m_mesh.colors[18] = m_colorFace3;
        m_mesh.colors[19] = m_colorFace3;
        
        m_mesh.colors[20] = m_colorFace3;
        m_mesh.colors[21] = m_colorFace3;
        m_mesh.colors[22] = m_colorFace3;
        m_mesh.colors[23] = m_colorFace3;


        m_mesh.triangles = new int[36];
        m_mesh.triangles[0] = 0; // Front
        m_mesh.triangles[1] = 3;
        m_mesh.triangles[2] = 2;
        m_mesh.triangles[3] = 0;
        m_mesh.triangles[4] = 2;
        m_mesh.triangles[5] = 1;

        m_mesh.triangles[6] = 4; // Right
        m_mesh.triangles[7] = 7;
        m_mesh.triangles[8] = 6;
        m_mesh.triangles[9] = 4;
        m_mesh.triangles[10] = 6;
        m_mesh.triangles[11] = 5;

        m_mesh.triangles[12] = 8; // Back
        m_mesh.triangles[13] = 11;
        m_mesh.triangles[14] = 10;
        m_mesh.triangles[15] = 8;
        m_mesh.triangles[16] = 10;
        m_mesh.triangles[17] = 9;

        m_mesh.triangles[18] = 12; // Left
        m_mesh.triangles[19] = 15;
        m_mesh.triangles[20] = 14;
        m_mesh.triangles[21] = 12;
        m_mesh.triangles[22] = 14;
        m_mesh.triangles[23] = 13;

        m_mesh.triangles[24] = 16; // Top
        m_mesh.triangles[25] = 19;
        m_mesh.triangles[26] = 18;
        m_mesh.triangles[27] = 16;
        m_mesh.triangles[28] = 18;
        m_mesh.triangles[29] = 17;

        m_mesh.triangles[30] = 20; // Bottom
        m_mesh.triangles[31] = 23;
        m_mesh.triangles[32] = 22;
        m_mesh.triangles[33] = 20;
        m_mesh.triangles[34] = 22;
        m_mesh.triangles[35] = 21;

        m_filter.mesh = m_mesh;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
