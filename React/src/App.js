import { Form } from "reactstrap";
import { getQueriesForElement } from "@testing-library/dom";
import React, { useState, useEffect } from "react";
import "./App.css";
import "bootstrap/dist/css/bootstrap.min.css";
import axios from "axios";
import {
  Modal,
  ModalBody,
  ModalFloater,
  ModalFooter,
  ModalHeader,
} from "reactstrap";

function App() {
  const baseUrl = "https://localhost:44395/api/Personas";
  const [data, setData] = useState([]);

  const handleChange = (e) => {};

  const peticionGet = async () => {
    await axios
      .get(baseUrl)
      .then((response) => {
        setData(response.data);
      })
      .catch((error) => {
        console.log(error);
      });
  };

  useEffect(() => {
    peticionGet();
  }, []);

  return (
    <div className="App">
      <div className="table-responsive">
        <table className="table table table-sm table-md table-bordered">
          <thead>
            <tr>
              <th>id</th>
              <th>Run</th>
              <th>Nombre Completo</th>
              <th>Email</th>
              <th>Fecha de Nacimiento</th>
              <th>S/c</th>
              <th>Región</th>
              <th>Ciudad</th>
              <th>Comuna</th>
              <th>Dirección</th>
              <th>Teléfono</th>
              <th>Observaciones</th>
              <th>Acciones</th>
            </tr>
          </thead>
          <tbody>
            {data.map((personas) => (
              <tr key={personas.Id}>
                <td>{personas.Id}</td>
                <td>{personas.Run}</td>
                <td>{personas.Nombre}</td>
                <td>{personas.Email}</td>
                <td>{personas.FechaNacimiento}</td>
                <td>{personas.SexoCodigo}</td>
                <td>{personas.RegionCodigo}</td>
                <td>{personas.CiudadCodigo}</td>
                <td>{personas.ComunaCodigo}</td>
                <td>{personas.Direccion}</td>
                <td>{personas.Telefono}</td>
                <td>{personas.Observaciones}</td>
                <td>
                  <button className="btn btn-primary">Editar</button>
                  <button className="btn btn-danger">Eliminar</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      <Modal>
        <ModalHeader>Insertar Gestor de Base de Datos</ModalHeader>
        <ModalBody>
          <div className="form-group">
            <label>Run: </label>
            <br />
            <input type="text" className="form-control" />
            <br />
            <label>Lanzamiento: </label>
            <br />
            <input type="text" className="form-control" />
            <br />
            <label>Desarrollador: </label>
            <br />
            <input type="text" className="form-control" />
            <br />
          </div>
        </ModalBody>
        <ModalFooter>
          <button className="btn btn-primary">Insertar</button>
          {"   "}
          <button className="btn btn-danger">Cancelar</button>
        </ModalFooter>
      </Modal>
      </div>

    </div>
  );
}

export default App;
