
package analizador_lexico; // Definición del paquete al que pertenece esta clase

import javax.swing.table.AbstractTableModel; // Importación de la clase AbstractTableModel

/**
 *
 * @author Uriel(Dude)
 */

// Declaración de la clase modeloTablaUnionLX que extiende AbstractTableModel
public class modeloTablaUnionLX extends AbstractTableModel {
    private String[] columnNames = null; // Arreglo para almacenar los nombres de las columnas de la tabla
    private Object[][] data = null; // Arreglo bidimensional para almacenar los datos de la tabla

    // Constructor de la clase que recibe los nombres de las columnas y los datos de la tabla
    public modeloTablaUnionLX(String[] columnNames, Object[][] data) {
        this.columnNames = columnNames; // Asigna los nombres de las columnas proporcionados
        this.data = data; // Asigna los datos proporcionados
    }

    // Método para obtener el número de columnas de la tabla
    public int getColumnCount() {
        return columnNames.length; // Devuelve la longitud del arreglo de nombres de columnas
    }

    // Método para obtener el número de filas de la tabla
    public int getRowCount() {
        return data.length; // Devuelve la cantidad de elementos en el arreglo de datos
    }

    // Método para obtener el nombre de una columna específica
    public String getColumnName(int col) {
        return columnNames[col]; // Devuelve el nombre de la columna correspondiente al índice proporcionado
    }

    // Método para obtener el valor de una celda específica de la tabla
    public Object getValueAt(int row, int col) {
        return data[row][col]; // Devuelve el valor de la celda en la fila y columna proporcionadas
    }

    // Método para obtener la clase de los objetos en una columna específica
    public Class getColumnClass(int c) {
        return getValueAt(0, c).getClass(); // Devuelve la clase del objeto en la celda especificada
    }
    
    // Método para verificar si una celda es editable o no
    public boolean isCellEditable(int row, int col) {
        if (col < 1) {
            return false; // Devuelve falso si la columna es menor que 1 (no editable)
        } else {
            return true; // Devuelve verdadero si la columna es mayor o igual a 1 (editable)
        }
    }
    
    // Método para establecer el valor de una celda específica de la tabla
    public void setValueAt(Object value, int row, int col) {
        data[row][col] = value; // Asigna el nuevo valor a la celda especificada
        fireTableCellUpdated(row, col); // Notifica a los escuchadores que la celda ha sido actualizada
    }
}
