import { useEffect, useState } from 'react'
import './App.css'

interface Person {
    name: string;
    age: number;
    sex: string;
    car: Car;
}

interface Car {
    model: string;
    plate: string;
    volume: number;
    createYear: number;
}

function App() {
    const [person, setPerson] = useState<Person | null>(null);

    useEffect(() => {
        fetch("https://localhost:7094/api/person")
            .then(async (response) => {
                console.log("status:", response.status);

                const text = await response.text();
                console.log("raw:", text);

                return JSON.parse(text);
            })
            .then(data => setPerson(data))
            .catch(error => console.error(error));
    }, []);

    console.log(person);

    return (
        <div>
            {person ? (
                <>
                    <p>Имя: {person.name}</p>
                    <p>Возраст: {person.age}</p>
                    <p>Пол: {person.sex}</p>

                    <h3>Машина</h3>
                    <p>Модель: {person.car.model}</p>
                    <p>Номер: {person.car.plate}</p>
                    <p>Объём: {person.car.volume}</p>
                    <p>Год: {person.car.createYear}</p>
                </>
            ) : (
                <p>Хозяин, сборка не собралась, разбей монитор</p>
            )}
        </div>
    );
}

export default App;