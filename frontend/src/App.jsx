import { useState, useEffect } from "react";
import { fetchAnimais, adicionarAnimal } from "./services/api";
import AnimalForm from "./components/AnimalForm";
import AnimalList from "./components/AnimalList";

export default function AdocaoApp() {
  const [animais, setAnimais] = useState([]);

  useEffect(() => {
    loadAnimais();
  }, []);

  const loadAnimais = async () => {
    const data = await fetchAnimais();
    setAnimais(data);
  };

  const handleAddAnimal = async (novoAnimal) => {
    try {
      await adicionarAnimal(novoAnimal);
      loadAnimais();
    } catch (error) {
      console.error("Failed to add animal:", error);
    }
  };

  return (
    <div className="p-6 max-w-lg mx-auto space-y-6">
      <h1 className="text-2xl font-bold text-center text-gray-800">AdoCÃO</h1>
      <h1 className="text-2xl font-semibold text-center text-gray-800">
        Cadastro de Animais
      </h1>
      <AnimalForm onAddAnimal={handleAddAnimal} />
      <h2 className="text-lg font-semibold text-gray-700">Lista de Animais</h2>
      <AnimalList animais={animais} />
    </div>
  );
}
