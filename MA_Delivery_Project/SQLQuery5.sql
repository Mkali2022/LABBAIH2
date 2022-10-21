USE [LabehMA]
GO
/****** Object:  StoredProcedure [dbo].[H ]    Script Date: 10/21/2022 5:29:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [LabehDB].[OrganizationTab]
(
@ID int,
@OrganizeCode int,
@OrganizeName nvarchar(max)
 

)
as 
begin
  
insert into OrganizationTab (OrganizeCode,OrganizeName  ) values(  @OrganizeCode,@OrganizeName  )
end

--begin 
--update History set History_Code=@History_Code , History_License_Exp=@History_License_Exp , History_Vehicle_Mot=@History_Vehicle_Mot , History_Reservation=@History_Reservation , History_No_Of_Local_Accid=@History_No_Of_Local_Accid , History_Engine_Change=@History_Engine_Change , History_Type_Of_Use=@History_Type_Of_Use , History_Last_Meter_Reading=@History_Last_Meter_Reading , History_Vehicle_Title=@History_Vehicle_Title , History_Accidents=@History_Accidents , History_Airbag=@History_Airbag , History_Type_Of_Use_Out=@History_Type_Of_Use_Out , History_Standard_Seating=@History_Standard_Seating , History_Made_In=@History_Made_In , History_Registration_Type=@History_Registration_Type , History_Ownership_Transfer_Fee=@History_Ownership_Transfer_Fee , History_Height=@History_Height , History_Weight=@History_Weight , History_Engine=@History_Engine , History_Break_System=@History_Break_System , History_Fuel_Capacity=@History_Fuel_Capacity , History_Category=@History_Category , History_Highway_Milleage=@History_Highway_Milleage , History_Owners_No=@History_Owners_No , History_Reg_Type_Change=@History_Reg_Type_Change , History_Usage_Change=@History_Usage_Change , History_With_Apps=@History_With_Apps , History_JOR_OwnerShip=@History_JOR_OwnerShip  where ID=@ID
--end 

--begin 
--delete from History where ID=@ID
--end
