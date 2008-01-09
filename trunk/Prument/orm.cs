using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace Prument
{
    public enum FuncStatus { 
        Success,
        Fail
    }
    namespace ORM
    {
        public enum BindOperator { 
            Select,
            Update,
            Insert,
            Delete
        }
        public enum ORMStatus { 
            New,
            Saved
        }
        public class Products {
            private ORMStatus _status;
            private int _id;
            private string _name;
            private string _description;
            public ORMStatus Status {
                set {
                    _status = value;
                }
                get {
                    return _status;
                }
            }
            public int ID {
                set {
                    _id = value;
                }
                get { 
                    return _id;
                }
            }
            public string Name {
                set {
                    _name = value;
                }
                get {
                    return _name;
                }
            }
            public string Description {
                set {
                    _description = value;
                }
                get {
                    return _description;
                }
            }
            public Products()
            {
                this.Status = ORMStatus.New;
            }
            public Images Images = new Images();
            public FuncStatus DataBind(BindOperator _bo){
                bool _tf = true;
                OleDbConnection _conn = new OleDbConnection(Prument.Properties.Settings.Default.Properties["dataConnectionString"].DefaultValue.ToString());
                OleDbCommand _cmd = new OleDbCommand();
                OleDbDataReader _dr;
                _cmd.Connection = _conn;
                try
                {
                    _conn.Open();
                    if (_bo == BindOperator.Select)
                    {
                        _cmd.CommandText = "select Products.ID,Products.Name,Products.Description from Products where " + (this.ID != 0 ? "ID=" + this.ID.ToString() : (this.Name != null ? "Name='" + this.Name : "Description like '_" + this.Description + "_") + "'");
                    
                    }
                    if (_bo == BindOperator.Insert)
                    {
                        _cmd.CommandText = "insert into Products (Name,Description) values ('" + this.Name + "','" + this.Description + "')";
                        _cmd.ExecuteScalar();
                        _cmd.CommandText = "select ID,Name,Description from products where id = (select Max(ID) from Products)";
                    }
                    if (_bo == BindOperator.Update) {
                        _cmd.CommandText = "update products set Name='" + this.Name + "',Description='" + this.Description + "' where ID=" +this.ID;
                        _cmd.ExecuteNonQuery();
                        _cmd.CommandText = "select ID,Name,Description from products where id = " + this.ID;
                    }
                    if (_bo == BindOperator.Delete)
                    {
                        _cmd.CommandText = "select ID,Name,Description from products where id = " + this.ID;
                    }
                    _dr = _cmd.ExecuteReader();
                    _dr.Read();
                    this.ID = _dr.GetInt32(0);
                    this.Name = _dr.GetValue(1).ToString();
                    this.Description = _dr.GetValue(2).ToString();
                    this.Images.pID = this.ID;
                    _dr.Close();
                    if (_bo == BindOperator.Select) {
                        Images.DataBind(_bo);
                    }
                    if (_bo == BindOperator.Insert) {
                        Images.DataBind(_bo);
                    }
                    if (_bo == BindOperator.Update && this.Images.Path[0] != "") {
                        Images.DataBind(_bo);
                    }
                    if (_bo == BindOperator.Delete)
                    {
                        _cmd.CommandText = "delete from products where ID=" + this.ID;
                        _cmd.ExecuteNonQuery();
                        this.Images.clear();
                        this.Images.DataBind(BindOperator.Update);
                    }
                    this.Status = ORMStatus.Saved;
                }
                catch (Exception ex)
                {
                    _tf = false;
                    Exception _ex = new Exception("ORM.Products["+this.ID+"]:" + ex.Message);
                    throw _ex;
                }
                finally {
                    _conn.Close();
                }
                return _tf == false?FuncStatus.Fail:FuncStatus.Success;
            }
        }
        public class Images
        {
            private int[] _id=new int[255];
            private int _max = 0;
            private string[] _path=new string[255];
            private int _pid;
            public int Count {
                get {
                    return _max;
                }
            }
            public void add(string ipath) {
                _path[_max] = ipath;
                _max++;
            }
            public void remove(int iid) {
                int i = _max;
                int j;
                while (_max > 0)
                {
                    if (_id[i] == iid){
                        j = i;
                        while (j < _max)
                        {
                            _path[j] = _path[j + 1];
                            j++;
                        }
                        _max--;
                    }
                    i--;
                }
            }
            public void clear() {
                int i= 0;
                while(i < _max){
                    this.Path[i] = "";
                    i++;
                }

                _max = 0;
            }
            public int pID {
                set {
                    _pid = value;
                }
                get {
                    return _pid;
                }
            }
            public int[] ID {
                set {
                    _id = value;
                }
                get {
                    return _id;
                }
            }
            public string[] Path {
                set {
                    _path = value;
                }
                get {
                    return _path;
                }
            }
            public FuncStatus DataBind(BindOperator _bp)
            {
                bool _tf = true;
                int i;
                OleDbConnection _conn = new OleDbConnection(Prument.Properties.Settings.Default.Properties["dataConnectionString"].DefaultValue.ToString());
                OleDbCommand _cmd = new OleDbCommand();
                OleDbDataReader _dr;
                _cmd.Connection = _conn;
                try
                {
                    _conn.Open();
                    if (_bp == BindOperator.Update) {
                        _cmd.CommandText = "delete from Images where pID = " + this.pID;
                        _cmd.ExecuteNonQuery();
                    }
                    if (_bp == BindOperator.Insert || _bp == BindOperator.Update)
                    {
                        i = 0;
                        while (i < _max)
                        {
                            _cmd.CommandText = "insert into Images (Path,pID) values ('" + this.Path[i] + "'," + this.pID + ")";
                            _cmd.ExecuteNonQuery();
                            i++;
                        }
                    }
                    _cmd.CommandText = "select ID,Path,pID from Images where pID=" + this.pID;
                    _dr = _cmd.ExecuteReader();
                    i = 0;
                    while (_dr.Read())
                    {
                        this.ID[i] = _dr.GetInt32(0);
                        this.Path[i] = _dr.GetValue(1).ToString();
                        this.pID = _dr.GetInt32(2);
                        i++;
                    }

                }
                catch (Exception ex) {
                    _tf = false;
                    Exception _ex = new Exception("ORM.Images:" + ex.Message);
                    throw _ex;
                }
                finally
                {
                    _conn.Close();
                }
                return _tf == false ? FuncStatus.Fail : FuncStatus.Success;
            }
        }
    }
}
