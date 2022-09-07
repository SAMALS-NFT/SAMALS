import react from "react";
import MainTitle from "../components/MainTitle";
import MainSub from "../components/MainSub";
import "../styles/Home.css";
import CardList from "../components/CardList";
import { hotDropsData } from "../constants/MockupData";

const Home = () => {
    return (
        <div id="home">
            <MainTitle
                list={
                    hotDropsData
                }
            />
            <MainSub />
            <p id="card-list-header-text">
                {" "}
                Hot
                Drops{" "}
            </p>
            <div id="list-container">
                <CardList
                    list={
                        hotDropsData
                    }
                />
            </div>
        </div>
    );
};

export default Home;
