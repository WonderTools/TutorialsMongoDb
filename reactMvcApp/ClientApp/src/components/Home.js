import React, { Component } from 'react';
import { Movie } from './MovieComponent/Movie';
export class Home extends Component {
  displayName = Home.name

    render() {
        const movie = {
            url: "https://henrycavill.org/images/Films/2013-Man-of-Steel/posters/3-Walmart-Superman-a.jpg"
        }
    return (
        <div className="row movie-box">
            <div className="col-md-6">
                <Movie className="movie-card" movie={movie} />
            </div>
            <div className="col-md-6 movie-info">
                Clark Kent is an alien who as a child was evacuated from his dying world and came to Earth, living as a normal human. But when survivors of his alien home invade Earth, he must reveal himself to the world.
            </div>
      </div>
    );
  }
}
