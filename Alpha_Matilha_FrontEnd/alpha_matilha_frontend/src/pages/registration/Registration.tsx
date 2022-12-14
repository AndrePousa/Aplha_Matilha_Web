import { PageContainer, PageTitle } from "../../components/MainComponents";
import { PageArea } from "./styled";

const Login = () => {
  return(
    <PageContainer>
      <PageTitle>Cadastre-se</PageTitle>
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
          <div className="area--title">Sobrenome:</div>
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
        <div className="area--title">Sexo:</div>
          <div className="area--input">
            <select>
              <option></option>
              <option>M</option>
              <option>F</option>
            </select>
          </div>
        </label>
        <label className="area">
          <div className="area--title">E-mail:</div>
          <div className="area--input">
            <input 
              type="email" 
              //disabled={disabled} 
              //value={email}
              //onChange={e => setEmail(e.target.value)}
              required
            />
          </div>
        </label>
        <label className="area">
          <div className="area--title">Telefone:</div>
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
          <div className="area--title">Whatsapp:</div>
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
          <div className="area--title">Classificação:</div>
          <div className="area--input">
            <select className="are--classification">
              <option></option>
              <option>Tutor</option>
              <option>Adestrador</option>
            </select>
          </div>
        </label>
        <hr/>
        <label className="area">
          <div className="area--title">Endereço:</div>
        </label>
        <label className="area">
          <div className="area--title">Rua:</div>
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
          <div className="area--title">Número:</div>
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
          <div className="area--title">Bairro:</div>
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
          <div className="area--title">Cidade:</div>
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
          <div className="area--title">Cep:</div>
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
          <div className="area--title">Estado:</div>
          <div className="area--input">
            <select className="are--classification">
              <option></option>
              <option>São Paulo</option>
              <option>Rio de Janeiro</option>
            </select>
          </div>
        </label>
        <label className="area">
          <div className="area--title"></div>
          <div className="area--input">
            <button>
              Cadastre-se
            </button>
          </div>
        </label>
        </form>
      </PageArea>
    </PageContainer>
  )
}
export default Login;