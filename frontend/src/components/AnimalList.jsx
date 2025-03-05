export default function AnimalList({ animais }) {
  return (
    <div className="space-y-2">
      {animais.map((animal, index) => (
        <div key={index} className="bg-gray-100 p-2 rounded-lg shadow-sm">
          <p className="text-gray-800">
            {animal.nome} - {animal.especie}
          </p>
        </div>
      ))}
    </div>
  );
}
