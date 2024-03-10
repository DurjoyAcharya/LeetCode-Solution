package com.app.mailsender;

import com.app.mailsender.communication.email.EmailService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.context.event.ApplicationReadyEvent;
import org.springframework.context.event.EventListener;

@SpringBootApplication
public class MailSenderApplication {
    public final EmailService emailService;
    public MailSenderApplication(EmailService emailService) {
        this.emailService = emailService;
    }
    public static void main(String[] args) {
        SpringApplication.run(MailSenderApplication.class, args);
    }
    @EventListener(ApplicationReadyEvent.class)
    public void sendMail(){
        emailService.sendEmail("da-durjoy@outlook.com",null,"I LOVE YOU");
    }
}
