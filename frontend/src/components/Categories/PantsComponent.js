import React, { useEffect, useState } from "react";
import { Container, Row, Col, Modal, Carousel } from "react-bootstrap";
import axios from "axios";function PantsComponent() {
  const [products, setProducts] = useState([]);
  const [modalShow, setModalShow] = useState(false);
  const [selectedImageIndex, setSelectedImageIndex] = useState(0);
  const categoryId = 505;
  useEffect(() => {
    axios
      .get(`http://localhost:5053/api/category?categoryId=${categoryId}`)
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
        <h1>Pants</h1>
        {products.map((pants, index) => (
          <Col
            key={pants.itemName}
            xs={12}
            sm={4}
            md={4}
            lg={4}
            onClick={() => openModal(index)}
          >
            <div className="full-width-image">
              <img
                className="IMGrid d-block w-100 mb-4"
                src={pants.img}
                alt={pants.imgId}
              />
            </div>
          </Col>
        ))}
      </Row>
      <Modal show={modalShow} onHide={closeModal} centered size="lg">
        <Modal.Body>
          <Carousel activeIndex={selectedImageIndex} onSelect={handleSelect}>
            {products.map((pants) => (
              <Carousel.Item key={pants.itemName}>
                <img
                  className="d-block w-100"
                  src={pants.img}
                  alt={pants.itemName}
                />
                <Modal.Footer>
                  <h3>{pants.itemName}</h3>
                  <p>Price: ${pants.cost}</p>
                  <p>Size: {pants.size}</p>
                  <p>SKU: {pants.sku}</p>
                  <p>add to cart button</p>
                </Modal.Footer>
              </Carousel.Item>
            ))}
          </Carousel>
        </Modal.Body>
      </Modal>
    </Container>
  );
}export default PantsComponent;