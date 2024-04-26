import React, { useEffect, useState } from "react";
import { Container, Row, Col, Modal, Carousel } from "react-bootstrap";
import axios from "axios";function HomePageComponent() {
  const [products, setProducts] = useState([]);
  const [modalShow, setModalShow] = useState(false);
  const [selectedImageIndex, setSelectedImageIndex] = useState(0);  useEffect(() => {
    axios
      .get("http://localhost:5053/api/product") // Adjust this URL as needed
      .then((response) => {
        setProducts(response.data);
      })
      .catch((error) => {
        console.error("Error fetching data:", error);
      });
  }, []);  const openModal = (index) => {
    setSelectedImageIndex(index);
    setModalShow(true);
  };  const closeModal = () => {
    setModalShow(false);
  };  const handleSelect = (selectedIndex, e) => {
    setSelectedImageIndex(selectedIndex);
  };  return (
    <Container className="mb-4">
      <Row className="no-gutters">
        <h1>Products</h1>
        {products.map((product, index) => (
          <Col
            key={product.itemName}
            xs={12}
            sm={4}
            md={4}
            lg={4}
            onClick={() => openModal(index)} // Use index to manage modal image
          >
            <div className="full-width-image">
              <img
                className="IMGrid d-block w-100 mb-4"
                src={product.img}
                alt={product.imgId}
              />
            </div>
          </Col>
        ))}
      </Row>
      <Modal show={modalShow} onHide={closeModal} centered size="lg">
        <Modal.Body>
          <Carousel activeIndex={selectedImageIndex} onSelect={handleSelect}>
            {products.map((product) => (
              <Carousel.Item key={product.itemName}>
                <img
                  className="d-block w-100"
                  src={product.img}
                  alt={product.itemName}
                />
                <Carousel.Caption>
                  <h3>{product.itemName}</h3>
                  <p>Cost: ${product.cost}</p> 
                  <p>Size: {product.size}</p>
                  <p>SKU: {product.sku}</p>
                </Carousel.Caption>
              </Carousel.Item>
            ))}
          </Carousel>
        </Modal.Body>
      </Modal>
    </Container>
  );
}export default HomePageComponent;