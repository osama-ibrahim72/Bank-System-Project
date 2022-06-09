/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/30/2022 10:11:59 PM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Account') and o.name = 'FK_ACCOUNT_HAVE_CUSTOMER')
alter table Account
   drop constraint FK_ACCOUNT_HAVE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Branche') and o.name = 'FK_BRANCHE_HAS_BANK')
alter table Branche
   drop constraint FK_BRANCHE_HAS_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Customers') and o.name = 'FK_CUSTOMER_HAVE CUST_BRANCHE')
alter table Customers
   drop constraint "FK_CUSTOMER_HAVE CUST_BRANCHE"
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Employee') and o.name = 'FK_EMPLOYEE_WORK IN_BRANCHE')
alter table Employee
   drop constraint "FK_EMPLOYEE_WORK IN_BRANCHE"
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Loan') and o.name = 'FK_LOAN_KIND OF_LOANOFFE')
alter table Loan
   drop constraint "FK_LOAN_KIND OF_LOANOFFE"
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Loan') and o.name = 'FK_LOAN_TAKE_CUSTOMER')
alter table Loan
   drop constraint FK_LOAN_TAKE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Loan') and o.name = 'FK_LOAN_CONNECT_ACCOUNT')
alter table Loan
   drop constraint FK_LOAN_CONNECT_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Loan') and o.name = 'FK_LOAN_STATUS_EMPLOYEE')
alter table Loan
   drop constraint FK_LOAN_STATUS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LoanOffer') and o.name = 'FK_LOANOFFE_OFFERS_BRANCHE')
alter table LoanOffer
   drop constraint FK_LOANOFFE_OFFERS_BRANCHE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Account')
            and   name  = 'HAVE_FK'
            and   indid > 0
            and   indid < 255)
   drop index Account.HAVE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Account')
            and   type = 'U')
   drop table Account
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Bank')
            and   type = 'U')
   drop table Bank
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Branche')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Branche.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Branche')
            and   type = 'U')
   drop table Branche
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Customers')
            and   name  = 'HAVE_CUSTOMERS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Customers.HAVE_CUSTOMERS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Customers')
            and   type = 'U')
   drop table Customers
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Employee')
            and   name  = 'WORK_IN_FK'
            and   indid > 0
            and   indid < 255)
   drop index Employee.WORK_IN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Employee')
            and   type = 'U')
   drop table Employee
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Loan')
            and   name  = 'CONNECT_FK'
            and   indid > 0
            and   indid < 255)
   drop index Loan.CONNECT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Loan')
            and   name  = 'STATUS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Loan.STATUS_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Loan')
            and   name  = 'KIND_OF_FK'
            and   indid > 0
            and   indid < 255)
   drop index Loan.KIND_OF_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Loan')
            and   name  = 'TAKE_FK'
            and   indid > 0
            and   indid < 255)
   drop index Loan.TAKE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Loan')
            and   type = 'U')
   drop table Loan
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LoanOffer')
            and   name  = 'OFFERS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LoanOffer.OFFERS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LoanOffer')
            and   type = 'U')
   drop table LoanOffer
go

/*==============================================================*/
/* Table: Account                                               */
/*==============================================================*/
create table Account (
   ANUM                 bigint               not null,
   SSN                  bigint               not null,
   Balance              bigint               not null,
   AType                varchar(256)         not null,
   constraint PK_ACCOUNT primary key (ANUM)
)
go

/*==============================================================*/
/* Index: HAVE_FK                                               */
/*==============================================================*/




create nonclustered index HAVE_FK on Account (SSN ASC)
go

/*==============================================================*/
/* Table: Bank                                                  */
/*==============================================================*/
create table Bank (
   Code                 bigint               not null,
   Name                 varchar(256)         not null,
   State                varchar(256)         not null,
   Country              varchar(256)         not null,
   constraint PK_BANK primary key (Code)
)
go

