import axios from "axios";

const API_URL = "https://localhost:7259/api/Animais";

export const fetchAnimais = async () => {
  const response = await axios.get(API_URL);
  return response.data;
};

export const adicionarAnimal = async (novoAnimal) => {
  console.log("Dados enviados para o backend:", novoAnimal);
  await axios.post(`${API_URL}/AdicionarAnimal`, novoAnimal);
};

export const adotarAnimal = async (adotanteAdocaoRequest) => {
  await axios.post(`${API_URL}/AdotarAnimal`, adotanteAdocaoRequest);
};
