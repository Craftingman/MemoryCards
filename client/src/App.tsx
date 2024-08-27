import { Routes, Route } from "react-router-dom";
import CardCollectionsPage from "./pages/CardCollectionsPage";
import Navigation from "./compoents/Navigation";

function App() {
  return (
    <>
      <Navigation />
      <Routes>
        <Route path="/" element={<CardCollectionsPage />} />
      </Routes>
    </>
  );
}

export default App;
