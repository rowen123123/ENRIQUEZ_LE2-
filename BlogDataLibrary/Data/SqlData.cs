﻿using BlogDataLibrary.Database;

public class SqlData
{
    private  ISqlDataAccess _db;
    private const string connectionStringName = "SqlDb";

    public SqlData(ISqlDataAccess db)
    {
        _db = db;
    }

}

