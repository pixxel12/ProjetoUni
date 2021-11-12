<%@page import="java.util.Map"%>
<%@page import="br.sisacademico.model.Curso"%>
<%@page import="br.sisacademico.dao.CursoDAO"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%
    CursoDAO cDAO = new CursoDAO();
    Map<Curso, Integer> listaCursos = cDAO.getTodosCursosCountAlunos();
%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>SisAcadêmico - Cursos</title>
    </head>
    <body>
        <jsp:include page="../menu.jsp"></jsp:include> 
        <script src="../js/modalExclusao.js">  </script>  
        
            <script>
                $(function () {
                    $('[data-toggle="tooltip"]').tooltip()
                })
            </script>
            <div class="container mt-4 pt-4">
                <table class="table justify-content-center">
                    <thead class="thead-dark">
                    <th scope="col">Curso</th>
                    <th scope="col" class="text-center">Tipo de Curso</th>
                    <th scope="col" class="text-center">Qtd. de Alunos</th>
                    <th scope="col" class="text-center">Ver Alunos</th>
                    <th scope="col" class="text-center">Editar</th>
                    <th scope="col" class="text-center">Excluir</th>
                    </thead>
                    <tbody>
                    <% for (Map.Entry<Curso, Integer> c : listaCursos.entrySet()) {%>
                    <tr>
                        <td><%= c.getKey().getNomeCurso()%></td>
                        <td class="text-center"><%= c.getKey().getTipoCurso()%></td>
                        <td class="text-center"><%= c.getValue()%></td>
                        <% if (c.getValue() == 0) { %>
                        <td class="text-center">
                            <span class="d-inline-block" tabindex="0" data-toggle="tooltip" title="Sem alunos">
                                <button class="btn btn-secondary" disabled="true" style="pointer-events: none;" type="button">Alunos Matriculados</button>
                            </span>
                        </td>
                        <% } else { %>
                        <td class="text-center">
                            <a class="btn btn-info" href="#">Alunos Matriculados</a>
                        </td>
                        <% } %>
                        <td class="text-center">
                            <a class="btn btn-success" href="#">Editar</a>
                        </td>
                        <% if (c.getValue() == 0) { %>
                        <td class="text-center">
                            <a class="btn btn-danger" href="#">Excluir</a>
                        </td>
                        <% } else { %>
                        <td class="text-center">
                            <span class="d-inline-block" tabindex="0" data-toggle="tooltip" title="Não é possível excluir curso com alunos">
                                <button class="btn btn-secondary" disabled="true" style="pointer-events: none;" type="button">Excluir</button>
                            </span>
                        </td>
                        <% } %>
                    </tr>
                    <%  }%>
                </tbody>
            </table>
        </div>
    </body>
</html>