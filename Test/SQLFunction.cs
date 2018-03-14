using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Test
{
    static class SQLFunction
    {
        public static string bd = "Data Source = DESKTOP-793AVME; Initial Catalog = test; Integrated Security = True";

        public static User getUserByLogPass(string login, string pass)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT ID_отдела, ID_должности, ID_сотрудника FROM Сотрудник WHERE [Логин] = '{0}' AND [Пароль] = '{1}' AND Признак='В фирме'", login, pass); //[1]
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            user = new User(res[0].ToString(), res[1].ToString(), res[1].ToString());
                        }
                    }
                }
                conn.Close();
            }
            return user;
        }


        public static bool addGroup(string name_group, int id_dept)  
        {
            bool result = true;
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT count(*) FROM Группа_техники WHERE UPPER([Название_группы]) = '{0}'", name_group.ToUpper());
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            int count = Int32.Parse(res[0].ToString());
                            res.Close();
                            if (count == 0)
                            {
                                com.CommandText = string.Format("SELECT count(*) FROM Группа_техники ");
                                using (SqlDataReader res1 = com.ExecuteReader())
                                {
                                    if (res1.Read())
                                    {
                                        int count1 = Int32.Parse(res1[0].ToString());
                                        res1.Close();

                                        com.CommandText = string.Format("INSERT INTO Группа_техники([ID_группы],[Название_группы],[ID_отдела]) VALUES('{0}','{1}','{2}')", count1 + 1, name_group, id_dept);
                                        com.ExecuteReader();
                                    }
                                }
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        else
                        {
                            res.Close();
                        }

                    }
                }
                connection.Close();
            }
            return result;
        }


        public static bool addSubgroup(string name_subgroup, int id_group)  
        {
            bool result = true;
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT count(*) FROM Подгруппа WHERE UPPER([Название_подгруппы]) = '{0}'", name_subgroup.ToUpper());
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            int count = Int32.Parse(res[0].ToString());
                            res.Close();
                            if (count == 0)
                            {
                                com.CommandText = string.Format("SELECT count(*) FROM Подгруппа");
                                using (SqlDataReader res1 = com.ExecuteReader())
                                {
                                    if (res1.Read())
                                    {
                                        int count1 = Int32.Parse(res1[0].ToString());
                                        res1.Close();

                                        com.CommandText = string.Format("INSERT INTO Подгруппа([ID_подгруппы],[Название_подгруппы],[ID_группы]) VALUES('{0}','{1}','{2}')", count1 + 1, name_subgroup, id_group);
                                        com.ExecuteReader();
                                    }
                                }
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        else
                        {
                            res.Close();
                        }

                    }
                }
                connection.Close();
            }
            return result;
        }


        

        public static bool addModel(string name_model, int id_subgroup, int id_factory, int id_empl)  
        {
            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(ID_модели) FROM Техника");
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            try
                            {
                                max = Int32.Parse(res[0].ToString());
                            }

                            catch { max = 0; }


                            res.Close();

                            try
                            {
                                com.CommandText = string.Format("INSERT INTO Техника([ID_модели],[Наименование_модели],[ID_подгруппы],[ID_завода],[ID_сотрудника]) VALUES('{0}','{1}','{2}','{3}','{4}')", max+1, name_model, id_subgroup, id_factory, id_empl);
                                com.ExecuteReader();
                            }
                            catch
                            {
                                conn.Close();
                                return false;
                            }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return true;
        }




        public static bool deleteModel(int id_model)  
        {
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {

                    try { 
                    com.CommandText = string.Format("DELETE FROM Техника WHERE ID_модели='{0}'", id_model );
                    com.ExecuteNonQuery();
                    }

                    catch { return false;
                    }
                }
                connection.Close();
                return true;
            }
        }

        public static bool deleteSubgroup(int id) 
        {
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {

                    try
                    {
                        com.CommandText = string.Format("DELETE FROM Подгруппа WHERE ID_подгруппы='{0}'", id);
                        com.ExecuteNonQuery();
                    }
                    catch { return false; }
                }
                connection.Close();
                return true;
            }
        }


        public static bool deleteGroup(int id)  
        {
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {

                    try
                    {
                        com.CommandText = string.Format("DELETE FROM Группа_техники WHERE ID_группы='{0}'", id);
                        com.ExecuteNonQuery();
                    }
                    catch { return false; }
                }
                connection.Close();
                return true;
            }
        }

        public static bool deleteDepartment(int id)  
        {
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {

                    try
                    {
                        com.CommandText = string.Format("DELETE FROM Отдел WHERE ID_отдела='{0}'", id);
                        com.ExecuteNonQuery();
                    }
                    catch { return false; }
                }
                connection.Close();
                return true;
            }
        }


        public static bool deleteContact(int id, int num)
        {
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {

                //    try
                 //   {
                        com.CommandText = string.Format("DELETE FROM Контакт WHERE ID_завода='{0}' AND Номер_по_порядку='{1}'", id, num);
                        com.ExecuteNonQuery();
                  //  }
                  //  catch { return false; }
                }
                connection.Close();
                return true;
            }
        }


        public static bool deletePost(int id)
        {
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {

                    try
                    {
                        com.CommandText = string.Format("DELETE FROM Должность WHERE ID_должности='{0}'", id);
                        com.ExecuteNonQuery();
                    }
                    catch { return false; }
                }
                connection.Close();
                return true;
            }
        }



        public static bool deleteCity(int id)
        {
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {

                    try
                    {
                        com.CommandText = string.Format("DELETE FROM Город WHERE ID_города='{0}'", id);
                        com.ExecuteNonQuery();
                    }
                    catch { return false; }
                }
                connection.Close();
                return true;
            }
        }

        public static bool deleteCharact(int id)
        {
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {

                    try
                    {
                        com.CommandText = string.Format("DELETE FROM Техническая_характеристика WHERE ID_характеристики='{0}'", id);
                        com.ExecuteNonQuery();
                    }
                    catch { return false; }
                }
                connection.Close();
                return true;
            }
        }

        public static bool deleteTechniquePriceList(DateTime data, int id_model)
        {
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {

                   try
                    {
                        com.CommandText = string.Format("DELETE FROM Прайс_лист WHERE Дата='{0}' AND ID_модели='{1}' ", data,id_model);
                        com.ExecuteNonQuery();
                    }
                    catch { return false; }
                }
                connection.Close();
                return true;
            }
        }


        public static bool addDepartment(string name)
        {

            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(ID_отдела) FROM Отдел");
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {                         
                            try
                            {
                                max = Int32.Parse(res[0].ToString());
                            }

                            catch { max = 0; }


                            res.Close();

                            try {
                            com.CommandText = string.Format("INSERT INTO Отдел([ID_отдела],[Название_отдела]) VALUES ('{0}','{1}');", max + 1,name );
                            com.ExecuteReader();
                            }                            
                             catch
                              {
                                conn.Close();
                                return false;
                             }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return true;
        }

        public static bool addPost(string name)
        {

            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(ID_должности) FROM Должность");
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            try
                            {
                                max = Int32.Parse(res[0].ToString());
                            }

                            catch { max = 0; }


                            res.Close();

                            try
                            {
                                com.CommandText = string.Format("INSERT INTO Должность([ID_должности],[Название_должности]) VALUES ('{0}','{1}');", max + 1, name);
                                com.ExecuteReader();
                            }
                            catch
                            {
                                conn.Close();
                                return false;
                            }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return true;
        }


        public static bool addContact(int id, string contact, string post, string number, string email )
        {

            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(Номер_по_порядку) FROM Контакт WHERE ID_завода='{0}'",id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            try
                            {
                                max = Int32.Parse(res[0].ToString());
                            }

                            catch { max = 0; }


                            res.Close();

                            try
                            {
                                com.CommandText = string.Format("INSERT INTO Контакт([ID_завода],[Номер_по_порядку], [Контактное_лицо],[Должность],[Номер_телефона],[Контактный_email]) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');", id, max+1, contact,post, number,email);
                                com.ExecuteReader();
                            }
                            catch
                            {
                                conn.Close();
                                return false;
                            }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return true;
        }


        public static bool addRequisite(int id,string name, string ras, string korr, string bik)
        {

            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {
                     try { 

                    com.CommandText = string.Format("INSERT INTO Банковские_реквизиты([ID_завода],[Наименование_банка],[Расчетный_счет],[Корреспондентский_счет],[БИК]) VALUES('{0}','{1}','{2}','{3}', '{4}')", id, name,ras,korr,bik);
                    com.ExecuteReader();
                      }
                    
                      catch
                         {
                       return false;
                          }


                }
                connection.Close();
            }


            return true;
        }



        public static bool addCharact(string name)
        {

            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(ID_характеристики) FROM Техническая_характеристика");
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            try
                            {
                                max = Int32.Parse(res[0].ToString());
                            }

                            catch { max = 0; }


                            res.Close();

                            try
                            {
                                com.CommandText = string.Format("INSERT INTO Техническая_характеристика([ID_характеристики],[Название_характеристики]) VALUES ('{0}','{1}');", max + 1, name);
                                com.ExecuteReader();
                            }
                            catch
                            {
                                conn.Close();
                                return false;
                            }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return true;
        }


        public static bool addTechniqueStore(int id_mode, DateTime data, int count, int price, int ost, string priznak)
        {

            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(ID_партии) FROM Склад");
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            try
                            {
                                max = Int32.Parse(res[0].ToString());
                            }

                            catch { max = 0; }


                            res.Close();

                        //    try
                         //   {
                                com.CommandText = string.Format("INSERT INTO Склад([ID_партии],[ID_модели],[Дата_поступления], [Количество], [Cтоимость], [Остаток_на_текущий_момент],[Признак_техники]) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", max + 1, id_mode, data, count, price, ost,priznak);
                                com.ExecuteReader();
                        //    }
                          //  catch
                          //  {
                           //     conn.Close();
                          //      return false;
                           // }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return true;
        }

        public static bool addTechniquePriceList( DateTime data,int id_model,int price, int crok)
        {

            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {
                     // try { 

                    com.CommandText = string.Format("INSERT INTO Прайс_лист([Дата],[ID_модели],[Cтоимость],[Cрок_поставки]) VALUES('{0}','{1}','{2}','{3}')", data, id_model,price, crok);
                    com.ExecuteReader();
                    //  }
//
                   //  catch
                    //     {
                    //   return false;
                    //      }


                }
                connection.Close();
            }


            return true;
        }


        public static bool deleteTechniqueStore(int id)
        {
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {

                    try
                    {
                        com.CommandText = string.Format("DELETE FROM Склад WHERE ID_партии='{0}'", id);
                        com.ExecuteNonQuery();
                    }
                    catch { return false; }
                }
                connection.Close();
                return true;
            }
        }


        public static bool deleteRequisite(int id,string name)
        {
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {

                    try
                    {
                        com.CommandText = string.Format("DELETE FROM Банковские_реквизиты WHERE ID_завода='{0}' AND Наименование_банка='{1}'", id, name);
                        com.ExecuteNonQuery();
                    }
                    catch { return false; }
                }
                connection.Close();
                return true;
            }
        }


        public static bool addEmployee(string fio, int id_dep, int id_Post, string login, string pass, string priznak)
        {

            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(ID_сотрудника) FROM Сотрудник");
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            try
                            {
                                max = Int32.Parse(res[0].ToString());
                            }

                            catch { max = 0; }


                            res.Close();

                            try
                            {
                                com.CommandText = string.Format("INSERT INTO Сотрудник([ID_сотрудника],[ФИО_сотрудника],[ID_отдела],[ID_должности],[Логин],[Пароль],[Признак]) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", max + 1, fio, id_dep, id_Post, login,pass, priznak);
                                com.ExecuteReader();
                            }
                            catch
                            {
                                conn.Close();
                                return false;
                            }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return true;
        }

        public static DataTable AllModel() 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT Техника.Наименование_модели FROM Прайс_лист, Техника WHERE Прайс_лист.ID_модели=Техника.ID_модели");
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }


        public static DataTable FindModel(int id, int price, int day) 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT Техника.Наименование_модели fROM Техника JOIN Подгруппа ON Техника.ID_подгруппы = Подгруппа.ID_подгруппы JOIN Группа_техники ON Подгруппа.ID_группы = Группа_техники.ID_группы WHERE Группа_техники.ID_группы =@id AND Техника.ID_модели IN(Select Прайс_лист.ID_модели from Прайс_лист Where Прайс_лист.Cтоимость <@price AND Прайс_лист.Cрок_поставки <@day)");
                    com.Parameters.Add("@day", SqlDbType.Int).Value = day;
                    com.Parameters.Add("@price", SqlDbType.Int).Value = price;
                    com.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }



        public static List<string> GetInfoModel(string name_model)  
        {

            List<string> listData = new List<string>();

            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = string.Format("SELECT * FROM Завод_изготовитель WHERE ID_завода=(SELECT ID_завода FROM Техника WHERE Наименование_модели='{0}')", name_model);
                command.Connection = connection;

                SqlDataReader reader = command.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            listData.Add(reader[i].ToString());
                        }
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return listData;
        }


        public static List<string> GetInfoModel2(string name_model) 
        {

            List<string> listData = new List<string>();

            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = string.Format("SELECT Прайс_лист.Cрок_поставки, Прайс_лист.Cтоимость FROM Прайс_лист JOIN Техника ON Прайс_лист.ID_модели = Техника.ID_модели WHERE Техника.Наименование_модели = '{0}'", name_model);
                command.Connection = connection;

                SqlDataReader reader = command.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            listData.Add(reader[i].ToString());
                        }
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return listData;
        }




        public static dynamic addFactory(string name, string address, string number, string email, int id_empl, string inn, string kpp) 
        {
            dynamic result = true;
            int count1=0;
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT count(*) FROM  Завод_изготовитель WHERE UPPER([Наименование_завода]) = '{0}'", name.ToUpper());
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            int count = Int32.Parse(res[0].ToString());
                            res.Close();
                            if (count == 0)
                            {
                                com.CommandText = string.Format("SELECT MAX(ID_завода) FROM  Завод_изготовитель");
                                using (SqlDataReader res1 = com.ExecuteReader())
                                {
                                    if (res1.Read())
                                    {
                                        count1 = Int32.Parse(res1[0].ToString());
                                        res1.Close();

                                        com.CommandText = string.Format("INSERT INTO  Завод_изготовитель([ID_завода],[Наименование_завода],[Адрес_завода],[Контактный_телефон],[Контактный_email],[ID_сотрудника],[ИНН],[КПП]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", count1 + 1, name, address, number, email, id_empl, inn, kpp);
                                        com.ExecuteReader();
                                    }
                                }
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        else
                        {
                            res.Close();
                        }

                    }
                }
                connection.Close();
            }
            return result;
        }


        public static bool deleteFactory(int id)  
        {
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();


                try
                {
                    using (SqlCommand com = connection.CreateCommand())
                    {
                        com.CommandText = string.Format("DELETE FROM Завод_изготовитель WHERE ID_завода='{0}'", id);
                        com.ExecuteNonQuery();
                    }

                }

                catch { return false; }
                connection.Close();
                return true;
            }
        }



        public static DataTable findReq(int id)
        {
            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT Наименование_банка,Расчетный_счет, Корреспондентский_счет, БИК FROM Банковские_реквизиты WHERE ID_завода='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }



        public static dynamic addClient(string type, string address, string name, string fio, string req, string contact1, string number1, string post1, string email1, string contact2, string number2, string post2, string email2, DateTime data, string status)  //добавить завод
        {
            
            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(ID_клиента) FROM Клиент");
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            try
                            {

                                try {
                                    max = Int32.Parse(res[0].ToString());
                                }

                                catch { max = 0; }

                                res.Close();

                                com.CommandText = string.Format("INSERT INTO Клиент ([ID_клиента],[Тип_клиента],[Адрес]) VALUES('{0}','{1}','{2}');" +
                                    "INSERT INTO Юридическое_лицо ([ID_клиента],[Название_юридического_лица],[ФИО_директора],[Банковские_реквизиты]," +
                                    "[Контактное_лицо_1],[Контактный_телефон_1],[Должность_1],[Контактный_email_1]," +
                                    "[Контактное_лицо_2],[Контактный_телефон_2],[Должность_2],[Контактный_email_2])" +
                                   " VALUES('{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}');" +
                                   "INSERT INTO Заявка_от_клиента ([ID_заявки_от_клиента],[Дата_заявки],[ID_клиента],[Статус_заявки]) VALUES('{15}','{16}','{17}','{18}');", max + 1, type, address, max + 1, name, fio, req, contact1, number1, post1, email1, contact2, number2, post2, email2, max + 1, data, max + 1, status);
                                com.ExecuteReader();

                            }
                            catch { conn.Close();
                                return false; }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return max + 1;
        }




        public static int getIdModel(string name)
        {

            try
            { int id = 0;




                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Select ID_модели from Техника Where Наименование_модели='{0}'", name);
                        using (SqlDataReader res = com.ExecuteReader())
                        {
                            if (res.Read()) {
                                id = Int32.Parse(res[0].ToString());
                            }

                            else
                            {
                                res.Close();
                            }
                        }
                    }
                    conn.Close();
                }
                return id;
            }
            catch { return 0; }
        }



        public static bool addTechnique(int id1, int id2, int id3, int number, int price)
        {
            bool result = true;
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {
                    //  try { 

                    com.CommandText = string.Format("INSERT INTO Техника_в_заявке([ID_модели],[ID_заявки_от_клиента],[ID_сотрудника],[Количество],[Цена_за_единицу]) VALUES('{0}','{1}','{2}','{3}','{4}')", id1, id2, id3, number, price);
                    com.ExecuteReader();
                    //  }

                    //  catch
                    //      {
                    //           result = false;
                    //      }


                }
                connection.Close();
            }


            return result;

        }

        public static dynamic addClient(string type, string address, string fio, string seria, string numerp, string place, string place2, string numberph, string datav, string email, string sub, DateTime data, string status)
        {

            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(ID_клиента) FROM Клиент");
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            try
                            {

                                try
                                {
                                    max = Int32.Parse(res[0].ToString());
                                }

                                catch { max = 0; }

                                res.Close();

                                com.CommandText = string.Format("INSERT INTO Клиент ([ID_клиента],[Тип_клиента],[Адрес]) VALUES('{0}','{1}','{2}');" +
                                    "INSERT INTO Физическое_лицо ([ID_клиента],[ФИО],[Серия_паспорта],[Номер_паспорта]," +
                                    "[Где_выдан],[Кем_выдан],[Номер_телефона],[Дата_выдачи]," +
                                    "[Контактный_email],[Код_подразделения])" +
                                   " VALUES('{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}');" +
                                   "INSERT INTO Заявка_от_клиента ([ID_заявки_от_клиента],[Дата_заявки],[ID_клиента],[Статус_заявки]) VALUES('{13}','{14}','{15}','{16}');", max + 1, type, address, max + 1, fio, seria, numerp, place, place2, numberph, datav, email, sub, max + 1, data, max + 1, status);
                                com.ExecuteReader();

                            }
                            catch
                            {
                                conn.Close();
                                return false;
                            }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return max + 1;
        }


        public static void deleteRequest(int id)
        {
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {
                    com.CommandText = string.Format("DELETE FROM Заявка_от_клиента WHERE ID_заявки_от_клиента='{0}'", id);
                    com.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static DataTable findClient(int idClient)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Клиент WHERE ID_клиента='{0}'", idClient);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }


        public static DataTable findClient1(int id)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Юридическое_лицо WHERE ID_клиента='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }


        public static DataTable findClient2(int id)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Физическое_лицо WHERE ID_клиента='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }


        public static DataTable findModelsRequest(int id)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM  Техника_в_заявке WHERE ID_заявки_от_клиента='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable getEmployee(int id)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM  Сотрудник WHERE ID_сотрудника='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable getCharact(int id)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM  Техническая_характеристика WHERE ID_характеристики='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable getGroup(int id)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM  Группа_техники WHERE ID_группы='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable getTechniquePriceList(DateTime data, int id_model)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM  Прайс_лист WHERE Дата='{0}' AND ID_модели='{1}'", data, id_model);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable getContact(int id, int num)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM  Контакт WHERE ID_завода='{0}' AND Номер_по_порядку='{1}'", id, num);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable getSubgroup(int id)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Подгруппа WHERE ID_подгруппы='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable getRequisite(int id, string name)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Банковские_реквизиты WHERE ID_завода='{0}' AND Наименование_банка='{1}'", id, name);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable getCity(int id)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM  Город WHERE ID_города='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable getFactory(int id)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM  Завод_изготовитель WHERE ID_завода='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static string getNameModel(int id)
        {

            try
            {
                string name = null;
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Select Наименование_модели from Техника Where ID_модели='{0}'", id);
                        using (SqlDataReader res = com.ExecuteReader())
                        {
                            if (res.Read())
                            {
                                name = res[0].ToString();
                            }

                            else
                            {
                                res.Close();
                            }
                        }
                    }
                    conn.Close();
                    return name;
                }

            }
            catch { return null; }


        }



        public static dynamic addContract(DateTime date, string number, int idEmpl, int idClient, int idReq, int numberScore, DateTime dateScore, string forma, int summa, string numberDKP, DateTime dateDKP, string numberAPP, DateTime dateAPP, string payment, string delivery)
        {

            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(ID_договора_с_клиентом) FROM Договор_с_клиентом");
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            //  try
                            // {

                            try
                            {
                                max = Int32.Parse(res[0].ToString());
                            }

                            catch { max = 0; }


                            res.Close();

                            com.CommandText = string.Format("INSERT INTO Договор_с_клиентом([ID_договора_с_клиентом],[Номер_договора_с_клиентом],[Дата_договора_с_клиентом],[Номер_счета]," +
                                "[Дата_счета],[Форма_оплаты],[ID_сотрудника],[ID_клиента],[ID_заявки_от_клиента],[Номер_ДКП],[Дата_ДКП],[Номер_АПП],[Дата_АПП],[Признак_доставки],[Сумма],[Признак_оплаты])" +
                                "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}');", max + 1, number, date, numberScore, dateScore, forma, idEmpl, idClient, idReq, numberDKP, dateDKP, numberAPP, dateAPP, delivery, summa, payment);
                            com.ExecuteReader();

                            //   }
                            // catch
                            //  {
                            //     conn.Close();
                            //     return false;
                            // }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return max + 1;
        }



        public static bool addContractTechnique(int idContract, int id, int count, int price, string presence, string guarante, string priznak, string priznak2)
        {
            bool result = true;
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {
                    try {

                        com.CommandText = string.Format("INSERT INTO Договор_с_клиентом_техника([ID_договора_с_клиентом],[ID_модели],[Количество],[Цена_за_единицу],[Признак_наличия_товара],[Гарантийный_срок], [Признак_наличия_договора], [Наличие_заявки_на_доставку]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}')", idContract, id, count, price, presence, guarante, priznak, priznak2);
                        com.ExecuteReader();
                    }

                    catch
                    {
                        result = false;
                    }


                }
                connection.Close();
            }


            return result;

        }


        public static bool updateStatus(int id, string status)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Заявка_от_клиента Set Статус_заявки='{0}' Where ID_заявки_от_клиента='{1}'", status, id);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }


        public static bool updatePriznakDelivery(string priznak,int idcontract, int id_model)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Договор_с_клиентом_техника Set Наличие_заявки_на_доставку='{0}' Where ID_договора_с_клиентом='{1}' AND ID_модели='{2}' ", priznak,idcontract,id_model);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }


        public static bool updateTechniqueStore(int id_part, DateTime data, int count, int price, int ost, string priznak)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Склад Set Дата_поступления='{0}', Количество='{1}', Cтоимость='{2}', Остаток_на_текущий_момент='{3}', Признак_техники='{4}' Where ID_партии='{5}'", data, count, price, ost, priznak,id_part);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }

        public static bool updateRequisite(int id, string name, int ras, int korr, int bik, string name_new)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Банковские_реквизиты Set Наименование_банка='{0}', Расчетный_счет='{1}', Корреспондентский_счет='{2}', БИК='{3}' Where ID_завода='{4}' AND Наименование_банка='{5}' ", name_new, ras,korr,bik,id,name);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }

        public static bool updateTechniquePriceList(DateTime data, int id_model, int price, int crok)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Прайс_лист Set Cтоимость='{0}', Cрок_поставки='{1}' Where Дата='{2}' AND ID_модели='{3}'", price, crok, data, id_model);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }



        public static bool updateFactory(int id,string name, string address, string namber, string email, int id_emp, string inn, string kpp)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Завод_изготовитель Set Наименование_завода='{0}', Адрес_завода='{1}', Контактный_телефон='{2}', Контактный_email='{3}', ID_сотрудника='{4}', ИНН='{5}', КПП='{6}' Where ID_завода='{7}' ", name, address, namber,email,id_emp, inn, kpp, id);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }

        public static bool updateContact(int id, int num, string contact, string post, string number, string email)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Контакт Set Контактное_лицо='{0}', Должность='{1}', Номер_телефона='{2}', Контактный_email='{3}' Where ID_завода='{4}' AND Номер_по_порядку='{5}'  ", contact, post, number, email,id, num);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }
        public static bool updateEmployee(int id, string fio, int id_dep, int id_post, string login, string pass)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {



                        com.CommandText = string.Format("Update Сотрудник Set ФИО_сотрудника='{0}', ID_отдела='{1}', ID_должности='{2}', Логин='{3}', Пароль='{4}' Where ID_сотрудника='{5}'", fio, id_dep, id_post,login,pass, id);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }




        public static bool deleteEmployee(int id)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Сотрудник Set Признак='Уволен' Where ID_сотрудника='{0}'", id);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }

        public static bool updateDepartment(int id, string name)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Отдел Set Название_отдела='{0}' Where ID_отдела='{1}'", name, id);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }

        public static bool updateGroup(int id, string name, int id_dep)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Группа_техники Set Название_группы='{0}', ID_отдела='{1}' Where ID_группы='{2}'", name,id_dep, id);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }

        public static bool updateSubgroup(int id, string name, int id_gr)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Подгруппа Set Название_подгруппы='{0}', ID_группы='{1}' Where ID_подгруппы='{2}'", name, id_gr, id);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }

        public static bool updateCity(int id, string name, int kil)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Город  Set Название_города='{0}', Километраж_до_города='{1}' Where ID_города='{2}'", name, kil, id);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }

        public static bool updateCharact(int id, string name)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Техническая_характеристика  Set Название_характеристики='{0}' Where ID_характеристики='{1}'", name, id);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }

        public static bool updatePost(int id, string name)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Должность Set Название_должности='{0}' Where ID_должности='{1}'", name, id);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }

        public static DataTable findContract(int idClient)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Договор_с_клиентом WHERE ID_клиента='{0}'", idClient);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable findModelsContract1(int idContract1)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM  Договор_с_клиентом_техника WHERE ID_договора_с_клиентом='{0}'", idContract1);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }


        public static dynamic addReqDel(DateTime date, int summa, int idContract1)
        {

            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(ID_заявки_на_доставку) FROM Заявка_на_доставку");
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            //  try
                            // {

                            try
                            {
                                max = Int32.Parse(res[0].ToString());
                            }

                            catch { max = 0; }


                            res.Close();

                            com.CommandText = string.Format("INSERT INTO Заявка_на_доставку([ID_заявки_на_доставку],[Дата_заявки],[Стоимость_доставки],[ID_договора_с_клиентом]) VALUES ('{0}','{1}','{2}','{3}');", max + 1, date, summa, idContract1);
                            com.ExecuteReader();

                            //   }
                            // catch
                            //  {
                            //     conn.Close();
                            //     return false;
                            // }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return max + 1;
        }







        public static int findIDCity(string city)  // 
        {

            int idCity = -1;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT ID_города FROM  Город WHERE Название_города='{0}'", city);
            using (SqlDataReader res = com.ExecuteReader())
            {
                if (res.Read())
                {

                      try
                      {
                    idCity = Int32.Parse(res[0].ToString());
                      }

                        catch { idCity = -1; }
                }
            }
                }
                conn.Close();
            }
            return idCity;
        }

        public static int getIDCharacter(string name)  // 
        {

           int id = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT ID_характеристики FROM Техническая_характеристика WHERE Название_характеристики='{0}'", name);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        try
                        {
                            id = Int32.Parse(res[0].ToString());
                        }

                        catch {  }
                    }
                }
                conn.Close();
            }
            return id;
        }

        public static dynamic addCity(string city, int kil)
        {

            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(ID_города) FROM Город");
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            //  try
                            // {

                            try
                            {
                                max = Int32.Parse(res[0].ToString());
                            }

                            catch { max = 0; }


                            res.Close();

                            com.CommandText = string.Format("INSERT INTO Город([ID_города],[Название_города],[Километраж_до_города]) VALUES('{0}','{1}','{2}');", max + 1, city, kil);
                            com.ExecuteReader();

                            //   }
                            // catch
                            //  {
                            //     conn.Close();
                            //     return false;
                            // }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return max + 1;
        }


        public static dynamic addCity1(string city, int kil)
        {

            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(ID_города) FROM Город");
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                              try
                             {

                            try
                            {
                                max = Int32.Parse(res[0].ToString());
                            }

                            catch { max = 0; }


                            res.Close();

                            com.CommandText = string.Format("INSERT INTO Город([ID_города],[Название_города],[Километраж_до_города]) VALUES('{0}','{1}','{2}');", max + 1, city, kil);
                            com.ExecuteReader();

                               }
                             catch
                              {
                                 conn.Close();
                                 return false;
                             }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return true;
        }

        public static dynamic addRout(int idReqDel, int idModel, int idCity, string address, int count, int countKil, int norma, int number1, DateTime date1, int number2, DateTime date2, int idEmpl)
        {

            bool result = true;
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {
                    try
                    {

                        com.CommandText = string.Format("INSERT INTO Маршрут([ID_заявки_на_доставку],[ID_модели],[ID_города],[Адрес],[Количество],[Общий_километраж],[Норма_расхода_топлива],[Номер_ком_удостоверения],[Дата_ком_удостоверения],[Номер_доверенности],[Дата_доверенности],[ID_сотрудника]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", idReqDel, idModel, idCity, address, count, countKil, norma, number1, date1, number2, date2, idEmpl);
                        com.ExecuteReader();
                    }

                    catch
                    {
                        result = false;
                    }


                }
                connection.Close();
            }


            return result;
        }


        public static bool addCharacter(int id_model, int id_character, string value)
        {

            bool result = true;
            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();
                using (SqlCommand com = connection.CreateCommand())
                {
                    try
                    {

                        com.CommandText = string.Format("INSERT INTO Описание_модели([ID_модели],[ID_характеристики],[Значение]) VALUES('{0}','{1}','{2}')", id_model, id_character, value );
                        com.ExecuteReader();
                    }

                    catch
                    {
                        result = false;
                    }


                }
                connection.Close();
            }


            return result;
        }


        public static DataTable getReqDel(int id)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Заявка_на_доставку  WHERE ID_заявки_на_доставку='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable getRout(int id)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Маршрут  WHERE ID_заявки_на_доставку='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }


        public static DataTable getDepartment(int id)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Отдел  WHERE ID_отдела='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable getPost(int id)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Должность  WHERE ID_должности='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }
        public static string getNameCity(int id)
        {

            try
            {
                string name = null;
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Select Название_города from Город Where ID_города='{0}'", id);
                        using (SqlDataReader res = com.ExecuteReader())
                        {
                            if (res.Read())
                            {
                                name = res[0].ToString();
                            }

                            else
                            {
                                res.Close();
                            }
                        }
                    }
                    conn.Close();
                    return name;
                }

            }
            catch { return null; }


        }
        public static DataTable getPriceList()  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT Прайс_лист.Дата, Техника.Наименование_модели, Прайс_лист.Cтоимость, Прайс_лист.Cрок_поставки FROM Прайс_лист,Техника WHERE Прайс_лист.ID_модели=Техника.ID_модели");
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static int getIDFactory(int idModel)
        {
            int id = 0;

            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("Select ID_завода from Техника Where ID_модели='{0}'", idModel);
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            id = Int32.Parse(res[0].ToString());
                        }
                        else
                        {
                            res.Close();
                        }
                    }
                }
                conn.Close();
            }
            return id;


        }
        public static string getNameFactory(int idFactory)
        {

            try
            {
                string name = null;
                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Select Наименование_завода from Завод_изготовитель Where ID_завода='{0}'", idFactory);
                        using (SqlDataReader res = com.ExecuteReader())
                        {
                            if (res.Read())
                            {
                                name = res[0].ToString();
                            }

                            else
                            {
                                res.Close();
                            }
                        }
                    }
                    conn.Close();
                    return name;
                }

            }
            catch { return null; }


        }

        public static bool addContractFactory(DateTime date, int number, int idFactory, DateTime dateprice, int idContract1, int summa, int idModel, int count, int price, int term)
        {

            int max = 0;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT MAX(ID_договора_с_заводом) FROM Договор_с_заводом");
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            try
                            {

                                try
                                {
                                    max = Int32.Parse(res[0].ToString());
                                }

                                catch { max = 0; }


                                res.Close();

                                com.CommandText = string.Format("INSERT INTO Договор_с_заводом([ID_договора_с_заводом],[Дата_договора_с_заводом],[Номер_договора_с_заводом],[ID_завода]," +
                                    "[Дата_оплаты],[ID_договора_с_клиентом],[Сумма_для_оплаты]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}');" +
                                    "INSERT INTO Техника_по_договору([ID_договора_с_заводом],[ID_модели],[Количество],[Цена_за_единицу],[Срок_поставки]) VALUES('{7}','{8}','{9}','{10}','{11}')", max + 1, date, number, idFactory, dateprice, idContract1, summa, max + 1, idModel, count, price, term);
                                com.ExecuteReader();

                            }
                            catch
                            {
                                conn.Close();
                                return false;
                            }
                        }

                        else
                        {
                            res.Close();
                        }

                    }
                }
                conn.Close();
            }
            return true;
        }

        public static int getIDRequest(int idContract1)
        {
            int id = 0;

            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("Select ID_заявки_от_клиента from Договор_с_клиентом Where ID_договора_с_клиентом='{0}'", idContract1);
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            id = Int32.Parse(res[0].ToString());
                        }
                        else
                        {
                            res.Close();
                        }
                    }
                }
                conn.Close();
            }
            return id;


        }

        public static bool updateStatus1(int idModel, string status)
        {

            try
            {




                using (SqlConnection conn = new SqlConnection(bd))
                {
                    conn.Open();
                    using (SqlCommand com = conn.CreateCommand())
                    {
                        com.CommandText = string.Format("Update Договор_с_клиентом_техника Set Признак_наличия_договора='{0}' Where ID_модели='{1}'", status, idModel);
                        com.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }

            }
            catch { return false; }


        }

        public static int getCountContract(int idContract1, string status)
        {
            int count = 0;

            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format(" SELECT COUNT(*) FROM Договор_с_клиентом_техника WHERE ID_договора_с_клиентом='{0}' AND Признак_наличия_договора='{1}'", idContract1, status);
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            count = Int32.Parse(res[0].ToString());
                        }
                        else
                        {
                            res.Close();
                        }
                    }
                }
                conn.Close();
            }
            return count;


        }

        public static List<int> getIDContract2(int idRequest)  
        {

            List<int> listData = new List<int>();

            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = string.Format("select ID_договора_с_заводом FROM Договор_с_заводом   WHERE ID_договора_с_клиентом=(SELECT ID_договора_с_клиентом FROM Договор_с_клиентом  WHERE ID_заявки_от_клиента='{0}')", idRequest);
                command.Connection = connection;

                SqlDataReader reader = command.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            listData.Add(Convert.ToInt32(reader[i].ToString()));
                        }
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return listData;
        }

        public static int getIDContract2Number(int numberContract2)  // 
        {
            int idContract2 = 0;

            using (SqlConnection connection = new SqlConnection(bd))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = string.Format("select ID_договора_с_заводом FROM Договор_с_заводом   WHERE Номер_договора_с_заводом='{0}'", numberContract2);
                    using (SqlDataReader res = command.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            idContract2 = Int32.Parse(res[0].ToString());
                        }
                        else
                        {
                            res.Close();
                        }
                    }
                }
                connection.Close();
            }
            return idContract2;
        }

        public static List<string> getContract2(int idContract2)  // 
        {

            List<string> listData = new List<string>();
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Договор_с_заводом WHERE ID_договора_с_заводом='{0}'", idContract2);
                    com.Connection = conn;

                    SqlDataReader reader = com.ExecuteReader();

                    try
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                listData.Add(reader[i].ToString());
                            }
                        }
                    }
                    finally
                    {
                        reader.Close();
                    }
                }

                return listData;
            }
        }

        public static DataTable getContract2Technique(int idContract2)  // 
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Техника_по_договору WHERE ID_договора_с_заводом='{0}'", idContract2);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable getAllContract1()
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Договор_с_клиентом");
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }

        public static DataTable getAllContract2()
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Договор_с_заводом");
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }


        public static DataTable getContract1Number(string numberContract1)
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Договор_с_клиентом WHERE Номер_договора_с_клиентом LIKE '{0}'", numberContract1+"%");
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }


        public static DataTable getTechniqueStoreId(int id)
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Склад WHERE ID_партии='{0}'", id);
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }
        public static DataTable getContract2Number(string numberContract2)
        {


            DataTable dt = null;
            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT * FROM Договор_с_заводом WHERE Номер_договора_с_заводом LIKE '{0}'", numberContract2+"%");
                    using (SqlDataReader res = com.ExecuteReader())
                    {

                        dt = new DataTable();
                        dt.Load(res);
                    }
                }
                conn.Close();
            }
            return dt;
        }
    

    public static List<int> getModelsContract1(int idContract1)  
    {

        List<int> listData = new List<int>();

        using (SqlConnection connection = new SqlConnection(bd))
        {
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format("SELECT ID_модели FROM Договор_с_клиентом_техника WHERE ID_договора_с_клиентом='{0}'", idContract1);
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        listData.Add(Convert.ToInt32(reader[i].ToString()));
                    }
                }
            }
            finally
            {
                reader.Close();
            }
        }

        return listData;
    }




        public static string findModelStore(int id_model)
        {
            int count = 0;

            using (SqlConnection conn = new SqlConnection(bd))
            {
                conn.Open();
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = string.Format("SELECT COUNT(*) FROM Склад WHERE ID_модели='{0}' AND Признак_техники='Для продажи'", id_model);
                    using (SqlDataReader res = com.ExecuteReader())
                    {
                        if (res.Read())
                        {
                            count = Int32.Parse(res[0].ToString());
                        }
                        else
                        {
                            res.Close();
                        }
                    }
                }
                conn.Close();
            }


            if (count == 0) { return "нет"; }
            else return "в наличии";


        }















    }

}




