﻿using Voltaic.Serialization;
using System;
using Voltaic;
using Voltaic.Serialization.Json;

namespace Wumpus.Entities
{
    /// <summary> https://discordapp.com/developers/docs/resources/channel#message-object </summary>
    public class Message
    {
        public const int MaxContentLength = 2000;

        /// <summary> Id of the <see cref="Message"/>. </summary>
        [ModelProperty("id")]
        public Snowflake Id { get; set; }
        /// <summary> Id of the <see cref="Channel"/> the <see cref="Message"/> was in. </summary>
        [ModelProperty("channel_id")]
        public Snowflake ChannelId { get; set; }
        /// <summary> The <see cref="MessageType"/> of <see cref="Message"/>. </summary>
        [ModelProperty("type"), Int53]
        public MessageType Type { get; set; }
        /// <summary> The author of this <see cref="Message"/>. </summary>
        /// <remarks> 
        ///     The author object follows the structure of the <see cref="User"/> object, but is only a valid <see cref="User"/> in the case where the <see cref="Message"/> is generated by a <see cref="User"/> or bot. 
        ///     If the message is generated by a <see cref="Webhook"/>, the author object corresponds to the <see cref="Webhook"/> id, username, and avatar. 
        ///     You can tell if a message is generated by a <see cref="Webhook"/> by checking for the webhook_id on the message object. 
        /// </remarks>
        [ModelProperty("author")]
        public Optional<User> Author { get; set; }
        /// <summary> Contents of the <see cref="Message"/>. </summary>
        [ModelProperty("content")]
        public Optional<Utf8String> Content { get; set; }
        /// <summary> When this <see cref="Message"/> was sent. </summary>
        [ModelProperty("timestamp"), StandardFormat('O')]
        public Optional<DateTimeOffset> Timestamp { get; set; }
        /// <summary> When this <see cref="Message"/> was edited. </summary>
        /// <remarks> Null if never edited. </remarks>
        [ModelProperty("edited_timestamp"), StandardFormat('O')]
        public Optional<DateTimeOffset?> EditedTimestamp { get; set; }
        /// <summary> Whether this was a TTS <see cref="Message"/>. </summary>
        [ModelProperty("tts")]
        public Optional<bool> IsTextToSpeech { get; set; }
        /// <summary> Whether this <see cref="Message"/> mentions everyone. </summary>
        [ModelProperty("mention_everyone")]
        public Optional<bool> MentionEveryone { get; set; }
        /// <summary> <see cref="User"/>s or ids specifically mentioned in this <see cref="Message"/>. </summary>
        [ModelProperty("mentions")]
        public Optional<EntityOrId<User>[]> UserMentions { get; set; }
        /// <summary> <see cref="Role"/> ids specifically mentioned in this <see cref="Message"/>. </summary>
        [ModelProperty("mention_roles")]
        public Optional<Snowflake[]> RoleMentions { get; set; }
        /// <summary> Any attached files. </summary>
        [ModelProperty("attachments")]
        public Optional<Attachment[]> Attachments { get; set; }
        /// <summary> Any embedded content. </summary>
        [ModelProperty("embeds")]
        public Optional<Embed[]> Embeds { get; set; }
        /// <summary> <see cref="Reaction"/> entities to this <see cref="Message"/>. </summary>
        [ModelProperty("reactions")]
        public Optional<Reaction[]> Reactions { get; set; }
        /// <summary> Used for validating a <see cref="Message"/> was sent. </summary>
        [ModelProperty("nonce")]
        public Optional<Utf8String> Nonce { get; set; }
        /// <summary> Whether this <see cref="Message"/> was pinned. </summary>
        [ModelProperty("pinned")]
        public Optional<bool> Pinned { get; set; }
        /// <summary> If this <see cref="Message"/> is generated by a <see cref="Webhook"/>, this is the <see cref="Webhook"/>'s id. </summary>
        [ModelProperty("webhook_id")]
        public Optional<Snowflake> WebhookId { get; set; }
        /// <summary> Sent with Rich Presence-related chat embeds. </summary>
        [ModelProperty("activity")]
        public Optional<MessageActivity> Activity { get; set; }
        /// <summary> Sent with Rich Presence-related chat embeds. </summary>
        [ModelProperty("application")]
        public Optional<MessageApplication> Application { get; set; }
    }
}
