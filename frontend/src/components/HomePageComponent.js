import React from "react";
import { Container, Row, Col, Modal, Carousel } from "react-bootstrap";

function HomePageComponent() {
  const galleryImages = [
    // For Sale Items we want to highlight on main page
    {
      id: "IM_1",
      src: "https://media.istockphoto.com/id/1149383049/photo/red-white-striped-socks.jpg?s=1024x1024&w=is&k=20&c=dgrkYq5sVfZr2i-TwccFEee-ROKVWBo4e8tUKyYOnvU=",
      alt: "Image 1",
    },
    {
      id: "IM_2",
      src: "https://images.ctfassets.net/ub3bwfd53mwy/6PhlUjXZqaHqu6LqJ5G3X3/ee400fdfaf784e3d530a212ce3453c48/1_Image.jpg?w=750",
      alt: "Image 2",
    },
    {
      id: "IM_3",
      src: "https://images.ctfassets.net/ub3bwfd53mwy/6atCoddzStFzz0RcaztYCh/1c3e8a37eebe3c6a435038f8d9eef7f3/3_Image.jpg?w=750",
      alt: "Image 3",
    },
    {
      id: "IM_4",
      src: "https://images.ctfassets.net/ub3bwfd53mwy/5WFv6lEUb1e6kWeP06CLXr/acd328417f24786af98b1750d90813de/4_Image.jpg?w=750",
      alt: "Image 4",
    },
  ];

  const [modalShow, setModalShow] = React.useState(false);
  const [selectedImageIndex, setSelectedImageIndex] = React.useState(null);

  const openModal = (index) => {
    setSelectedImageIndex(index);
    setModalShow(true);
  };

  const closeModal = () => {
    setModalShow(false);
  };

  const handleSelect = (selectedIndex) => {
    setSelectedImageIndex(selectedIndex);
  };

  return (
    <Container className="mb-4" data-testid="home-page-grid">
      <Row className="no-gutters">
        {galleryImages.map((image, index) => (
          <Col
            key={image.id}
            xs={12}
            sm={4}
            md={4}
            lg={4}
            onClick={() => openModal(index)}
          >
            <div className="full-width-image">
              <img
                className="IMGrid d-block w-100 mb-4"
                src={image.src}
                alt={image.alt}
              />
            </div>
          </Col>
        ))}
      </Row>

      <Modal
        className="main-modal"
        show={modalShow}
        onHide={closeModal}
        centered
        size="l"
        data-testid="inventory-modal"
      >
        <Modal.Body>
          <Carousel
            activeIndex={selectedImageIndex}
            onSelect={handleSelect}
            className="main-carousel"
          >
            {galleryImages.map((image) => (
              <Carousel.Item key={image.id}>
                <img
                  className="d-block w-100"
                  src={image.src}
                  alt={image.alt}
                />
                <p style={{ textAlign: "left" }}>Name</p>
                <p style={{ textAlign: "left" }}>Price</p>
                <p style={{ textAlign: "left" }}>SKU</p>
                <p style={{ textAlign: "Right" }}>Add to Cart</p>
              </Carousel.Item>
            ))}
          </Carousel>
        </Modal.Body>
      </Modal>
    </Container>
  );
}

export default HomePageComponent;
