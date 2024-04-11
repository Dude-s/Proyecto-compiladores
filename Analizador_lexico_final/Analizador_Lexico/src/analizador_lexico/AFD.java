
package analizador_lexico;

import java.io.Serializable;
import java.util.ArrayList;

/**
 *
 * @author Uriel(Dude)
 */

public class AFD implements Serializable{
    public int id;
    public ArrayList<int[]> tabla;

    public AFD() {
        this.tabla = new ArrayList<>();
    }
    
    public void leerArchivoAFD(String fileAFD, int idAFD){
        try {
                java.io.ObjectInputStream in = new java.io.ObjectInputStream(new java.io.FileInputStream(fileAFD));
                AFD temp = (AFD)in.readObject();
                this.id = idAFD;
                this.tabla = temp.tabla;
                in.close();
            } catch (Exception ex) {
                System.out.println("Algo ocurrio... "+ex);
            }
    }
}
