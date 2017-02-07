# Unity5AssetBundleDemo
Unity 5.x AssetBundle Demo(export, import)


# 목적

- Unity 5.x 에서 변경된 에셋번들 생성과 사용방법을 파악한다.


# 에셋 번들 생성 방법


1. 에셋번들로 패키징될 파일 선택

에셋번들로 생성할 텍스쳐, 프리팹 등을 선택하고 Inspector 하단에

AssetBundle - New 를 선택해서 파일명을 입력한다.

추가적인 리소스는 해당 리스트에서 선택하면 되다.


2. 생성 스크립트 작성

Editor/CreateAssetBundles.cs



# 에셋 번들 로컬 사용 (OSX 기준)

StreamingAssets 디렉토리를 만들어 두면 빌드시에 함께 패키징 된다.



# 에셋 번들 원격 다운로드 (AOS 기준)

AssetBundles 디렉토리의 파일들을 서버에 올려둔다.

TODO : www 를 이용