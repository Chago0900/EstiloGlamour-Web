import React, { useState, useEffect } from 'react';
import axios from 'axios';

const DisplayData = () => {
  const [apiData, setApiData] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get('https://localhost:7209/api/Jugador');
        setApiData(response.data);
      } catch (error) {
        console.error('Error fetching data:', error);
      }
    };

    fetchData();
  }, []);

  return (
    <div>
      <h2>API Data Display</h2>
      {apiData ? (
        // Render your component using the fetched data
        <MyComponent data={apiData} />
      ) : (
        // Render a loading state or placeholder
        <p>Loading...</p>
      )}
    </div>
  );
};

const MyComponent = ({ data }) => {
    return (
      <div>
        <h3>User Data</h3>
        <table>
          <thead>
            <tr>
              <th>ID</th>
              <th>Username</th>
              <th>Name</th>
              <th>Last Name</th>
              <th>Email</th>
              <th>Age Range</th>
              <th>Country</th>
              {/* Add more table headings if needed */}
            </tr>
          </thead>
          <tbody>
            {data.map(user => (
              <tr key={user.id}>
                <td>{user.id}</td>
                <td>{user.nombre_usuario}</td>
                <td>{user.nombre}</td>
                <td>{user.apellido}</td>
                <td>{user.correo}</td>
                <td>{user.rango_edad}</td>
                <td>{user.pais}</td>
                {/* Add more table cells for additional data */}
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    );
  };

export default DisplayData;
