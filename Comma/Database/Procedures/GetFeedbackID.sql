CREATE PROCEDURE getfeedbackID @ID int output
AS
select @ID = MAX(feedbackID)from Feedbacks;