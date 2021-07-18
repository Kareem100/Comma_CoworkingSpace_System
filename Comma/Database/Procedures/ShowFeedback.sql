CREATE PROCEDURE showfeedback
  AS
  select userID,userName,userMail,customerIsSatisfied,customerHadGoodService,customerHadProblems,feedbackType,feedbackContent
  from Users2, Feedbacks
  where userID=customerID;