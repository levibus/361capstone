// I doubt anything in this file works

import React, { useState } from "react";
import { Container, Row, Col, Card, Form, Button } from "react-bootstrap";
import { Link } from "react-router-dom";
// import { useNavigate } from "react-router-dom";
import axios from "axios";

function PostButton() {
    const [createCartFrom, setCreateCartForm] = useState({
        firstName: "",
        lastName: "",
        username: "",
        password: "",
      });

  const handlePost = async () => {
    try {
      const response = await axios.post("https://your-api-endpoint.com", {
        // Add your request payload here
        // For example:
        // data: "some data"
      });
      // Assuming your API returns some message
      setResponseMessage(response.data.message);
    } catch (error) {
      console.error("Error:", error);
      // Handle errors here
    }
  };

  return (
    <div>
      <button onClick={handlePost}>Send POST Request</button>
      {responseMessage && <p>Response: {responseMessage}</p>}
    </div>
  );
}

export default PostButton;
