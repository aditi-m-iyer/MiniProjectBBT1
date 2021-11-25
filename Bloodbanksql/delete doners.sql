GO
CREATE PROCEDURE DeleteDonars(
@DONAR_ID  int)
AS
begin
BEGIN TRY
	if @DONAR_ID  in(select DONAR_ID FROM DONARS)
	BEGIN 
	delete from DONARS  where DONAR_ID=@DONAR_ID 
	return 1
	END
	begin 
	return -1
	end 
	
END TRY

	BEGIN CATCH
	RETURN 99
	END CATCH
	end


select * from donars


select * from donars
