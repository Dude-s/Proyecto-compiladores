
package analizador_lexico;

import java.util.ArrayList;

/**
 *
 * @author Uriel(Dude)
 */

public class Estado {
    static int contadorIdEstado = 0;
    private int idEstadoIni;
    private boolean edoAcept;
    private int token;
    private ArrayList<Transicion> trans = new ArrayList<Transicion>();

    public Estado() {
        edoAcept = false;
        token = -1;
        
        idEstadoIni = contadorIdEstado++;
        trans.clear();
    }

    public int getIdEstadoIni() {
        return idEstadoIni;
    }

    public void setIdEstadoIni(int idEstadoIni) {
        this.idEstadoIni = idEstadoIni;
    }

    public boolean isEdoAcept() {
        return edoAcept;
    }

    public void setEdoAcept(boolean edoAcept) {
        this.edoAcept = edoAcept;
    }

    public int getToken() {
        return token;
    }

    public void setToken(int token) {
        this.token = token;
    }

    public ArrayList<Transicion> getTrans() {
        return trans;
    }

    public void setTrans(ArrayList<Transicion> trans) {
        this.trans = trans;
    }
    
    
}
