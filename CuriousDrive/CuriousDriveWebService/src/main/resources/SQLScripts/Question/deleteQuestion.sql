SET @QUESTION_ID = ?;

-- delete all answer comments 
DELETE TC FROM TRAN_COMMENT TC 
INNER JOIN TRAN_QUESTION_ANSWER TQA ON TQA.QUESTION_ANSWER_ID = TC.SUBSYSTEM_REFERENCE_ID AND TC.SUBSYSTEM_VALUE = 'ANSR'
INNER JOIN TRAN_QUESTION TQ ON TQ.QUESTION_ID = TQA.QUESTION_ID
WHERE TQ.QUESTION_ID = @QUESTION_ID;

-- delete all answers
DELETE TQA FROM TRAN_QUESTION_ANSWER TQA
INNER JOIN TRAN_QUESTION TQ ON TQ.QUESTION_ID = TQA.QUESTION_ID
WHERE TQ.QUESTION_ID = @QUESTION_ID;

-- delete all question comments
DELETE TC FROM TRAN_COMMENT TC 
INNER JOIN TRAN_QUESTION TQ ON TQ.QUESTION_ID = TC.SUBSYSTEM_REFERENCE_ID AND TC.SUBSYSTEM_VALUE = 'QUES'
WHERE TQ.QUESTION_ID = @QUESTION_ID;

-- delete all question classes
DELETE TQC FROM TRAN_QUESTION_CLASS TQC 
INNER JOIN TRAN_QUESTION TQ ON TQ.QUESTION_ID = TQC.QUESTION_ID
WHERE TQ.QUESTION_ID = @QUESTION_ID;

-- delete all question views
DELETE TQV FROM TRAN_QUESTION_VIEW TQV 
INNER JOIN TRAN_QUESTION TQ ON TQ.QUESTION_ID = TQV.QUESTION_ID
WHERE TQ.QUESTION_ID = @QUESTION_ID;

-- delete all post votes
DELETE TPV FROM TRAN_POST_VOTE TPV 
INNER JOIN TRAN_QUESTION TQ ON TQ.QUESTION_ID = TPV.QUESTION_ID
WHERE TPV.QUESTION_ID = @QUESTION_ID;

-- delete all notifications
-- DELETE TN FROM TRAN_NOTIFICATIONS TN 
-- INNER JOIN TRAN_QUESTION TQ ON TQ.QUESTION_ID = TN.QUESTION_ID
-- WHERE TN.QUESTION_ID = @QUESTION_ID;

-- and finally delete the question 
DELETE TQ.* FROM TRAN_QUESTION TQ WHERE TQ.QUESTION_ID = @QUESTION_ID;