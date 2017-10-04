FROM lerenn/nginx-reverse-proxy

#Copy reverse proxy configurations for the IdeaMan WEB and API 
COPY ./conf/sites-enabled.conf /etc/nginx/conf.d/

CMD ["nginx", "-g", "daemon off;"]
