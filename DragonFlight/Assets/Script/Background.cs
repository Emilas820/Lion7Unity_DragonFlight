using UnityEngine;

public class Background : MonoBehaviour
{
    // 스크롤이 되는 배경
    public float scrollSpeed = 0.5f;
    private Material BGmaterial;

    void Start()
    {
        // 오브젝트 자신에 붙어있는 머터리얼 가져오기
        // Material이 아닌, MashRanderer에 붙어있는 material을 가져오는 방식으로 한다.
        BGmaterial = GetComponent<Renderer>().material;        
    }

    void Update()
    {
        // offset 머터리얼에서 가져오기
        Vector2 newOffset = BGmaterial.mainTextureOffset;

        // 새롭게 offset 바꿔주기
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));

        // 새롭게 변경한 offset값을 BGmaterial에 넣어주기
        BGmaterial.mainTextureOffset = newOffset;
    }


}
