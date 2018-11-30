use MergeViral
go

print '--------------------------------------'
print 'remove all foreign keys'
while(exists(select 1 from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where CONSTRAINT_TYPE='FOREIGN KEY'))
begin
	declare @sql nvarchar(2000)
	SELECT TOP 1 @sql=('ALTER TABLE ' + TABLE_SCHEMA + '.[' + TABLE_NAME
	+ '] DROP CONSTRAINT [' + CONSTRAINT_NAME + ']')
	FROM information_schema.table_constraints
	WHERE CONSTRAINT_TYPE = 'FOREIGN KEY'
	exec (@sql)
end
go

print '--------------------------------------'
print 'create table: Account'
if exists(select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = N'Account')
begin
	drop table dbo.Account
end
go
create table dbo.Account
(
	Id int identity(1000,1) not null primary key,
	FirstName nvarchar(50) not null,
	MiddleName nvarchar(50) null,
	LastName nvarchar(50) not null,
	Email nvarchar(50) not null,
	[Password] nvarchar(50) not null,
	Deleted bit null default 0,
	Created datetime not null,
	CreatedBy nvarchar(50) not null,
	LastUpdated datetime not null,
	LastUpdatedBy nvarchar(50) not null
)
go
insert into Account values('Gil', null, 'Sau', 'gilbert.sauceda@gmail.com', 'admin', 0, GETDATE(), 'system', GETDATE(), 'system');
go

print '--------------------------------------'
print 'create table: CampaignLocation'
if exists(select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = N'CampaignLocation')
begin
	drop table dbo.CampaignLocation
end
go
create table dbo.CampaignLocation
(
	Id int identity(1,1) not null primary key,
	[Name] nvarchar(50) not null
)
go
insert into CampaignLocation values('Merge Viral');
insert into CampaignLocation values('Your Own Site');
go

print '--------------------------------------'
print 'create table: CampaignType'
if exists(select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = N'CampaignType')
begin
	drop table dbo.CampaignType
end
go
create table dbo.CampaignType
(
	Id int identity(1,1) not null primary key,
	[Name] nvarchar(50) not null
)
go
insert into CampaignType values('Referral');
insert into CampaignType values('Contest');
go


print '--------------------------------------'
print 'create table: Campaign'
if exists(select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = N'Campaign')
begin
	drop table dbo.Campaign
end
go
create table dbo.Campaign
(
	Id int identity(1,1) not null primary key,
	AccountId int not null foreign key references Account(Id),
	[Name] nvarchar(150) not null,
	CampaignLocationId int not null foreign key references CampaignLocation(Id),
	CampaignTypeId int not null foreign key references CampaignType(Id),
	StartDate datetime null,
	EndDate datetime null,
	Deleted bit null default 0,
	Created datetime not null,
	CreatedBy nvarchar(50) not null,
	LastUpdated datetime not null,
	LastUpdatedBy nvarchar(50) not null
)
go
insert into campaign values(1000, 'camp 1', 1, 1, getdate(), dateadd(month, 1, getdate()), 0, getdate(), 'system', getdate(), 'system');
insert into campaign values(1000, 'camp 2', 1, 1, getdate(), dateadd(month, 1, getdate()), 0, getdate(), 'system', getdate(), 'system');
insert into campaign values(1000, 'camp 3', 1, 1, getdate(), dateadd(month, 1, getdate()), 0, getdate(), 'system', getdate(), 'system');
go

print '--------------------------------------'
print 'create table: Lead'
if exists(select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = N'Lead')
begin
	drop table dbo.Lead
end
go
create table dbo.Lead
(
	Id int identity(1,1) not null primary key,
	CampaignId int not null foreign key references Campaign(Id),
	ReferralLink nvarchar(250) null,
	RefererIP nvarchar(250) null,
	RefererBrowser nvarchar(250) null,
	[Name] nvarchar(50) null,
	Email nvarchar(50) not null,
	Deleted bit null default 0,
	Created datetime not null,
	CreatedBy nvarchar(50) not null,
	LastUpdated datetime not null,
	LastUpdatedBy nvarchar(50) not null
)
go

print '--------------------------------------'
print 'create table: View'
if exists(select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = N'View')
begin
	drop table dbo.[View]
end
go
create table dbo.[View]
(
	Id int identity(1,1) not null primary key,
	CampaignId int not null foreign key references Campaign(Id),
	ReferralLink nvarchar(250) null,
	RefererIP nvarchar(250) null,
	RefererBrowser nvarchar(250) null,
	Deleted bit null default 0,
	Created datetime not null,
	CreatedBy nvarchar(50) not null,
	LastUpdated datetime not null,
	LastUpdatedBy nvarchar(50) not null
)
go

print '--------------------------------------'
print 'create table: RewardType'
if exists(select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = N'RewardType')
begin
	drop table dbo.RewardType
