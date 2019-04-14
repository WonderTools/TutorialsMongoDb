import React, { Component } from 'react';
import './movie.css';
import { MovieCard } from './MovieCard';
import { MovieDescription } from './MovieDescription';

export class MovieComponent extends Component {

   render() {

       const movie = {
            title: "Man of Steel",
            url: "https://henrycavill.org/images/Films/2013-Man-of-Steel/posters/3-Walmart-Superman-a.jpg",
            plot: "Clark Kent is an alien who as a child was evacuated from his dying world and came to Earth, living as a normal human. But when survivors of his alien home invade Earth, he must reveal himself to the world.",
            Rating: 8,
            ratingCount: 17,
           year: 2018,
           genre: "Action, Adventure, Sci-Fi",
           director: "Zack Snyder",
           cast: ["Henry Cavill", "Michael Shannon","Amy Adams"]


        }
        
        return (
            <div className="row  movie-box">
                <div className="col-md-6">
                    <MovieCard className="movie-card" movie={movie} />
                </div>
                <div className="col-md-6 movie-info">
                        <MovieDescription movie={movie} />
                 </div>

            </div >
            
         )
    }
}