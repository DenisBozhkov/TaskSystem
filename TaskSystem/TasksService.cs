﻿using System.Data.SqlClient;
using TaskSystem.Models;

namespace TaskSystem
{
    public static class TasksService
    {
        public static bool OrderByPriority { get; set; } = false;
        public static DateTime? StartAfter { get; set; } = null;
        public static DateTime? EndBefore { get; set; } = null;
        public static List<TaskModel> TodayTasks
        {
            get
            {
                List<TaskModel> tasks = [];
                SqlConnection conn = new(GlobalService.DbConnectionString);
                conn.Open();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT * FROM Tasks WHERE CreatedBy=@CreatedBy AND Deadline=@Deadline ORDER BY Priority DESC";
                comm.Parameters.AddWithValue("@CreatedBy", GlobalService.LoggedInProfile?.UserName);
                comm.Parameters.AddWithValue("@DeadLine", DateTime.Now.Date);
                var reader = comm.ExecuteReader();
                while (reader.Read())
                    tasks.Add(new()
                    {
                        Id = (int)reader["Id"],
                        Title = (string)reader["Title"],
                        Description = (string)reader["Description"],
                        Deadline = (DateTime)reader["Deadline"],
                        Priority = (Priority)reader["Priority"],
                        IsDone = (bool)reader["IsDone"],
                        CreatedBy = (string)reader["CreatedBy"]
                    });
                conn.Close();
                return tasks;
            }
        }
        public static List<TaskModel> Tasks
        {
            get
            {
                List<TaskModel> tasks = [];
                SqlConnection conn = new(GlobalService.DbConnectionString);
                conn.Open();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT * FROM Tasks";
                if (StartAfter != null || EndBefore != null)
                    comm.CommandText += " WHERE";
                if (StartAfter != null)
                {
                    comm.CommandText += " Deadline>=@StartAfter";
                    comm.Parameters.AddWithValue("@StartAfter", StartAfter.Value);
                }
                if (EndBefore != null)
                {
                    if (StartAfter != null)
                        comm.CommandText += " AND";
                    comm.CommandText += " Deadline<=@EndBefore";
                    comm.Parameters.AddWithValue("@EndBefore", EndBefore.Value);
                }
                if (OrderByPriority)
                    comm.CommandText += " ORDER BY Priority DESC";
                var reader = comm.ExecuteReader();
                while (reader.Read())
                    tasks.Add(new()
                    {
                        Id = (int)reader["Id"],
                        Title = (string)reader["Title"],
                        Description = (string)reader["Description"],
                        Deadline = (DateTime)reader["Deadline"],
                        Priority = (Priority)reader["Priority"],
                        IsDone = (bool)reader["IsDone"],
                        CreatedBy = (string)reader["CreatedBy"]
                    });
                conn.Close();
                return tasks;
            }
        }
    }
}