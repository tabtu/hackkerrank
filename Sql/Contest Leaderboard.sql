/*
https://www.hackerrank.com/challenges/contest-leaderboard

MySql

Enter your query here.
*/

SELECT X.hacker_id, 
(SELECT H.NAME FROM HACKERS H WHERE H.HACKER_ID = X.HACKER_ID) NAME, 
SUM(X.SCORE) TOTAL_SCORE FROM (SELECT HACKER_ID, MAX(SCORE) SCORE 
  FROM SUBMISSIONS S 
  GROUP BY 1, S.CHALLENGE_ID) X 
GROUP BY 1
HAVING TOTAL_SCORE > 0
ORDER BY TOTAL_SCORE DESC, HACKER_ID;