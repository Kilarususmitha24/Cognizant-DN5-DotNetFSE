BEGIN TRY

    THROW 50001,
          'Custom Error Generated',
          1;

END TRY

BEGIN CATCH

    PRINT ERROR_MESSAGE();

END CATCH;