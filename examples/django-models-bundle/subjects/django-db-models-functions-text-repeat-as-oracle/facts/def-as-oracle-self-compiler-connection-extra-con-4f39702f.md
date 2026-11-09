# Fact 4f39702f

Store id: d655d2af-3a26-4bd5-a421-98ba753ce711

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
- posted_at: `2026-11-09T22:39:47.1477220+00:00`

## Data

```json
{
  "end_line": 250,
  "entity_kind": "method",
  "parent": "Repeat",
  "start_line": 246,
  "symbol": "Repeat.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":246,"selector":"L246-L250","symbol":"Repeat.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Repeat.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 250,
    "entity_kind": "method",
    "parent": "Repeat",
    "start_line": 246,
    "symbol": "Repeat.as_oracle"
  },
  "id": "d655d2af-3a26-4bd5-a421-98ba753ce711",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1477220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 246,
        "selector": "L246-L250",
        "symbol": "Repeat.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "9a47827d-3df9-4345-b069-040b61c69aef",
  "subject_name": "django/db/models/functions/text::Repeat.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
