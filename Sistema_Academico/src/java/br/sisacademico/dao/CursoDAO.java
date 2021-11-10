package br.sisacademico.dao;

import br.sisacademico.model.Curso;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.HashMap;
import java.util.Map;
//Essa classe é responsavel por fazer o CRUD de cursos

public class CursoDAO {
    
    private static Statement stm = null;
    
    public Map<Curso, Integer>getTodosCursosCountAlunos() throws SQLException{
        Map<Curso, Integer> relatorio = new HashMap<Curso, Integer>();
        String query = "SELECT"
                + "    CURSO.IDCURSO,"
                + "    CURSO.NOME_CURSO,"
                + "    CURSO.TIPO_CURSO,"
                + "    (SELECT COUNT(*)"
                + "       FROM TB_ALUNO"
                + "      WHERE ID_CURSO = CURSO.ID_CURSO) as ALUNOS"
                + " FROM"
                + "    TB_CURSO AS CURSO"
                + " ORDER BY CURSO.NOME_CURSO";
        
    stm = ConnectionFactory.getConnection().createStatement(
            ResultSet.TYPE_SCROLL_INSENSITIVE,
            ResultSet.CONCUR_READ_ONLY); 
        ResultSet resultados = stm.executeQuery(query);
        
        while(resultados.next()) {
            Curso c = new Curso();
            c.setIdCurso(resultados.getInt("IDCURSO"));
            c.setNomeCurso(resultados.getString("NOME_CURSO"));
            c.setTipoCurso(resultados.getString("TIPO_CURSO"));
            int qtdAlunos = resultados.getInt("ALUNOS");
 
            relatorio.put(c, qtdAlunos);
        }
        
        stm.getConnection().close();
        
        return relatorio;
    }
 
}