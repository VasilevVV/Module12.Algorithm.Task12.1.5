```mermaid
flowchart TD
    Begin(["������"]) -->
    Task1[/"�������: ������� ���������� �������������"/] -->
    Task2[/"������� countUser"/] -->
    Task3[/"������� ������ �������������: arrayUsers = new User[countUser];"/]
    Task3 --> Cycle1
    subgraph "���� �������������"
        Cycle1{{"for i = 0; i < countUser; i++"}} -->
        Task4[/"�������: ������� Login ������������ �{i}"/] -->
        Task5[/"������� arrayUsers[i].Login"/] -->
        Task6[/"�������: ������� Name ������������ �{i}"/] -->
        Task7[/"������� arrayUsers[i].Name"/] -->
        Task8[/"�������: ������� IsPremium ������������ �{i}"/] -->
        Task9[/"������� arrayUsers[i].IsPremium"/] -->
        |next i|Cycle1
      end
    Cycle1 --------> Cycle2
    subgraph "����������� �� �����"
        Cycle2{{"for i = 0; i < countUser; i++"}} -->
        Task10{"if (arrayUsers[i].IsPremium == true)"} 
        Task10 ----->|��|Task11[/"�������: ���������� arrayUsers[i].Name"/]
        Task10 -->|���|Task12[/"�������� �������: ShowAds()"/]
        Task12 ----> Task11 -------> |next i|Cycle2        
      end
    Cycle2 -------->
    Task13(["�����"]) 
```

by https://mermaid.js.org
and https://habr.com/ru/articles/652867/#flowchart

https://app.diagrams.net/