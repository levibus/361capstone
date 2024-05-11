import React, { useEffect, useState } from "react";
import { Container, Row, Col, Modal, Carousel } from "react-bootstrap";
import axios from "axios";function ShirtsComponent() {
  const [products, setProducts] = useState([]);
  const [modalShow, setModalShow] = useState(false);
  const [selectedImageIndex, setSelectedImageIndex] = useState(0);
  const categoryId = 404;
  // we can just hardcode categoryId in for each page
  useEffect(() => {
    axios
      .get(`http://localhost:5053/api/category?categoryId=${categoryId}`)
      // change to shirts or Products, idk
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
        <h1>Shirts</h1>
        {products.map((shirts, index) => (
          <Col
            key={shirts.itemName}
            xs={12}
            sm={4}
            md={4}
            lg={4}
            onClick={() => openModal(index)}
          >
            <div className="full-width-image">
              <img
                className="IMGrid d-block w-100 mb-4"
                src={shirts.img}
                alt={shirts.imgId}
              />
            </div>
          </Col>
        ))}
      </Row>
      <Modal show={modalShow} onHide={closeModal} centered size="lg">
        <Modal.Body>
          <Carousel activeIndex={selectedImageIndex} onSelect={handleSelect}>
            {products.map((shirts) => (
              <Carousel.Item key={shirts.itemName}>
                <img
                  className="d-block w-100"
                  src={shirts.img}
                  alt={shirts.itemName}
                />
                <Modal.Body>
                  <h3>{shirts.itemName}</h3>
                  <p>Price: ${shirts.cost}</p>
                  <p>Size: {shirts.size}</p>
                  <p>SKU: {shirts.sku}</p>
                  <p>add to cart button</p>
                </Modal.Body>
              </Carousel.Item>
            ))}
          </Carousel>
        </Modal.Body>
      </Modal>
    </Container>
  );
}export default ShirtsComponent;