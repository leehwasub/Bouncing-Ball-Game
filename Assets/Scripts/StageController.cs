using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    [SerializeField]
    private Tilemap2D tilemap2D; // MapData 정보를 바탕으로 맵을 생성하기 위한 Tilemap2D
    [SerializeField]
    private PlayerController playerController; // 플레이어 Setup() 메소드 호출을 위한 PlayerController
    [SerializeField]
    private CameraController cameraController; // 카메라 시야 설정을 위한 CameraController
    [SerializeField]
    private StageUI stageUI;

    private void Awake()
    {
        // MapDataLoader 클래스 인스턴스 생성 및 메모리 할당
        MapDataLoader mapDataLoader = new MapDataLoader();

        // 현재 저장되어 있는 json 파일이 Stage01, Stage02.. 이기때문에 "Stage01" 데이터를 불러온다
        MapData mapData = mapDataLoader.Load("Stage01");

        // mapData 정보를 바탕으로 타일 형태의 맵 생성
        tilemap2D.GenerateTilemap(mapData);

        // mapData.playerPosition 정보를 바탕으로 플레이어 위치 설정
        playerController.Setup(mapData.playerPosition, mapData.mapSize.y);

        // 맵의 크기 정보(mapData.mapSize)를 바탕으로 카메라 시야 크기 설정
        cameraController.Setup(mapData.mapSize.x, mapData.mapSize.y);

        // 현재 스ㅔ이지의 정보를 UI에 출력
        stageUI.UpdateTextStage("Stage01");
    }

    public void GameClear()
    {
        Debug.Log("Game Clear");
    }

}
