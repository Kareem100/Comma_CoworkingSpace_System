CREATE PROCEDURE addlinks @fa varchar(100), @tw varchar(100), @ins varchar(100), @ask varchar(100)
AS
insert into social_links (facebook,twitter,instagram,askfm) values(@fa,@tw,@ins,@ask);