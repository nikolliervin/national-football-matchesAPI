## About the API
This api gets you the results of all national football matches played from 1872 to 2022. 
The api is built under this dataset: https://www.kaggle.com/datasets/martj42/international-football-results-from-1872-to-2017

## Key Features
Get match results by
- [inputing home team and away team]
- [date when matches were played]
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

1. by date:
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






