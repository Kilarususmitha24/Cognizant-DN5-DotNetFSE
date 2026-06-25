BEGIN TRY

    RAISERROR
    (
        'Employee Record Not Found',
        16,
        1
    );

END TRY

BEGIN CATCH

    PRINT ERROR_MESSAGE();

END CATCH;