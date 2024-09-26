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
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;

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
        ArrayList Producto = new ArrayList();  
        ArrayList Cantidad = new ArrayList();  
        public void listarStockxCategoria(Chart chCategoria)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Categoria, SUM(Stock) AS TotalStock FROM Productos GROUP BY Categoria";
                DataTable dataTable = new DataTable();
                
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(dataTable);
                using (OleDbDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Categoria.Add(reader.GetString(0));
                        Stock.Add(reader.GetValue(1));
                    }
                }
                chCategoria.Series[0].Points.DataBindXY(Categoria, Stock);
                Categoria.Clear();
                Stock.Clear();
                conexion.Close();
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
                    Producto.Add(row["Nombre"]);
                    Cantidad.Add(row["Stock"]);
                }
                chCategoria.Series[0].Points.DataBindXY(Producto, Cantidad);
                Producto.Clear();
                Cantidad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ReporteStock()
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
                    String Nombre = row["Nombre"].ToString();
                    Int32 Stock = Convert.ToInt32(row["Stock"]);

                    if (Stock <= 10)
                    {
                        MessageBox.Show($"{Nombre} debe hacer una reposición, cantidad de stock: {Stock}", "Alerta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
