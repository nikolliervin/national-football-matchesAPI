## About the API
This api gets you the results of all national football matches played from 1872 to 2022. 
The api is built under this dataset: https://www.kaggle.com/datasets/martj42/international-football-results-from-1872-to-2017

## Key Features
Get match results by
- inputing home team and away team
- [date when matches were played (yyyy-mm-dd) ]
- [competition where matches were played]
- [city and country where matches were played]
- [city, country and competition where matches were played]

## Examples: 
1. by home team and away team:
```bash
https://localhost:7098/api/Match?homeTeam=Argentina&awayTeam=Albania
```
API Response:
<br>
<br>
<img width="257" alt="image" src="https://user-images.githubusercontent.com/45341025/207333657-e9063554-35b2-4d3d-8ea9-d5c739b6b852.png">

<br>
<br>
<br>

2. by date:
```bash
https://localhost:7098/api/Match/ByDate?date=2010-07-11
```
API Response:
<br>
<br>
<img width="280" alt="image" src="https://user-images.githubusercontent.com/45341025/207336447-a8f7cdc3-3fd5-4aa4-9dda-9d137691dd8b.png">

<br>
<br>
<br>

3. by competition and date:
```bash
https://localhost:7098/api/Match/ByCompetition?competition=Fifa%20World%20Cup&homeTeam=France&awayTeam=Croatia
```
API Response:
<br>
<br>
<img width="280" alt="image" src="https://user-images.githubusercontent.com/45341025/207338502-d1573aea-c0c2-4013-a3c4-ce90125319f6.png">


<br>
<br>
<br>

4. by city and country:
```bash
https://localhost:7098/api/Match/ByCityCountry?city=Mitrovica&country=Kosovo
```
API Response:
<br>
<br>
<img width="242" alt="image" src="https://user-images.githubusercontent.com/45341025/207341305-296dc8db-e678-421d-9f88-60ea404dd0ec.png">



<br>
<br>
<br>

5. by city, country and comepetition:
```bash
https://localhost:7098/api/Match/ByCityCountryCompedition?city=Doha&country=Qatar&compedition=Fifa%20World%20Cup
```
API Response:
<br>
<br>
<img width="303" alt="image" src="https://user-images.githubusercontent.com/45341025/207343257-8b26aea1-032c-47ad-8a37-3be081b90c91.png">




<br>
<br>
<br>







