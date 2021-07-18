CREATE PROCEDURE insertinfofeedback @sattisfied nvarchar(10), @service nvarchar(10), 
									@problem nvarchar(10), @feedbacktype nvarchar(10), @tex nvarchar(100), @custID int
  AS
  INSERT INTO Feedbacks (customerIsSatisfied,customerHadGoodService,customerHadProblems,feedbackType,feedbackContent,customerID)
  VALUES (@sattisfied,@service,@problem,@feedbacktype,@tex,@custID);