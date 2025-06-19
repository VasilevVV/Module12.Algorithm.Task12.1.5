```mermaid
flowchart TD
    Begin(������) -->
    Task1[/"�������: ������� ���������� �������������"/] -->
    Task2[/"������� countUser"/] -->
    Task3[/"������� ������ �������������: arrayUsers = new User[countUser];"/]
    Task3 --> Cycle1
    subgraph "����1"
        Cycle1{{"for i = 0; i < countUser; i++"}} -->
        Task4[/"�������: ������� Login ������������ �{i}"/] -->
        Task5[/"������� arrayUsers[i].Login"/] -->
        Task6[/"�������: ������� Name ������������ �{i}"/] -->
        Task7[/"������� arrayUsers[i].Name"/] -->
        Task8[/"�������: ������� IsPremium ������������ �{i}"/] -->
        Task9[/"������� arrayUsers[i].IsPremium"/] -->
        |next i|Cycle1
      end
    Task10[/"�������: ��� ��������"/]
    Cycle1 ---------> Task10
    
    
```


by https://mermaid.js.org
and https://habr.com/ru/articles/652867/#flowchart