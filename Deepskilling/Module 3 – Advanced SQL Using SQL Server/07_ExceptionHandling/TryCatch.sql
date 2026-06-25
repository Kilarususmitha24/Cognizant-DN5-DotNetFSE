BEGIN TRY

    DECLARE @Number1 INT = 100;
    DECLARE @Number2 INT = 0;

    SELECT @Number1 / @Number2;

END TRY

BEGIN CATCH

    PRINT 'Error Occurred';
    PRINT ERROR_MESSAGE();

END CATCH;