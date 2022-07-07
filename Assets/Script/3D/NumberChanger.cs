using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberChanger : MonoBehaviour
{
    private static Vector2[] UvCheck =
    {
        new Vector2 (0.5f, 0.25f),
        new Vector2 (0.75f,0.5f),
        new Vector2 (0.75f,0.25f),
        new Vector2 (0.5f,0.5f)
    };
    private void Awake()
    {
        CangeUvCheck();
    }

    public void CangeUvCheck()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.uv = UvCheck;
    }
}
