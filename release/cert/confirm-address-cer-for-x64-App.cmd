pushd %~dp0
certutil -addstore root confirm-address.cer
certutil -addstore TrustedPublisher confirm-address.cer
popd
