using UnityEngine;
using System.Collections;

public class WaveGenerator : MonoBehaviour
{
    void Update()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        //Vector3[] normals = mesh.normals;
        int i = 0;
        while (i < vertices.Length)
        {
            vertices[i] += Vector3.up * Mathf.Sin(Time.time);
            i++;
        }
        mesh.vertices = vertices;
    }
}
