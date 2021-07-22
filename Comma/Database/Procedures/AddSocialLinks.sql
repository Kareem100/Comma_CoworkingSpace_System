CREATE PROCEDURE addSocialLinks @fa varchar(100), @tw varchar(100), @ins varchar(100), @ask varchar(100)
AS
DELETE FROM SocialLinks;
INSERT INTO SocialLinks VALUES (@fa, @tw, @ins, @ask);