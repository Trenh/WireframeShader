using UnityEngine;
 
public class ActivateMaterial : MonoBehaviour
{
    public Material Material;
    Material[] oldMaterials;
    bool oldMat;
    // Use this for initialization
    void Start()
    {
        oldMat = true;
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        oldMaterials = meshRenderer.materials;
    }
    void Update()
    {
        if (Input.GetButtonDown("ActiveMat"))
        {
            ChangeMaterials();
        }    
    }

    void ChangeMaterials()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        if (!oldMat)
        {
            meshRenderer.materials = oldMaterials;
            oldMat = true;
            return;
        }
        
        //    Material = Resources.Load<Material>("Flat Wireframe");
        // Get the current material applied on the GameObject
       Material[] newMaterials = meshRenderer.materials;
        for (int i = 0; i < oldMaterials.Length; i++)
        {
            // Set the new material on the GameObject
           newMaterials[i] = Material;
        }
        meshRenderer.materials = newMaterials;
        oldMat = false;
    }
}