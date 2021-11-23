create proc usp_insertbloodbankdoner
(
@DONAR_ID INT,
@FIRST_NAME VARCHAR(50), 
@LAST_NAME VARCHAR(50), 
@EMAIL VARCHAR(150), 
@CONTACT VARCHAR(50),
@GENDER VARCHAR(20), 
@BLOODGRP VARCHAR(50),
@ADDRESS VARCHAR(250),
@AGE INT)

   AS
	begin try
		IF @DONAR_ID IS NOT NULL 
			BEGIN 
			IF LEN(@CONTACT)=10
				BEGIN
				if @BLOODGRP in('A+','A-','B+','B-','O+','O-')
				begin
				IF @GENDER in ('Male','Female','Others')
					BEGIN
					insert into DONARS(DONAR_ID,FIRST_NAME, LAST_NAME, EMAIL, CONTACT,GENDER , BLOODGRP ,ADDRESS, AGE)
					values (@DONAR_ID,@FIRST_NAME , @LAST_NAME, @EMAIL, @CONTACT,@GENDER , @BLOODGRP ,@ADDRESS, @AGE)
					END
				ELSE
				BEGIN
				RETURN -1
				END
				END
				ELSE
				BEGIN
				RETURN -99
				END
				END
				
			else
			begin
			return -2
			end
			end

			else
			begin
			return -3
			end

		END TRY

			BEGIN CATCH
			RETURN 99
			END CATCH
			
			select * from donars