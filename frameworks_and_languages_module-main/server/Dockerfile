FROM ruby:2.7.4

#RUN apt-get update ?

WORKDIR /rails_api

COPY ./rails_api/Gemfile ./
COPY ./rails_api/Gemfile.lock ./

RUN gem install bundler
RUN bundle install

COPY ./rails_api/ .

EXPOSE 8000
CMD ["bundle", "exec", "rails", "server", "-b", "0.0.0.0", "-p", "8000"]

