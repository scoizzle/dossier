# Fact 4f39702f

Store id: 20cd9a8b-5e00-4649-8dda-670466c6f4ec

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
- posted_at: `2026-11-09T23:44:54.1210830+00:00`

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
  "id": "20cd9a8b-5e00-4649-8dda-670466c6f4ec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1210830+00:00"
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
  "subject_id": "2bf9cb39-04ec-4853-a959-1e9bedec183a",
  "subject_name": "django/db/models/functions/text::Repeat.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
