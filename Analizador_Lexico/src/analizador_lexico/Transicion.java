
package analizador_lexico;


/**
 *
 * @author Uriel(Dude)
 */

public class Transicion {
    private char simbInf;
    private char simbSup;
    private Estado edo;

    public Transicion(char simbInf, char simbSup, Estado edo) {
        this.simbInf = simbInf;
        this.simbSup = simbSup;
        this.edo = edo;
    }

    public Transicion(char simb, Estado edo) {
        this.simbInf = simb;
        this.simbSup = simb;
        this.edo = edo;
    }
    
    public Transicion(){
        this.edo = null;
    }
    
    public void setTransicion(char s1, Estado e){
        this.simbInf = s1;
        this.simbSup = s1;
        this.edo = e;
        return;
    }

    public char getSimbInf() {
        return simbInf;
    }

    public void setSimbInf(char simbInf) {
        this.simbInf = simbInf;
    }

    public char getSimbSup() {
        return simbSup;
    }

    public void setSimbSup(char simbSup) {
        this.simbSup = simbSup;
    }
    
    public Estado getEdoTrans(char s){
        if(this.simbInf <= s && this.simbSup >= s){
            return edo;
        }
        return null;
    }
}
