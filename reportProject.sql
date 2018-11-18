SELECT * FROM managertasks.reportproject;


CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY
 DEFINER VIEW `reportProject` AS select `p`.`projectId` AS `projectId`,`p`.`numHour` 
 AS `numHour`,`p`.`name` AS `name`,`p`.`dateBegin` AS `dateBegin`,`p`.`dateEnd` 
 AS `dateEnd`,`p`.`isFinish` AS `isFinish`,`p`.`customerName` 
 AS `customerName`,`p`.`managerId` AS `managerId`,`u`.`userName` 
 AS `userName`,(select count(0) from `projectworker` 
 where (`p`.`projectId` = `projectworker`.`projectId`) 
 group by `projectworker`.`projectId`) 
 AS `numWorker`,(select sum(`presentday`.`sumHours`) 
 AS `sumHourWork` from `presentday` 
 where (`presentday`.`projectId` = `p`.`projectId`) 
 group by `presentday`.`projectId`)
 AS `sumHourDo`,(to_days(`p`.`dateEnd`) - to_days(curdate())) 
 AS `numDaysStay`,(((select sum(`presentday`.`sumHours`) AS
 `sumHourWork` from `presentday` where (`presentday`.`projectId` = `p`.`projectId`) 
 group by `presentday`.`projectId`) / `p`.`numHour`) * 100) 
 AS `presentDoing`,(((`p`.`numHour` - (select sum(`presentday`.`sumHours`) 
 AS `sumHourWork` from `presentday` where (`presentday`.`projectId` = `p`.`projectId`) 
 group by `presentday`.`projectId`)) / (to_days(`p`.`dateEnd`) - to_days(curdate()))) / (select count(0) from `projectworker` where (`p`.`projectId` = `projectworker`.`projectId`) group by `projectworker`.`projectId`)) 
 AS `numHourDoDaysEveryWorker` from ((`presentday` `pd` left join (`projectworker` `pw` 
 left join `project` `p` on((`pw`.`projectId` = `p`.`projectId`))) 
 on((`pw`.`id` = `pd`.`id`))) join `user` `u` on((`u`.`id` = `p`.`managerId`))) 
 group by `p`.`projectId`;

select * from reportproject


SELECT * FROM   project p  JOIN projectworker pw ON  p.projectId =pw.projectId left JOIN user u ON pw.id =u.id WHERE pw.projectId=1

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `report`(IN viewName VARCHAR(40))
BEGIN
SET @sql =CONCAT("SELECT * FROM ",viewName);
 PREPARE stmt3 FROM @sql;
 EXECUTE stmt3;
 DEALLOCATE PREPARE stmt3;
END$$
DELIMITER ;



DELIMITER $$
select u.id,u.userName,u.departmentUserId,d.department,(select sum(sumHours) from presentday where id=u.id and projectId=1 group by u.id)
,(select pw.hoursForProject- sum(pd.sumHours) from presentday pd left join projectworker pw on pd.id=pw.id where pw.id=u.id and pw.projectId=1 group by u.id) 
from user u join department d on u.departmentUserId=d.id join projectworker pd on pd.id=u.id  where pd.projectId=1 