/*==============================================================*/
/* Table: Branche                                               */
/*==============================================================*/
create table Branche (
   BNUM                 bigint               not null,
   Code                 bigint               not null,
   City                 varchar(256)         not null,
   Street               varchar(256)         not null,
   "No."                int                  not null,
   constraint PK_BRANCHE primary key (BNUM)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/




create nonclustered index HAS_FK on Branche (Code ASC)
go

/*==============================================================*/
/* Table: Customers                                             */
/*==============================================================*/
create table Customers (
   SSN                  bigint               not null,
   BNUM                 bigint               not null,
   Name                 varchar(256)         not null,
   Phone                char(11)             not null,
   City                 varchar(256)         not null,
   Street               varchar(256)         not null,
   State                varchar(256)         not null,
   No                   int                  not null,
   constraint PK_CUSTOMERS primary key (SSN)
)
go

/*==============================================================*/
/* Index: HAVE_CUSTOMERS_FK                                     */
/*==============================================================*/




create nonclustered index HAVE_CUSTOMERS_FK on Customers (BNUM ASC)
go

/*==============================================================*/
/* Table: Employee                                              */
/*==============================================================*/
create table Employee (
   EID                  bigint               not null,
   BNUM                 bigint               not null,
   Name                 varchar(256)         not null,
   constraint PK_EMPLOYEE primary key (EID)
)
go

/*==============================================================*/
/* Index: WORK_IN_FK                                            */
/*==============================================================*/




create nonclustered index WORK_IN_FK on Employee (BNUM ASC)
go

/*==============================================================*/
/* Table: Loan                                                  */
/*==============================================================*/
create table Loan (
   LNUM                 bigint               not null,
   SSN                  bigint               not null,
   Type                 varchar(256)         not null,
   EID                  bigint               not null,
   ANUM                 bigint               not null,
   Amount               bigint               not null,
   request              bit                  null,
   constraint PK_LOAN primary key (LNUM)
)
go

/*==============================================================*/
/* Index: TAKE_FK                                               */
/*==============================================================*/




create nonclustered index TAKE_FK on Loan (SSN ASC)
go

/*==============================================================*/
/* Index: KIND_OF_FK                                            */
/*==============================================================*/




create nonclustered index KIND_OF_FK on Loan (Type ASC)
go

/*==============================================================*/
/* Index: STATUS_FK                                             */
/*==============================================================*/




create nonclustered index STATUS_FK on Loan (EID ASC)
go

/*==============================================================*/
/* Index: CONNECT_FK                                            */
/*==============================================================*/




create nonclustered index CONNECT_FK on Loan (ANUM ASC)
go

/*==============================================================*/
/* Table: LoanOffer                                             */
/*==============================================================*/
create table LoanOffer (
   Type                 varchar(256)         not null,
   BNUM                 bigint               not null,
   Description          varchar(4048)        not null,
   constraint PK_LOANOFFER primary key (Type)
)
go

/*==============================================================*/
/* Index: OFFERS_FK                                             */
/*==============================================================*/




create nonclustered index OFFERS_FK on LoanOffer (BNUM ASC)
go

alter table Account
   add constraint FK_ACCOUNT_HAVE_CUSTOMER foreign key (SSN)
      references Customers (SSN)
go

alter table Branche
   add constraint FK_BRANCHE_HAS_BANK foreign key (Code)
      references Bank (Code)
go

alter table Customers
   add constraint "FK_CUSTOMER_HAVE CUST_BRANCHE" foreign key (BNUM)
      references Branche (BNUM)
go

alter table Employee
   add constraint "FK_EMPLOYEE_WORK IN_BRANCHE" foreign key (BNUM)
      references Branche (BNUM)
go

alter table Loan
   add constraint "FK_LOAN_KIND OF_LOANOFFE" foreign key (Type)
      references LoanOffer (Type)
go

alter table Loan
   add constraint FK_LOAN_TAKE_CUSTOMER foreign key (SSN)
      references Customers (SSN)
go

alter table Loan
   add constraint FK_LOAN_CONNECT_ACCOUNT foreign key (ANUM)
      references Account (ANUM)
go

alter table Loan
   add constraint FK_LOAN_STATUS_EMPLOYEE foreign key (EID)
      references Employee (EID)
go

alter table LoanOffer
   add constraint FK_LOANOFFE_OFFERS_BRANCHE foreign key (BNUM)
      references Branche (BNUM)
go

