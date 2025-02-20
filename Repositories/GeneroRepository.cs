﻿using api_filmes_senai.Context;
using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;

namespace api_filmes_senai.Repositories
{

    /// <summary>
    /// Classe que vai implementar a interface IGeneroRepository
    /// Ou seja,vamos implementar os metodos, toda a logicas dos metodos
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        private readonly Filmes_Context _context;
        
        /// <summary>
        /// Construtor do repositorio
        /// Aqui, toda vez que o construtor for chamado, os dados do contexto estaram disponiveis
        /// </summary>
        /// <param name="contexto"></param>

        public GeneroRepository(Filmes_Context contexto) 
        {
            _context = contexto;
        }

        public void Atualizar(Guid id, Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero BurcarPorId(Guid id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Metodo para cadastrar um novo genero
        /// </summary>
        /// <param name="novoGenero"></param>
        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                //adiciona um novo genero na tabela Genero(BD)
                _context.Genero.Add(novoGenero);

                //Apos o cadastro, salva as alterações(BD)
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> Listar()
        {
            try
            {
                List<Genero> listaGeneros =  _context.Genero.ToList();
                return listaGeneros;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
