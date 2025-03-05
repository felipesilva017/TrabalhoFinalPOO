import { useState } from "react";

const initialData = {
  nome: "",
  idade: "",
  especie: "Cachorro",
};

export default function AnimalForm({ onAddAnimal }) {
  const [data, setData] = useState(initialData);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setData((prevData) => ({
      ...prevData,
      [name]: value,
    }));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    const { nome, idade, especie } = data;
    if (!nome || !idade || !especie) return;
    try {
      const novoAnimal = { nome, idade: parseInt(idade), especie };
      console.log("Enviando animal:", novoAnimal); // Adiciona o log aqui
      await onAddAnimal(novoAnimal);
      setData(initialData);
    } catch (error) {
      console.error("Failed to add animal:", error);
    }
  };

  return (
    <div className="bg-white shadow-md rounded-lg p-6">
      <form onSubmit={handleSubmit} className="space-y-4">
        <input
          type="text"
          name="nome"
          placeholder="Nome do animal"
          value={data.nome}
          onChange={handleChange}
          className="w-full p-2 border border-gray-300 rounded-lg"
        />
        <input
          type="number"
          name="idade"
          placeholder="Idade do animal"
          value={data.idade}
          onChange={handleChange}
          className="w-full p-2 border border-gray-300 rounded-lg"
        />
        <select
          name="especie"
          className="w-full p-2 border border-gray-300 rounded-lg bg-white"
          value={data.especie}
          onChange={handleChange}
        >
          <option value="Cachorro">Cachorro</option>
          <option value="Gato">Gato</option>
        </select>
        <button
          type="submit"
          className="w-full bg-blue-600 text-white p-2 rounded-lg hover:bg-blue-700"
        >
          Adicionar Animal
        </button>
      </form>
    </div>
  );
}
