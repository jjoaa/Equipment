# Equ Management
<br />

## 1. 소개
>  군 무기 및 장비의 정비 이력을 체계적으로 관리하기 위한  WPF 기반 데스크톱 애플리케이션입니다.  <br />
> 이 프로젝트는 **조직에서 사용하는 무기 및 장비**의 정비 이력을 관리하고 시각화하는 시스템입니다. <br />
> 장비의 등록, 정비 이력의 기록 및 조회 기능을 포함하고 있으며, 실시간 정비 이력 관리가 가능합니다. <br />



<br /> <br />
![image](https://github.com/user-attachments/assets/46868f42-a6c2-472e-bf54-88a6973ac761)
<br /> <br />
![image](https://github.com/user-attachments/assets/e861e5bc-f8d9-4b69-9984-12c1cab3c16b)
<br /> <br />
![image](https://github.com/user-attachments/assets/09049516-eb55-48ca-bdab-6e7b9bcb4f8c)
<br /> <br />

### 작업기간
2025/05, 1주
<br /><br />

### 인력구성
1인
<br /><br /><br />

## 2. 기술스택

<img src ="https://img.shields.io/badge/C_sharp-003545.svg?&style=for-the-badge&logo=Csharp&logoColor=brown"/> <img src="https://img.shields.io/badge/mysql-4479A1?style=for-the-badge&logo=mysql&logoColor=white">  <br /><br /> <br />

## 3. 기능
- 장비 등록 및 목록 조회 (예: K2 소총, K5 권총 등)
- 장비별 정비 이력 등록/관리
- 정비 이력 테이블 뷰 (날짜, 정비자, 내용, 다음 점검일 등)
- 장비 선택 시 해당 정비 이력 자동 필터링
- UI: WPF 기반 직관적인 사용자 인터페이스
- MySQL 연동: 데이터 영구 저장 및 관리 <br /><br /><br />

## 4. 기술 스택

| 구분       | 기술 |
|------------|------|
| Frontend   | WPF (XAML) |
| Backend    | C# (.NET 6 이상) |
| Database   | MySQL |

<br /><br /><br />  
## 5. 📂 Project Structure (폴더 구조)
```
Equipment/
├── /Data                                # EF Core DbContext 및 DB 관련 설정
│     └── AppDbContext.cs
├── /Models                              # DB 엔티티
│     ├── Equipment.cs
│     └── MaintenanceHistory.cs
├── /Views                               # XAML 윈도우/페이지
│     ├── MainWindow.xaml/.cs             -> main 페이지  / cs
│     ├── AddEquipmentWindow.xaml/.cs     -> 장비추가 페이지  / cs
│     ├── AddMaintenanceWindow.xaml/.cs   -> 정비이력 추가 페이지  / cs

```
<br /><br />


## 6. 앞으로 학습할 것들, 나아갈 방향
- 정비 이력 부분을 MongoDB 변환  
- 검색박스 추가해서 장비 이름으로 필터링
- 정비 이력 그리드에 페이징 또는 필터 기능 추가
  
<br /><br /> <br /> 
