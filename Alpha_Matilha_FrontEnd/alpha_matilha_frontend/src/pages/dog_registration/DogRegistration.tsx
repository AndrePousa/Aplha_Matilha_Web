import React from 'react';
import { PageContainer, PageTitle } from '../../components/MainComponents';
import { PageArea } from './styled';

const DogRegistration = () => {
  return(
    <PageContainer>
      <PageTitle>Cadastro de cães</PageTitle>
      <PageArea>
      <form >
        <label className="area">
          <div className="area--title">Nome:</div>
          <div className="area--input">
            <input 
              type="text" 
              //disabled={disabled} 
              //value={email}
              //onChange={e => setEmail(e.target.value)}
              required
            />
          </div>
        </label>
        <label className="area">
          <div className="area--title">Raça:</div>
          <div className="area--input">
            <input 
              type="text" 
              //disabled={disabled} 
              //value={email}
              //onChange={e => setEmail(e.target.value)}
              required
            />
          </div>
        </label>
        <label className="area">
          <div className="area--title">Idade:</div>
          <div className="area--input--numero">
            <input className="area--input--numero"
              type="text" 
              //disabled={disabled} 
              //value={password}
              //onChange={e => setPassword(e.target.value)}
              required
            />
          </div>
        </label>
        <label className="area">
        <div className="area--title">Inicio das aulas</div>
          <div className="area--input">
          <input 
              type="date" 
              //disabled={disabled} 
              //value={email}
              //onChange={e => setEmail(e.target.value)}
              required
            />
          </div>
        </label>
        <label className="area">
          <div className="area--title">Atividade:</div>
          <div className="area--input">
            <select className="are--classification">
              <option></option>
              <option>Ativo</option>
              <option>Desativo</option>
            </select>
          </div>
        </label>
        <label className="area">
          <div className="area--title">Proprietário:</div>
          <div className="area--input">
            <input 
              type="text" 
              //disabled={disabled} 
              //value={password}
              //onChange={e => setPassword(e.target.value)}
              required
            />
          </div>
        </label>
        <label className="area">
        <div className="area--title">Termino do contrato das aulas:</div>
          <div className="area--input">
          <input 
              type="date" 
              //disabled={disabled} 
              //value={email}
              //onChange={e => setEmail(e.target.value)}
              required
            />
          </div>
        </label>
        <label className="area">
          <div className="area--title">Observações:</div>
          <div className="area--input">
            <textarea
              maxLength={500} 
              name="Observações"
            >
            </textarea> 
          </div>
        </label>
        <label className="area">
          <div className="area--title"></div>
          <div className="area--input">
            <button>Cadastrar</button>
          </div>
        </label>
        </form>

      </PageArea>
  </PageContainer>
  )
}

export default DogRegistration;