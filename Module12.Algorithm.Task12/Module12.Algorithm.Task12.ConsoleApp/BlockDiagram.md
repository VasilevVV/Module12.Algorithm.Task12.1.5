```mermaid
flowchart TD
    Begin(["начало"]) -->
    Task1[/"вывести: введите количество пользователей"/] -->
    Task2[/"считать countUser"/] -->
    Task3[/"создать список пользователей: arrayUsers = new User[countUser];"/]
    Task3 --> Cycle1
    subgraph "ввод пользователей"
        Cycle1{{"for i = 0; i < countUser; i++"}} -->
        Task4[/"вывести: введите Login пользователя №{i}"/] -->
        Task5[/"считать arrayUsers[i].Login"/] -->
        Task6[/"вывести: введите Name пользователя №{i}"/] -->
        Task7[/"считать arrayUsers[i].Name"/] -->
        Task8[/"вывести: введите IsPremium пользователя №{i}"/] -->
        Task9[/"считать arrayUsers[i].IsPremium"/] -->
        |next i|Cycle1
      end
    Cycle1 --------> Cycle2
    subgraph "приветствие по имени"
        Cycle2{{"for i = 0; i < countUser; i++"}} -->
        Task10{"if (arrayUsers[i].IsPremium == true)"} 
        Task10 ----->|да|Task11[/"вывести: Приветсвую arrayUsers[i].Name"/]
        Task10 -->|нет|Task12[/"показать рекламу: ShowAds()"/]
        Task12 ----> Task11 -------> |next i|Cycle2        
      end
    Cycle2 -------->
    Task13(["конец"]) 
```

by https://mermaid.js.org
and https://habr.com/ru/articles/652867/#flowchart

https://app.diagrams.net/