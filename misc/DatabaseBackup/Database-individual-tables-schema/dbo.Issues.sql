CREATE TABLE [dbo].[Issues] (
    [IssueId]        INT            IDENTITY (1, 1) NOT NULL,
    [Summary]        NVARCHAR (MAX) NOT NULL,
    [Status]         NVARCHAR (MAX) NOT NULL,
    [Priority]       NVARCHAR (MAX) NOT NULL,
    [AssignedTo]     NVARCHAR (MAX) NOT NULL,
    [System]         NVARCHAR (MAX) NOT NULL,
    [ModifiedBy]     NVARCHAR (MAX) NOT NULL,
    [ModifiedAt]     NVARCHAR (MAX) NOT NULL,
    [ModifiedByUser] NVARCHAR (MAX) NOT NULL,
    [SubmittedBy]    NVARCHAR (MAX) NOT NULL,
    [SubmittedAt]    NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Issues] PRIMARY KEY CLUSTERED ([IssueId] ASC)
);

