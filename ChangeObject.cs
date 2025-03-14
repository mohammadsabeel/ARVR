using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterial : MonoBehaviour
{
    public GameObject cube, sphere, plane;
    public Material cubeMaterial, sphereMaterial, planeMaterial;
    public Texture cubeTexture1, cubeTexture2, sphereTexture1, sphereTexture2, planeTexture1, planeTexture2;

    private Renderer cubeRenderer, sphereRenderer, planeRenderer;

    void Start()
    {
        if (cube == null || sphere == null || plane == null)
        {
            Debug.LogError("Assign Cube, Sphere, and Plane in the Inspector!");
            return;
        }

        cubeRenderer = cube.GetComponent<Renderer>();
        sphereRenderer = sphere.GetComponent<Renderer>();
        planeRenderer = plane.GetComponent<Renderer>();

        // Assign initial materials
        cubeRenderer.material = cubeMaterial;
        sphereRenderer.material = sphereMaterial;
        planeRenderer.material = planeMaterial;
    }

    // Change Cube Color
    public void ChangeCubeColor()
    {
        cubeRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }

    // Change Cube Texture
    public void ChangeCubeTexture()
    {
        cubeRenderer.material.mainTexture = (cubeRenderer.material.mainTexture == cubeTexture1) ? cubeTexture2 : cubeTexture1;
    }

    // Change Sphere Color
    public void ChangeSphereColor()
    {
        sphereRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }

    // Change Sphere Texture
    public void ChangeSphereTexture()
    {
        sphereRenderer.material.mainTexture = (sphereRenderer.material.mainTexture == sphereTexture1) ? sphereTexture2 : sphereTexture1;
    }

    // Change Plane Color
    public void ChangePlaneColor()
    {
        planeRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }

    // Change Plane Texture
    public void ChangePlaneTexture()
    {
        planeRenderer.material.mainTexture = (planeRenderer.material.mainTexture == planeTexture1) ? planeTexture2 : planeTexture1;
    }
}
