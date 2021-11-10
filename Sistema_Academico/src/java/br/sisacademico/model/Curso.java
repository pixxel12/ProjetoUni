package br.sisacademico.model;

public class Curso {
    //Atributos
    private int idCurso;
    private String nomeCurso;
    private String tipoCurso;
    
    //Construtores
    public Curso() {
    }

    public Curso(int idCurso, String nomeCurso, String tipoCirso) {
        this.idCurso = idCurso;
        this.nomeCurso = nomeCurso;
        this.tipoCurso = tipoCirso;
    }
    
    // Métodos modificadores de acesso(sets e gets)
    public int getIdCurso() {
        return idCurso;
    }

    public void setIdCurso(int idCurso) {
        this.idCurso = idCurso;
    }

    public String getNomeCurso() {
        return nomeCurso;
    }

    public void setNomeCurso(String nomeCurso) {
        this.nomeCurso = nomeCurso;
    }

    public String getTipoCurso() {
        return tipoCurso;
    }

    public void setTipoCurso(String tipoCirso) {
        this.tipoCurso = tipoCirso;
    }

 
}
