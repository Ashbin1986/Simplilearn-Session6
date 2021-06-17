using DataAccessLayer.Constants;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DBHelper
{
    public class DBHelperLayer
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        internal void AddEvent(EventsEntity eventsEntity)
        {
            throw new NotImplementedException();
        }

        public DBHelperLayer()
        {
            sqlConnection = new SqlConnection(DBConstants.ConnectionString);
        }

        internal void DeleteEvent(int eventId)
        {
            try
            {
                sqlCommand = new SqlCommand("dbo.DeleteEvent", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@eventId", eventId);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public DataSet GetEvents()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("GetEvents", sqlConnection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "EventsData");
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void AddStudent(StudentEntity studentEntity)
        {
            try
            {
                sqlCommand = new SqlCommand("dbo.AddStudent", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@StudentName", studentEntity.StudentName);
                sqlCommand.Parameters.AddWithValue("@Gender", studentEntity.Gender);
                sqlCommand.Parameters.AddWithValue("@IsActive", studentEntity.IsActive);
                sqlCommand.Parameters.AddWithValue("@Email", studentEntity.Email);
                sqlCommand.Parameters.AddWithValue("@EventId", studentEntity.EventId);

                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                // SQL Command  -- ExecuteNonQuery- DML
                // SQL Command  -- ExecuteReader- Fetching data from DB
                // SQL Command -- ExecuteScalar -- get only first rows/first column value

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public DataSet GetEventParticipants()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("GetEventParticipants", sqlConnection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet , "ParticipantsData");return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

    }
}
