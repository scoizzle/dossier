# Fact f29e6fe4

Store id: 144ce35d-034a-45da-8613-d677322cf130

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:47.1593320+00:00`

## Data

```json
{
  "end_line": 279,
  "entity_kind": "method",
  "parent": "Reverse",
  "start_line": 264,
  "symbol": "Reverse.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":264,"selector":"L264-L279","symbol":"Reverse.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Reverse.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 279,
    "entity_kind": "method",
    "parent": "Reverse",
    "start_line": 264,
    "symbol": "Reverse.as_oracle"
  },
  "id": "144ce35d-034a-45da-8613-d677322cf130",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1593320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 264,
        "selector": "L264-L279",
        "symbol": "Reverse.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "7af11f6a-d0e9-4361-96af-6386d804c177",
  "subject_name": "django/db/models/functions/text::Reverse.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
