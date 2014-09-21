
CREATE PROCEDURE [dbo].[DeleteSystemEmailType]
    @SystemEmailTypeID int

AS
Begin
 Delete [Conference].[SystemEmailType] where     [SystemEmailTypeID] = @SystemEmailTypeID
End
