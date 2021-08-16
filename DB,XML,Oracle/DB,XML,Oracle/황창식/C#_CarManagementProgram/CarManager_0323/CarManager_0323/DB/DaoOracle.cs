using CarManager_0323.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarManager_0323.DB
{
    class DaoOracle
    {
        const string CONNECT_ERROR = "DB 접속";
        const string DISCONNECT_ERROR = "DB 접속 해제";
        const string CREATE_TB_ERROR = "테이블+시퀀스 생성";
        const string DROP_TB_ERROR = "테이블+시퀀스 삭제";

        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=c##scott;Password=1126;";
        OracleConnection conn;
        OracleCommand cmd;

        public DaoOracle()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        // ~ : 소멸자 - 객체가 소멸될 때
        // 객체가 소멸 할 때 DB 접속 해제
        ~DaoOracle()
        {
            dbClose();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                errorMsg(e, CONNECT_ERROR);
            }
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제");
            }
            catch (OracleException e)
            {
                errorMsg(e, DISCONNECT_ERROR);
            }
        }

        public void makeTbCustomer()
        {
            string query = "CREATE TABLE CUSTOMER_T(" +
                "cus_id INT NOT NULL, " +
                "c_name VARCHAR2(20) NOT NULL, " +
                "c_tel VARCHAR2(20) NOT NULL, " +
                "c_addr VARCHAR2(50) NOT NULL, " +
                "c_email VARCHAR2(20), " +
                "CONSTRAINT CUSTOMER_PK PRIMARY KEY(cus_id))";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            string querySeq = "CREATE SEQUENCE CUSTOMER_T_SEQ START WITH 1 INCREMENT BY 1";
            cmd.CommandText = querySeq;
            cmd.ExecuteNonQuery();
            Console.WriteLine("테이블, 시퀀스 생성 성공!");
        }

        public void makeTbCar()
        {
            string query = "CREATE TABLE CAR_T(" +
                "car_id INT NOT NULL, " +
                "car_model VARCHAR2(20) NOT NULL, " +
                "car_color VARCHAR2(20) NOT NULL, " +
                "car_company VARCHAR2(20) NOT NULL, " +
                "car_price INT NOT NULL, " +
                "car_year VARCHAR2(20) NOT NULL, " +
                "CONSTRAINT CAR_PK PRIMARY KEY(car_id))";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            string querySeq = "CREATE SEQUENCE CAR_T_SEQ START WITH 1 INCREMENT BY 1";
            cmd.CommandText = querySeq;
            cmd.ExecuteNonQuery();
            Console.WriteLine("테이블, 시퀀스 생성 성공!");
        }

        public void makeTbSeller()
        {
            string query = "CREATE TABLE SELLER_T(" +
                "s_id INT NOT NULL, " +
                "s_name VARCHAR2(20) NOT NULL, " +
                "s_tel VARCHAR2(20) NOT NULL, " +
                "s_email VARCHAR2(20), " +
                "s_grade VARCHAR2(20) NOT NULL, " +
                "s_derijum VARCHAR2(20) NOT NULL, " +
                "CONSTRAINT SELLER_PK PRIMARY KEY(s_id))";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            string querySeq = "CREATE SEQUENCE SELLER_T_SEQ START WITH 1 INCREMENT BY 1";
            cmd.CommandText = querySeq;
            cmd.ExecuteNonQuery();
            Console.WriteLine("테이블, 시퀀스 생성 성공!");
        }

        public void makeTbOrderTable()
        {
            string query = "CREATE TABLE DEAL_T(" +
                "d_id INT NOT NULL, " +
                "d_date VARCHAR2(20) NOT NULL, " +
                "s_id INT NOT NULL, " +
                "cus_id INT NOT NULL, " +
                "car_id INT NOT NULL, " +
                "CONSTRAINT ORDER_TABLE_PK PRIMARY KEY(d_id), " +
                "CONSTRAINT FK_order_table_seller_id_selle FOREIGN KEY(s_id) REFERENCES SELLER_T(s_id), " +
                "CONSTRAINT FK_order_table_cus_id_customer FOREIGN KEY(cus_id) REFERENCES CUSTOMER_T(cus_id), " +
                "CONSTRAINT FK_order_table_car_id_car_car_ FOREIGN KEY(car_id) REFERENCES CAR_T(car_id))";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            string querySeq = "CREATE SEQUENCE DEAL_T_SEQ START WITH 1 INCREMENT BY 1";
            cmd.CommandText = querySeq;
            cmd.ExecuteNonQuery();
            Console.WriteLine("테이블, 시퀀스 생성 성공!");
        }

        public void dropTable(string tableName, string seqName)
        {
            string query = "DROP TABLE " + tableName + " CASCADE CONSTRAINTS";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            string querySeq = "DROP SEQUENCE " + seqName;
            cmd.CommandText = querySeq;
            cmd.ExecuteNonQuery();

            Console.WriteLine("테이블, 시퀀스 삭제 성공!");
        }

        public void makeTables()
        {
            try
            {
                makeTbCustomer();
                makeTbCar();
                makeTbSeller();
                makeTbOrderTable();
            }
            catch (OracleException e)
            {
                errorMsg(e, DROP_TB_ERROR);
            }
        }

        public void dropTables()
        {
            try
            {
                dropTable("DEAL_T", "DEAL_T_SEQ");
                dropTable("CUSTOMER_T", "CUSTOMER_T_SEQ");
                dropTable("CAR_T", "CAR_T_SEQ");
                dropTable("SELLER_T", "SELLER_T_SEQ");
            }
            catch (OracleException e)
            {
                errorMsg(e, CREATE_TB_ERROR);
            }

        }

        public void errorMsg(OracleException e, string msg)
        {
            Console.WriteLine(msg + "에러 번호 : " + e.Number);
            Console.WriteLine(msg + "에러 내용 : " + e.Message);
            switch (e.Number)
            {
                case 984:
                    MessageBox.Show("잘못된 숫자 입력방식 입니다.", "잘못된 입력방식");
                    break;
                case 942:
                    MessageBox.Show("테이블이 존재하지 않습니다.", "테이블 에러");
                    break;
                case 936:
                case 1400:
                    MessageBox.Show("누락된 정보가 있습니다.\n값을 입력해주세요.", "누락된 정보");
                    break;
                case 955:
                    MessageBox.Show("테이블이 이미 존재합니다.", "테이블 에러");
                    break;
            }
        }

        public void insertCar(Car car)
        {
            try
            {
                string query = string.Format("INSERT INTO CAR_T VALUES " +
                    "(CAR_T_SEQ.NEXTVAL,'{0}', '{1}', '{2}', {3}, '{4}')",
                    car.Model, car.Color, car.Company, car.Price, car.Year);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg(e, "insertCar()");
            }
        }

        public void insertCustomer(Customer customer)
        {
            try
            {
                string query = string.Format("INSERT INTO CUSTOMER_T VALUES (CUSTOMER_T_SEQ.NEXTVAL,'{0}', '{1}', '{2}', '{3}')", customer.Name, customer.Tel, customer.Addr, customer.Email);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg(e, "insertCustomer()");
            }
        }

        public void insertSeller(Seller seller)
        {
            try
            {
                string query = string.Format("INSERT INTO SELLER_T VALUES (SELLER_T_SEQ.NEXTVAL,'{0}', '{1}', '{2}', '{3}', '{4}')", seller.Name, seller.Tel, seller.Email, seller.Grade, seller.Derijum);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg(e, "insertSeller()");
            }
        }

        public void insertDeal(Seller seller, Customer cust, Car car)
        {
            if (car == null || cust == null || seller == null)
            {
                MessageBox.Show("거래 정보가 없습니다.", "거래 정보 없음");
            }

            else
            {
                try
                {
                    string query = string.Format("insert into deal_t values " +
                        "(DEAL_T_SEQ.nextval, sysdate, " +
                        "(select s_id from seller_t where s_name = '{0}' and s_tel = '{1}'), " +
                        "(select cus_id from customer_t where c_name = '{2}' and c_tel = '{3}'), " +
                        "(select car_id from car_t where car_model = '{4}' and car_price = {5}))",
                        seller.Name, seller.Tel, cust.Name, cust.Tel, car.Model, car.Price);
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
                catch (OracleException e)
                {
                    errorMsg(e, "insertDeal()");
                }
            }
        }

        public List<ListModel> selectDeal()
        {
            List<ListModel> list = new List<ListModel>();
            try
            {
                string query = "select c_name, car_model, car_price, s_name, d_date " +
                    "from DEAL_T d, CAR_T ca, CUSTOMER_T cu, SELLER_T s " +
                    "where d.car_id=ca.car_id and d.cus_id=cu.cus_id and d.s_id = s.s_id";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new ListModel(
                            Convert.ToString(reader["c_name"]),
                            Convert.ToString(reader["car_model"]),
                            Convert.ToString(reader["car_price"]),
                            Convert.ToString(reader["s_name"]),
                            Convert.ToString(reader["d_date"])
                            ));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException e)
            {
                errorMsg(e, "selectDeal()");
            }
            return list;
        }

        public Customer selectCustomer(string cus_name)
        {
            Customer cus1 = null;
            try
            {
                string query = string.Format("SELECT C_NAME, C_TEL, C_ADDR, C_EMAIL FROM CUSTOMER_T WHERE C_NAME='{0}'", cus_name);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cus1 = new Customer(Convert.ToString(reader["c_name"]), Convert.ToString(reader["c_tel"]), Convert.ToString(reader["c_addr"]), Convert.ToString(reader["c_email"]));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException e)
            {
                errorMsg(e, "selectCustomer()");
            }
            return cus1;
        }

        public Customer selectCustomer(string cus_name, string cus_tel)
        {
            Customer cus1 = null;
            try
            {
                string query = string.Format("SELECT C_NAME, C_TEL, C_ADDR, C_EMAIL FROM CUSTOMER_T WHERE C_NAME='{0}' AND C_TEL='{1}'", cus_name, cus_tel);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cus1 = new Customer(Convert.ToString(reader["c_name"]), Convert.ToString(reader["c_tel"]), Convert.ToString(reader["c_addr"]), Convert.ToString(reader["c_email"]));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException e)
            {
                errorMsg(e, "selectCustomer()");
            }
            return cus1;
        }

        public Car selectCar(string carName, string carPrice)
        {
            Car car = null;
            try
            {
                string query = string.Format("SELECT CAR_MODEL, CAR_COLOR, CAR_COMPANY, CAR_PRICE, CAR_YEAR FROM CAR_T WHERE CAR_MODEL='{0}' AND CAR_PRICE='{1}'", carName, carPrice);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        car = new Car(Convert.ToString(reader["car_model"]), Convert.ToString(reader["car_color"]), Convert.ToString(reader["car_company"]), Convert.ToInt32(reader["car_price"]), Convert.ToString(reader["car_year"]));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException e)
            {
                errorMsg(e, "selectCar()");
            }
            return car;
        }

        public Seller selectSeller(string sName)
        {
            Seller seller = null;
            try
            {
                string query = string.Format("SELECT S_NAME, S_TEL, S_EMAIL, S_GRADE, S_DERIJUM FROM SELLER_T WHERE S_NAME='{0}'", sName);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        seller = new Seller(Convert.ToString(reader["s_name"]), Convert.ToString(reader["s_tel"]), Convert.ToString(reader["s_email"]), Convert.ToString(reader["s_grade"]), Convert.ToString(reader["s_derijum"]));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException e)
            {
                errorMsg(e, "selectSeller()");
            }
            return seller;
        }
        
        public Seller selectSeller(string sName, string sTel)
        {
            Seller seller = null;
            try
            {
                string query = string.Format("SELECT S_NAME, S_TEL, S_EMAIL, S_GRADE, S_DERIJUM FROM SELLER_T WHERE S_NAME='{0}' AND S_TEL='{1}'", sName, sTel);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        seller = new Seller(Convert.ToString(reader["s_name"]), Convert.ToString(reader["s_tel"]), Convert.ToString(reader["s_email"]), Convert.ToString(reader["s_grade"]), Convert.ToString(reader["s_derijum"]));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException e)
            {
                errorMsg(e, "selectSeller()");
            }
            return seller;
        }
        
        public void updateCustomer(Customer customer, string cus_name)
        {
            try
            {
                string query = string.Format("UPDATE CUSTOMER_T SET C_NAME='{0}', C_TEL='{1}', C_ADDR='{2}', C_EMAIL='{3}' WHERE C_NAME='{4}'", customer.Name, customer.Tel, customer.Addr, customer.Email, cus_name);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("수정되었습니다.", "수정 완료");
            }
            catch (OracleException e)
            {
                errorMsg(e, "updateCustomer()");
            }
        }

        public void updateCustomer(Customer customer, string cus_name, string cus_tel)
        {
            try
            {
                string query = string.Format("UPDATE CUSTOMER_T SET C_NAME='{0}', C_TEL='{1}', C_ADDR='{2}', C_EMAIL='{3}' WHERE C_NAME='{4}' AND C_TEL='{5}'", customer.Name, customer.Tel, customer.Addr, customer.Email, cus_name, cus_tel);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("수정되었습니다.", "수정 완료");
            }
            catch (OracleException e)
            {
                errorMsg(e, "updateCustomer()");
            }
        }

        public void updateCar(Car car, string carName, string carPrice)
        {
            try
            {
                string query = string.Format("UPDATE CAR_T SET CAR_MODEL='{0}', CAR_COLOR='{1}', CAR_COMPANY='{2}', CAR_PRICE='{3}', CAR_YEAR='{4}' WHERE CAR_MODEL='{5}' AND CAR_PRICE='{6}'", car.Model, car.Color, car.Company, car.Price, car.Year, carName, carPrice);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("수정되었습니다.", "수정 완료");
            }
            catch (OracleException e)
            {
                errorMsg(e, "updateCar()");
            }
        }

        public void updateSeller(Seller seller, string sName)
        {
            try
            {
                string query = string.Format("UPDATE SELLER_T SET S_NAME='{0}', S_TEL='{1}', S_EMAIL='{2}', S_GRADE='{3}', S_DERIJUM='{4}' WHERE S_NAME='{5}'", seller.Name, seller.Tel, seller.Email, seller.Grade, seller.Derijum, sName);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("수정되었습니다.", "수정 완료");
            }
            catch (OracleException e)
            {
                errorMsg(e, "updateSeller()");
            }
        }
        
        public void updateSeller(Seller seller, string sName, string sTel)
        {
            try
            {
                string query = string.Format("UPDATE SELLER_T SET S_NAME='{0}', S_TEL='{1}', S_EMAIL='{2}', S_GRADE='{3}', S_DERIJUM='{4}' WHERE S_NAME='{5}' AND S_TEL='{6}'", seller.Name, seller.Tel, seller.Email, seller.Grade, seller.Derijum, sName, sTel);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("수정되었습니다.", "수정 완료");
            }
            catch (OracleException e)
            {
                errorMsg(e, "updateSeller()");
            }
        }
        
        public void deleteAllDeal()
        {
            try
            {
                string query = "DELETE FROM DEAL_T";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg(e, "deleteDeal()");
            }
        }
        
        public void deleteAllCar()
        {
            try
            {
                string query = "DELETE FROM CAR_T";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg(e, "deleteDeal()");
            }
        }
        
        public void deleteAllSeller()
        {
            try
            {
                string query = "DELETE FROM SELLER_T";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg(e, "deleteDeal()");
            }
        }
        
        public void deleteAllCust()
        {
            try
            {
                string query = "DELETE FROM CUSTOMER_T";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg(e, "deleteDeal()");
            }
        }
        
        public int tableChecker(string tableName)
        {
            int count = 0;
            try
            {
                string query = string.Format("select count(*) from all_tables " +
                    "where table_name = '{0}'", tableName);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader["count(*)"]);
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();

            }
            catch (OracleException e)
            {
                errorMsg(e, "tableChecker()");
            }
            return count;
        }

        public int cusCount(string data)
        {
            int count = 0;
            try
            {
                string query = string.Format("select count(*) from customer_t " +
                    "where c_name = '{0}'", data);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader["count(*)"]);
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();

            }
            catch (OracleException e)
            {
                errorMsg(e, "tableChecker()");
            }
            return count;
        }
        
        public int sellerCount(string data)
        {
            int count = 0;
            try
            {
                string query = string.Format("select count(*) from seller_t where s_name = '{0}'", data);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader["count(*)"]);
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();

            }
            catch (OracleException e)
            {
                errorMsg(e, "tableChecker()");
            }
            return count;
        }
    }
}
