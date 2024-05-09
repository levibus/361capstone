import React, { useEffect, useState } from "react";
import { Container, Row, Col, Modal, Carousel } from "react-bootstrap";
import axios from "axios";function ShoesComponent() {
  const [products, setProducts] = useState([]);
  const [modalShow, setModalShow] = useState(false);
  const [selectedImageIndex, setSelectedImageIndex] = useState(0);
  const categoryId = 606;
  // we can just hardcode categoryId in for each page
  useEffect(() => {
    axios
      .get(`http://localhost:5053/api/category?categoryId=${categoryId}`)
      // change to shoes or Products, idk
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
        <h1>Shoes</h1>
        {products.map((shoes, index) => (
          <Col
            key={shoes.itemName}
            xs={12}
            sm={4}
            md={4}
            lg={4}
            onClick={() => openModal(index)}
          >
            <div className="full-width-image">
              <img
                className="IMGrid d-block w-100 mb-4"
                src={shoes.img}
                alt={shoes.imgId}
              />
            </div>
          </Col>
        ))}
      </Row>
      <Modal show={modalShow} onHide={closeModal} centered size="lg">
        <Modal.Body>
          <Carousel activeIndex={selectedImageIndex} onSelect={handleSelect}>
            {products.map((shoes) => (
              <Carousel.Item key={shoes.itemName}>
                <img
                  className="d-block w-100"
                  src={shoes.img}
                  alt={shoes.itemName}
                />
                <Modal.Footer>
                  <h3>{shoes.itemName}</h3>
                  <p>Price: ${shoes.cost}</p>
                  <p>Size: {shoes.size}</p>
                  <p>SKU: {shoes.sku}</p>
                  <p>add to cart button</p>
                </Modal.Footer>
              </Carousel.Item>
            ))}
          </Carousel>
        </Modal.Body>
      </Modal>
    </Container>
  );
}export default ShoesComponent;