BEGIN TRY

    BEGIN TRY

        DECLARE @A INT = 10;
        DECLARE @B INT = 0;

        SELECT @A / @B;

    END TRY

    BEGIN CATCH

        PRINT 'Inner Catch Block';
        PRINT ERROR_MESSAGE();

    END CATCH

END TRY

BEGIN CATCH

    PRINT 'Outer Catch Block';

END CATCH;