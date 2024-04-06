
package analizador_lexico;

import java.util.Stack;

/**
 *
 * @author Uriel(Dude)
 */

public class AnalizadorLexico {
    private int token,edoActual,edoTransicion,iniLexema,finLexema,iCharAct;
    private String cadenaSigma;
    private char charAct;
    public String lexema;
    private Boolean pasoPorEdoAcept;
    Stack<Integer> pila = new Stack<>();
    AFD automataAFD;
    
    public AnalizadorLexico(){
        this.cadenaSigma = "";
        this.pasoPorEdoAcept = false;
        this.iniLexema = this.finLexema = -1;
        this.iCharAct = -1;
        this.token = -1;
        this.pila.clear();
        automataAFD = null;
    }
    
    public AnalizadorLexico(String sigma, String fileAFD, int IdAFD){
        this.automataAFD = new AFD();
        this.cadenaSigma = sigma;
        this.pasoPorEdoAcept = false;
        this.iniLexema = 0;
        this.finLexema = -1;
        this.iCharAct = 0;
        this.token = -1;
        this.pila.clear();
        automataAFD.leerArchivoAFD(fileAFD, IdAFD);
    }
    
    public AnalizadorLexico(String sigma, String fileAFD){
        this.automataAFD = new AFD();
        this.cadenaSigma = sigma;
        this.pasoPorEdoAcept = false;
        this.iniLexema = 0;
        this.finLexema = -1;
        this.iCharAct = 0;
        this.token = -1;
        this.pila.clear();
        automataAFD.leerArchivoAFD(fileAFD, -1);
    }
    
    public AnalizadorLexico(String fileAFD,int idAFD){
        this.automataAFD = new AFD();
        this.cadenaSigma = "";
        this.pasoPorEdoAcept = false;
        this.iniLexema = 0;
        this.finLexema = -1;
        this.iCharAct = 0;
        this.token = -1;
        this.pila.clear();
        automataAFD.leerArchivoAFD(fileAFD, idAFD);
    }
    
    public AnalizadorLexico(String sigma, AFD newAFD){
        this.automataAFD = newAFD;
        this.cadenaSigma = sigma;
        this.pasoPorEdoAcept = false;
        this.iniLexema = 0;
        this.finLexema = -1;
        this.iCharAct = 0;
        this.token = -1;
        this.pila.clear();
    }
    
    public AnalizadorLexico getEdoAnalizadorLexico(){
        AnalizadorLexico edoActAnalzLX = new AnalizadorLexico();
        edoActAnalzLX.token = this.token;
        edoActAnalzLX.edoActual = this.edoActual;
        edoActAnalzLX.edoTransicion = this.edoTransicion;
        edoActAnalzLX.iniLexema = this.iniLexema;
        edoActAnalzLX.finLexema = this.finLexema;
        edoActAnalzLX.iCharAct = this.iCharAct;
        edoActAnalzLX.charAct = this.charAct;
        edoActAnalzLX.lexema = this.lexema;
        edoActAnalzLX.pasoPorEdoAcept = this.pasoPorEdoAcept;
        edoActAnalzLX.pila = this.pila;
        return edoActAnalzLX;
    }
    
    public Boolean setEdoAnalizadorLexico(AnalizadorLexico e){
        this.token = e.token;
        this.edoActual = e.edoActual;
        this.edoTransicion = e.edoTransicion;
        this.iniLexema = e.iniLexema;
        this.finLexema = e.finLexema;
        this.iCharAct = e.iCharAct;
        this.charAct = e.charAct;
        this.lexema = e.lexema;
        this.pasoPorEdoAcept = e.pasoPorEdoAcept;
        this.pila = e.pila;
        return true;
    }
    
    public void setSigma(String sigma){
       this.cadenaSigma = sigma;
       this.pasoPorEdoAcept = false;
       this.iniLexema = 0;
       this.finLexema = -1;
       this.iCharAct = 0;
       this.token = -1;
       this.pila.clear();
    }
    
    public String cadenaXAnalizar(){
        return this.cadenaSigma.substring(iCharAct,cadenaSigma.length() - iCharAct);
    }
    
    public int yylex(){
        while(true){
            pila.push(iCharAct);
            if(iCharAct >= cadenaSigma.length()){
                lexema = "";
                return SimbolosEspeciales.FIN;
            }
            iniLexema = iCharAct;
            edoActual = 0;
            pasoPorEdoAcept = false;
            finLexema = -1;
            token = -1;
            while(iCharAct < cadenaSigma.length()){
                charAct = cadenaSigma.charAt(iCharAct);
                edoTransicion = automataAFD.tabla.get(edoActual)[charAct-1];
                if(edoTransicion != -1){
                    if(automataAFD.tabla.get(edoTransicion)[256] != -1){
                        pasoPorEdoAcept = true;
                        token = automataAFD.tabla.get(edoTransicion)[256];
                        finLexema = iCharAct;
                    }
                    iCharAct++;
                    edoActual = edoTransicion;
                    continue;
                }
                break;
            }
            if(!pasoPorEdoAcept){
                iCharAct = iniLexema+1;
                lexema = cadenaSigma.substring(iniLexema, 1);
                token = SimbolosEspeciales.ERROR;
                return token;
            }
            
            lexema = cadenaSigma.substring(iniLexema, finLexema+1);
            iCharAct = finLexema+1;
            if(token==SimbolosEspeciales.OMITIR){
                continue;
            }else{
                return token;
            }
        }
    }
    
    public Boolean undoToken(){
        if(pila.capacity() == 0){
            return false;
        }
        iCharAct = pila.pop();
        return true;
    }
}
