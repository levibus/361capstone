CREATE TRIGGER CreateCartForNewUser
ON Customer
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Cart (customerId)
    SELECT inserted.customerId
    FROM inserted;
END;