
package analizador_lexico;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Set;
import java.util.Stack;

/**
 *
 * @author Uriel(Dude)
 */

public class AFN {
    public static ArrayList<AFN> conjDeAFNs = new ArrayList<>();
    Estado edoIni;
    ArrayList<Estado> edosAFN = new ArrayList<>();
    ArrayList<Estado> edosAcept = new ArrayList<>();
    ArrayList<Character> alfabeto = new ArrayList<>();
    boolean seAgregoAFNUnionLexico;
    public int IdAFN;

    public AFN() {
        IdAFN = 0;
        edoIni = null;
        edosAFN.clear();
        edosAcept.clear();
        alfabeto.clear();
        seAgregoAFNUnionLexico = false;
    }
    
    public AFN crearAFNBasico(char s){
        Transicion t;
        Estado e1 = new Estado();
        Estado e2 = new Estado();
        t = new Transicion(s, e2);
        e1.getTrans().add(t);
        e2.setEdoAcept(true);
        this.alfabeto.add(s);
        edoIni = e1;
        this.edosAFN.add(e1);
        this.edosAFN.add(e2);
        this.edosAcept.add(e2);
        seAgregoAFNUnionLexico = false;
        return this;
    }
    
    public AFN crearAFNBasico(char s1, char s2){
        char i;
        
        Transicion t;
        Estado e1 = new Estado();
        Estado e2 = new Estado();
        t = new Transicion(s1, s2, e2);
        e1.getTrans().add(t);
        e2.setEdoAcept(true);
        for (i = s1; i <= s2; i++) {
            this.alfabeto.add(i);
        }
        edoIni = e1;
        this.edosAFN.add(e1);
        this.edosAFN.add(e2);
        this.edosAcept.add(e2);
        seAgregoAFNUnionLexico = false;
        return this;
    }
    
    public AFN UnirAFN(AFN f2){
        Estado e1 = new Estado();
        Estado e2 = new Estado();
        
        Transicion t1 = new Transicion(SimbolosEspeciales.EPSILON, this.edoIni);
        Transicion t2 = new Transicion(SimbolosEspeciales.EPSILON, f2.edoIni);
        e1.getTrans().add(t1);
        e1.getTrans().add(t2);
        for (Estado e : this.edosAcept) {
            e.getTrans().add(new Transicion(SimbolosEspeciales.EPSILON, e2));
            e.setEdoAcept(false);
        }
        for (Estado e : f2.edosAcept) {
            e.getTrans().add(new Transicion(SimbolosEspeciales.EPSILON, e2));
            e.setEdoAcept(false);
        }
        this.edosAcept.clear();
        f2.edosAcept.clear();
        this.edoIni = e1;
        e2.setEdoAcept(true);
        this.edosAcept.add(e2);
        this.edosAFN.addAll(f2.edosAFN);
        this.edosAFN.add(e1);
        this.edosAFN.add(e2);
        this.alfabeto = juntarAlfabetos(this.alfabeto, f2.alfabeto);
        return this;
    }
    
    public AFN ConcatAFN(AFN f2){
        for (Transicion t : f2.edoIni.getTrans()) {
            for (Estado e : this.edosAcept) {
                e.getTrans().add(t);
                e.setEdoAcept(false);
            }
        }
        f2.edosAFN.remove(f2.edoIni);
        this.edosAcept = f2.edosAcept;
        this.edosAFN.addAll(f2.edosAFN);
        this.alfabeto = juntarAlfabetos(this.alfabeto, f2.alfabeto);
        return this;
    }
    
    public ArrayList<Estado> CerraduraEpsilon(Estado e){
        ArrayList<Estado> R = new ArrayList<>();
        Stack<Estado> S = new Stack<>();
        Estado aux, edo;
        R.clear();
        S.clear();
        
        S.push(e);
        
        while(!S.empty()){
            aux = S.pop();
            R.add(aux);
            for (Transicion t : aux.getTrans()) {
                if((edo = t.getEdoTrans(SimbolosEspeciales.EPSILON)) != null){
                    if(!R.contains(edo)){
                        S.push(edo);
                    }
                }
            }
        }
        return R;
    }
    
    public ArrayList<Estado> CerraduraEpsilon(ArrayList<Estado> conjEdos){
        ArrayList<Estado> R = new ArrayList<>();
        Stack<Estado> S = new Stack<>();
        Estado aux, edo;
        R.clear();
        S.clear();
        for (Estado e : conjEdos) {
            S.push(e);
        }
        while(!S.empty()){
            aux = S.pop();
            R.add(aux);
            for (Transicion t : aux.getTrans()) {
                if((edo = t.getEdoTrans(SimbolosEspeciales.EPSILON)) != null){
                    if(!R.contains(edo)){
                        S.push(edo);
                    }
                }
            }
        }
        return R;
    }
    
    public ArrayList<Estado> Mover(Estado edo, char simb){
        ArrayList<Estado> C = new ArrayList<>();
        Estado aux;
        C.clear();
        
        for (Transicion t : edo.getTrans()) {
            aux = t.getEdoTrans(simb);
            if(aux != null){
                C.add(aux);
            }
        }
        return C;
    }
    
    public ArrayList<Estado> Mover(ArrayList<Estado> edos, char simb){
        ArrayList<Estado> C = new ArrayList<>();
        Estado aux;
        C.clear();
        
        for (Estado edo : edos) {
            for (Transicion t : edo.getTrans()) {
                aux = t.getEdoTrans(simb);
                if (aux != null) {
                    C.add(aux);
                }
            }
        }
        return C;
    }
    
    public ArrayList<Estado> Ir_A(ArrayList<Estado> Edos, char simb){
        ArrayList<Estado> C = new ArrayList<Estado>();
        C.clear();
        C = CerraduraEpsilon(Mover(Edos, simb));
        return C;
    }
    
