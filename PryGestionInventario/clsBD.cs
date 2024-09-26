using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;

namespace PryGestionInventario
{
    internal class clsBD
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public clsBD()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BD/BDInventario.accdb;";
        }

        public void Listar(DataGridView dgvUsuarios)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Productos";
                DataTable tablaProductos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);
                
                dgvUsuarios.DataSource = tablaProductos;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insertarProducto(clsProducto product)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"INSERT INTO Productos(Nombre, Descripcion, Precio, Stock, Categoria) VALUES('{product.Nombre}', '{product.Descripcion}','{product.Precio}','{product.Stock}','{product.Categoria}' )";
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void actualizarProducto(clsProducto producto)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"UPDATE Productos SET Nombre='{producto.Nombre}', Descripcion='{producto.Descripcion}',Precio='{producto.Precio}',Stock='{producto.Stock}', Categoria='{producto.Categoria}' WHERE Id = {producto.ID}";

                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void eliminarProducto(int id)
        {
            conexion = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"DELETE from Productos WHERE id={id}";
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }
        public void buscarProducto(string nombre, DataGridView dgvProducto)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"SELECT * FROM Productos WHERE Nombre LIKE '%{nombre}%'";
                DataTable tablaProductos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);

                dgvProducto.DataSource = tablaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void buscarProducto(int codigo, DataGridView dgvProducto)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"SELECT * FROM Productos WHERE ID={codigo}";
                DataTable tablaProductos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);

                dgvProducto.DataSource = tablaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void buscarProductoCat(string categoria, DataGridView dgvProducto)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"SELECT * FROM Productos WHERE Categoria LIKE '%{categoria}%'";
                DataTable tablaProductos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);

                dgvProducto.DataSource = tablaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        ArrayList Categoria = new ArrayList(); 
        ArrayList Stock = new ArrayList(); 
        public void listarStockxCategoria(Chart chCategoria)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Productos";
                DataTable dataTable = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    Categoria.Add(row["Categoria"].ToString());
                    Stock.Add(row["Stock"]);
                }
                chCategoria.Series[0].Points.DataBindXY(Categoria, Stock);
                Categoria.Clear();
                Stock.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
        public void listarStockxProducto(Chart chCategoria)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Productos";
                DataTable dataTable = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    Categoria.Add(row["Nombre"].ToString());
                    Stock.Add(row["Stock"]);
                }
                chCategoria.Series[0].Points.DataBindXY(Categoria, Stock);
                Categoria.Clear();
                Stock.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
