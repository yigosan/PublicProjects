INSERT  INTO `SYS_CODE` 
SELECT 16,'Group Status',null,null,null,null,null,null,'Group Status',1,now(),1,now(),0 FROM DUAL 
WHERE NOT EXISTS (SELECT 1 FROM SYS_CODE WHERE CODE_ID = 16 AND CODE_DESCRIPTION = 'Group Status');

INSERT  INTO `SYS_CODE_VALUE`
(`CODE_ID`,`CODE_VALUE`,`DESCRIPTION`,`DATA1`,`DATA2`,`DATA3`,`COMMENTS`,`CREATED_BY`,`CREATED_DATE`,`MODIFIED_BY`,`MODIFIED_DATE`,`UPDATE_SEQ`)
SELECT 16,'ACTV','Active',null,null,null,'',1,NOW(),1,NOW(),0 FROM DUAL 
WHERE NOT EXISTS (SELECT 1 FROM SYS_CODE_VALUE WHERE CODE_ID = 16 AND CODE_VALUE = 'ACTV');

INSERT  INTO `SYS_CODE_VALUE`
(`CODE_ID`,`CODE_VALUE`,`DESCRIPTION`,`DATA1`,`DATA2`,`DATA3`,`COMMENTS`,`CREATED_BY`,`CREATED_DATE`,`MODIFIED_BY`,`MODIFIED_DATE`,`UPDATE_SEQ`)
SELECT 16,'INAC','Inactive',null,null,null,'',1,NOW(),1,NOW(),0 FROM DUAL 
WHERE NOT EXISTS (SELECT 1 FROM SYS_CODE_VALUE WHERE CODE_ID = 16 AND CODE_VALUE = 'INAC');

INSERT  INTO `SYS_CODE` 
SELECT 17,'User Group Types',null,null,null,null,null,null,'User Group Types',1,now(),1,now(),0 FROM DUAL 
WHERE NOT EXISTS (SELECT 1 FROM SYS_CODE WHERE CODE_ID = 17 AND CODE_DESCRIPTION = 'User Group Types');

INSERT  INTO `SYS_CODE_VALUE`
(`CODE_ID`,`CODE_VALUE`,`DESCRIPTION`,`DATA1`,`DATA2`,`DATA3`,`COMMENTS`,`CREATED_BY`,`CREATED_DATE`,`MODIFIED_BY`,`MODIFIED_DATE`,`UPDATE_SEQ`)
SELECT 17,'INDV','Individual',null,null,null,'',1,NOW(),1,NOW(),0 FROM DUAL 
WHERE NOT EXISTS (SELECT 1 FROM SYS_CODE_VALUE WHERE CODE_ID = 17 AND CODE_VALUE = 'INDV');

INSERT  INTO `SYS_CODE_VALUE`
(`CODE_ID`,`CODE_VALUE`,`DESCRIPTION`,`DATA1`,`DATA2`,`DATA3`,`COMMENTS`,`CREATED_BY`,`CREATED_DATE`,`MODIFIED_BY`,`MODIFIED_DATE`,`UPDATE_SEQ`)
SELECT 17,'YEAR','Year',null,null,null,'',1,NOW(),1,NOW(),0 FROM DUAL 
WHERE NOT EXISTS (SELECT 1 FROM SYS_CODE_VALUE WHERE CODE_ID = 17 AND CODE_VALUE = 'YEAR');

INSERT  INTO `SYS_CODE_VALUE`
(`CODE_ID`,`CODE_VALUE`,`DESCRIPTION`,`DATA1`,`DATA2`,`DATA3`,`COMMENTS`,`CREATED_BY`,`CREATED_DATE`,`MODIFIED_BY`,`MODIFIED_DATE`,`UPDATE_SEQ`)
SELECT 17,'USGP','User Group',null,null,null,'',1,NOW(),1,NOW(),0 FROM DUAL 
WHERE NOT EXISTS (SELECT 1 FROM SYS_CODE_VALUE WHERE CODE_ID = 17 AND CODE_VALUE = 'USGP');

INSERT  INTO `SYS_CODE_VALUE`
(`CODE_ID`,`CODE_VALUE`,`DESCRIPTION`,`DATA1`,`DATA2`,`DATA3`,`COMMENTS`,`CREATED_BY`,`CREATED_DATE`,`MODIFIED_BY`,`MODIFIED_DATE`,`UPDATE_SEQ`)
SELECT 10,'ANNC','Post Type Announcement',null,null,null,'',1,NOW(),1,NOW(),0 FROM DUAL 
WHERE NOT EXISTS (SELECT 1 FROM SYS_CODE_VALUE WHERE CODE_ID = 10 AND CODE_VALUE = 'ANNC');

INSERT INTO `SYS_CODE_VALUE`
(`CODE_ID`,`CODE_VALUE`,`DESCRIPTION`,`DATA1`,`DATA2`,`DATA3`,`COMMENTS`,`CREATED_BY`,`CREATED_DATE`,`MODIFIED_BY`,`MODIFIED_DATE`,`UPDATE_SEQ`)
SELECT 11,'MNQU','Action Type - Mentioned In Question',null,null,null,'',1,NOW(),1,NOW(),0 FROM DUAL 
WHERE NOT EXISTS (SELECT 1 FROM SYS_CODE_VALUE WHERE CODE_ID = 11 AND CODE_VALUE = 'MNQU');

INSERT INTO `SYS_CODE_VALUE`
(`CODE_ID`,`CODE_VALUE`,`DESCRIPTION`,`DATA1`,`DATA2`,`DATA3`,`COMMENTS`,`CREATED_BY`,`CREATED_DATE`,`MODIFIED_BY`,`MODIFIED_DATE`,`UPDATE_SEQ`)
SELECT 11,'MNAN','Action Type - Mentioned In Announcement',null,null,null,'',1,NOW(),1,NOW(),0 FROM DUAL 
WHERE NOT EXISTS (SELECT 1 FROM SYS_CODE_VALUE WHERE CODE_ID = 11 AND CODE_VALUE = 'MNAN');


ALTER TABLE tran_tag CHANGE COLUMN `USER_GROUP_ID` USER_GROUP_TYPE_ID INT(11);
ALTER TABLE tran_tag CHANGE COLUMN `USER_GROUP_VALUE` USER_GROUP_TYPE_VALUE varchar(50);
ALTER TABLE tran_tag DROP COLUMN `USER_GROUP_ID` ;
ALTER TABLE tran_tag CHANGE COLUMN `USER_GROUP_ID` USER_GROUP_VALUE varchar(50);

UPDATE curiosite.sys_code_value SET DATA1 = 'STUD' where CODE_ID = 15 AND CODE_VALUE IN ('FRSH','SPMR','JUNR','SENR','GNRL');
UPDATE curiosite.sys_code_value SET DATA1 = 'TCHR' where CODE_ID = 15 AND CODE_VALUE NOT IN ('FRSH','SPMR','JUNR','SENR','GNRL');
UPDATE curiosite.sys_code_value SET DATA1 = '' where CODE_ID = 15 AND CODE_VALUE IN ('GNRL');