    public void UnionEspecialAFNs(AFN f, int token){
        Estado e;
        if(!this.seAgregoAFNUnionLexico){
            this.edosAFN.clear();
            this.alfabeto.clear();
            e = new Estado();
            this.edoIni = e;
            this.edosAFN.add(e);
            this.seAgregoAFNUnionLexico = true;
        }else{
            this.edoIni.getTrans().add(new Transicion(SimbolosEspeciales.EPSILON,f.edoIni));
            for (Estado edoAcept : f.edosAcept) {
                edoAcept.setToken(token);
            }
            this.edosAcept.addAll(f.edosAcept);
            this.edosAFN.addAll(f.edosAFN);
            if(this.alfabeto.isEmpty()){
                this.alfabeto.addAll(f.alfabeto);
            }else{
                this.alfabeto = juntarAlfabetos(this.alfabeto, f.alfabeto);
            }
        }
    }
            
    public AFN CerraduraPos(){
        Estado e_ini = new Estado();
        Estado e_fin = new Estado();
        
        e_ini.getTrans().add(new Transicion(SimbolosEspeciales.EPSILON,edoIni));
        for (Estado e : edosAcept) {
            e.getTrans().add(new Transicion(SimbolosEspeciales.EPSILON,e_fin));
            e.getTrans().add(new Transicion(SimbolosEspeciales.EPSILON,edoIni));
            e.setEdoAcept(false);
        }
        
        edoIni = e_ini;
        e_fin.setEdoAcept(true);
        edosAcept.clear();
        edosAcept.add(e_fin);
        edosAFN.add(e_ini);
        edosAFN.add(e_fin);
        return this;
    }
    
    public AFN CerraduraKleen(){
        Estado e_ini = new Estado();
        Estado e_fin = new Estado();
        
        e_ini.getTrans().add(new Transicion(SimbolosEspeciales.EPSILON,edoIni));
        e_ini.getTrans().add(new Transicion(SimbolosEspeciales.EPSILON,e_fin));
        for (Estado e : edosAcept) {
            e.getTrans().add(new Transicion(SimbolosEspeciales.EPSILON,e_fin));
            e.getTrans().add(new Transicion(SimbolosEspeciales.EPSILON,edoIni));
            e.setEdoAcept(false);
        }
        
        edoIni = e_ini;
        e_fin.setEdoAcept(true);
        edosAcept.clear();
        edosAcept.add(e_fin);
        edosAFN.add(e_ini);
        edosAFN.add(e_fin);
        return this;
    }
    
    public AFN Opcional(){
        Estado e_ini = new Estado();
        Estado e_fin = new Estado();
        
        e_ini.getTrans().add(new Transicion(SimbolosEspeciales.EPSILON,edoIni));
        e_ini.getTrans().add(new Transicion(SimbolosEspeciales.EPSILON,e_fin));
        for (Estado e : edosAcept) {
            e.getTrans().add(new Transicion(SimbolosEspeciales.EPSILON,e_fin));
            e.setEdoAcept(false);
        }
        
        edoIni = e_ini;
        e_fin.setEdoAcept(true);
        edosAcept.clear();
        edosAcept.add(e_fin);
        edosAFN.add(e_ini);
        edosAFN.add(e_fin);
        return this;
    }
    
    public AFD ConvertirAFN(){
        ElemIj aux = null, aux2 = null;
        ArrayList<ElemIj> R = new ArrayList<>();
        LinkedList<ElemIj> Q = new LinkedList<>();
        AFD tabla = new AFD();
        int contador = 0;
        int indTransicion = 0;
        boolean encontrado = false;
        
        aux = new ElemIj();
        aux.conjEdos = this.CerraduraEpsilon(this.edoIni);
        aux.id = contador++;
        
        R.add(aux);
        Q.add(aux);
        int temp[] = new int[257];
        for (int k = 0; k < temp.length; k++) {
            temp[k] = -1;
        }
        tabla.tabla.add(temp);
        while(!Q.isEmpty()){
            aux = Q.poll();
            for (Character c : this.alfabeto) {
                aux2 = new ElemIj();
                aux2.id = contador;
                aux2.conjEdos = Ir_A(aux.conjEdos, c);
                if(!aux2.conjEdos.isEmpty()){
                    encontrado = false;
                    for (ElemIj elemIj : R) {
                        if (elemIj.conjEdos.equals(aux2.conjEdos) != false) {
                            tabla.tabla.get(aux.id)[c-1] = elemIj.id;
                            encontrado = true;
                        }
                    }
                    if(!encontrado){
                        aux2.id = contador++;
                        R.add(aux2);
                        Q.add(aux2);
                        temp = new int[257];
                        for (int k = 0; k < temp.length; k++) {
                            temp[k] = -1;
                        }
                        tabla.tabla.add(temp);
                        tabla.tabla.get(aux.id)[c-1] = aux2.id;
                    }
                }
            }
        }
        int j = 0;
        for (ElemIj elemIj : R) {
            tabla.tabla.get(j)[256] = -1;
            for (Estado conjEdo : elemIj.conjEdos) {
                if(conjEdo.isEdoAcept()){
                    tabla.tabla.get(j)[256] = conjEdo.getToken();
                    break;
                }
            }
            j++;
        }
        return tabla;
    }
    
    private ArrayList<Character> juntarAlfabetos(ArrayList<Character> a1, ArrayList<Character> a2){
        Set<Character> set = new HashSet<>();
        set.addAll(a1);
        set.addAll(a2);
        ArrayList<Character> temp = new ArrayList<>();
        for (Character character : set) {
            temp.add(character);
        }
        return temp;
    }
}
