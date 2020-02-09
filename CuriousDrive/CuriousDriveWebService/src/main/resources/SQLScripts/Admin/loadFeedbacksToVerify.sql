SELECT TF.FEEDBACK_ID,TF.FEEDBACK,TF.USER_ID,TF.VALUE,TF.CREATED_BY,TF.CREATED_DATE,SU.DISPLAY_NAME,SU.FIRST_NAME,SU.LAST_NAME 
FROM TRAN_FEEDBACK TF 
LEFT JOIN SYS_USER SU ON SU.USER_ID = TF.USER_ID
WHERE IS_VERIFIED IS NULL
ORDER BY TF.CREATED_DATE
LIMIT 20;