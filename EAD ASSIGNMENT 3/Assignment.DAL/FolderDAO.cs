using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.DAL
{
    public static class FolderDAO
    {
        public static List<FolderDTO> getFolders(int uid,int pfid)
        {
            String query = "";
            List<FolderDTO> foldersList = new List<FolderDTO>();
            if(pfid==0)
            {
                query= String.Format("SELECT * FROM folders where id='{0}' and parentFolderId IS NULL", uid);
            }
            else
            {
                query=String.Format("SELECT * FROM folders where id='{0}' and parentFolderId='{1}'", uid,pfid);
            }
            using (ConnectionMySql connection = new ConnectionMySql())
            {
                var reader = connection.ExcueteReader(query);
                while(reader.Read())
                {
                    FolderDTO folder = new FolderDTO();
                    folder.folderId = reader.GetInt32(0);
                    folder.folderName = reader.GetString(1);
                    if(pfid==0)
                    {
                        folder.parentFolderId = 0;
                    }
                    else
                    {
                        folder.parentFolderId = reader.GetInt32(2);
                    }
                    folder.id = reader.GetInt32(3);
                    foldersList.Add(folder);
                }
                return foldersList;
            }

        }

        public static FolderDTO createFolder(String child, int uid, int parentFolder)
        {
            String query = "";
            String query1 = "";
            FolderDTO folder = new FolderDTO();
            if(parentFolder==0)
            {
                query = String.Format("SELECT * FROM folders where folderName='{0}' and parentFolderId is NULL", child);
            }
            else{
                query= String.Format("SELECT * FROM folders where folderName='{0}' and parentFolderId='{1}'", child,parentFolder);
            }
            using (ConnectionMySql connection = new ConnectionMySql())
            {
                var reader = connection.ExcueteReader(query);
                if(reader.Read())
                {
                    return null;
                }
                else
                {
                    if(parentFolder==0)
                    {
                        query1 = String.Format("INSERT INTO folders (folderName,id) VALUES ('{0}','{1}')", child, uid);
                    }
                    else{
                        query1 = String.Format("INSERT INTO folders (folderName,parentFolderId,id) VALUES ('{0}','{1}','{2}')", child,parentFolder,uid);
                    }

                    int retValue = connection.ExcueteQuery(query1);
                    if(retValue==1)
                    {
                        String sql= "SELECT * FROM folders ORDER BY folderId DESC LIMIT 1";
                        var reader1 = connection.ExcueteReader(sql);
                        if(reader.Read())
                        {
                            folder.folderId = reader1.GetInt32(0);
                            folder.folderName = reader1.GetString(1);
                            folder.parentFolderId = reader1.GetInt32(2);
                            folder.id = reader1.GetInt32(3);
                        }
                        return folder;
                    }
                  
                }
            }

            return null;
        }
    }
}
