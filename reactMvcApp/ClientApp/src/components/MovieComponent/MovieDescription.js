import React, { Component } from 'react';
import './movie.css';

import { Glyphicon } from 'react-bootstrap';

import StarRatingComponent from 'react-star-rating-component';

export class MovieDescription extends Component {

    render() {
        const { movie } = this.props
        return (
            <div >

                <div className="row">
                    <div className="col-md-8 movie-title">
                        {movie.title}
                    </div>
                </div>
                <div className="row">
                    <div className="col-md-10">
                        {movie.plot}
                    </div>
                </div>
                <div className="row">
                    <div className="col-md-8">
                        <strong>Year : </strong>{movie.year}
                    </div>
                </div>
                <div className="row">
                    <div className="col-md-8">
                        <strong>Genre :  </strong>{movie.genre}
                    </div>
                </div>
                    <div className="row">
                        <div className="col-md-8">
                            <strong>Director : </strong>{movie.director}
                        </div>
                </div>
                
                <div className="row">
                    <div className="col-md-6 movie-rating">
                        <StarRatingComponent
                            name="rate2"
                            editing={false}
                            renderStarIcon={() => <Glyphicon glyph='star-empty' />}
                            starCount={10}
                            value={movie.Rating}
                                />

                        <div className="col-md-4 ">
                            {movie.ratingCount} Ratings
                        </div>
                    </div>
                 </div>
            </div>

            )
    }
}