end
go
create table dbo.RewardType
(
	Id int identity(1,1) not null primary key,
	[Name] nvarchar(50) not null
)
go
insert into RewardType values('Url');
insert into RewardType values('Downloadable');
insert into RewardType values('Coupon Code');
go

print '--------------------------------------'
print 'create table: Reward'
if exists(select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = N'Reward')
begin
	drop table dbo.Reward
end
go
create table dbo.Reward
(
	Id int identity(1,1) not null primary key,
	CampaignId int not null foreign key references Campaign(Id),
	RewardTypeId int not null foreign key references RewardType(Id),
	[Name] nvarchar(50) not null,
	PointsMinimum int not null,
	PointsDirectSignUp int null,
	PointsReferredSignUp int null,
	PointsReferredLead int null,
	PointsFacebook int null,
	PointsTwitter int null,
	PointsGoogle int null,
	PointsLinkedIn int null,
	Deleted bit null default 0,
	Created datetime not null,
	CreatedBy nvarchar(50) not null,
	LastUpdated datetime not null,
	LastUpdatedBy nvarchar(50) not null
)
go

print '--------------------------------------'
print 'create table: Template'
if exists(select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = N'Template')
begin
	drop table dbo.Template
end
go
create table dbo.Template
(
	Id int identity(1,1) not null primary key,
	BackgroundImg nvarchar(50) null,
	BackgroundColor nvarchar(20) null,
	TitleText nvarchar(250) null,
	TitleFontFamily nvarchar(20) null,
	TitleFontSize int null,
	TitleBackgroundColor nvarchar(20) null,
	BtnText nvarchar(20) null,
	BtnFontFamily nvarchar(20) null,
	BtnFontSize int null,
	BtnBackgroundColor nvarchar(20) null,
	Deleted bit null default 0,
	Created datetime not null,
	CreatedBy nvarchar(50) not null,
	LastUpdated datetime not null,
	LastUpdatedBy nvarchar(50) not null
)
go

print '--------------------------------------'
print 'create table: LandingPage'
if exists(select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = N'LandingPage')
begin
	drop table dbo.LandingPage
end
go
create table dbo.LandingPage
(
	Id int identity(1,1) not null primary key,
	CampaignId int not null foreign key references Campaign(Id),
	TemplateId int not null foreign key references Template(Id),
	ReferralLink nvarchar(250) null,
	Deleted bit null default 0,
	Created datetime not null,
	CreatedBy nvarchar(50) not null,
	LastUpdated datetime not null,
	LastUpdatedBy nvarchar(50) not null
)
go

print '--------------------------------------'
print 'create table: SocialPostType'
if exists(select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = N'SocialPostType')
begin
	drop table dbo.SocialPostType
end
go
create table dbo.SocialPostType
(
	Id int identity(1,1) not null primary key,
	[Name] nvarchar(50) not null
)
go
insert into SocialPostType values('Facebook');
insert into SocialPostType values('Twitter');
insert into SocialPostType values('Google');
insert into SocialPostType values('LinkedIn');
insert into SocialPostType values('Email');
go

print '--------------------------------------'
print 'create table: SocialPost'
if exists(select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = N'SocialPost')
begin
	drop table dbo.SocialPost
end
go
create table dbo.SocialPost
(
	Id int identity(1,1) not null primary key,
	CampaignId int not null foreign key references Campaign(Id),
	SocialPostTypeId int not null foreign key references SocialPostType(Id),
	HandleName nvarchar(50) null,
	StandardTweet nvarchar(150) null,
	EmailSubject nvarchar(150) null,
	Title nvarchar(150) null,
	[Description] nvarchar(250) null,
	Img nvarchar(150) null,
	ReferralLink nvarchar(250) null,
	Deleted bit null default 0,
	Created datetime not null,
	CreatedBy nvarchar(50) not null,
	LastUpdated datetime not null,
	LastUpdatedBy nvarchar(50) not null
)
go

print '--------------------------------------'
print 'create table: EmailNotification'
if exists(select 1 from INFORMATION_SCHEMA.TABLES where TABLE_NAME = N'EmailNotification')
begin
	drop table dbo.EmailNotification
end
go
create table dbo.EmailNotification
(
	Id int identity(1,1) not null primary key,
	CampaignId int not null foreign key references Campaign(Id),
	SendAfterRegistration bit null default 0,
	SendWhenSignsUp bit null default 0,
	SendWhenRewardUnlocked bit null default 0,
	FromName nvarchar(50) null,
	FromEmail nvarchar(150) null,
	ServerHost nvarchar(50) null,
	ServerPort int null,
	[Password] nvarchar(20) null,
	EncryptionType nvarchar(10) null,
	Deleted bit null default 0,
	Created datetime not null,
	CreatedBy nvarchar(50) not null,
	LastUpdated datetime not null,
	LastUpdatedBy nvarchar(50) not null
)
go

