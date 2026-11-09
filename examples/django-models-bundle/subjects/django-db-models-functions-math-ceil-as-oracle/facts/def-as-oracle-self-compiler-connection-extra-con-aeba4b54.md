# Fact aeba4b54

Store id: feb7602f-323f-4349-99c6-5a35174311cc

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
- posted_at: `2026-11-09T23:32:01.6815180+00:00`

## Data

```json
{
  "end_line": 66,
  "entity_kind": "method",
  "parent": "Ceil",
  "start_line": 65,
  "symbol": "Ceil.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":65,"selector":"L65-L66","symbol":"Ceil.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Ceil.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 66,
    "entity_kind": "method",
    "parent": "Ceil",
    "start_line": 65,
    "symbol": "Ceil.as_oracle"
  },
  "id": "feb7602f-323f-4349-99c6-5a35174311cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.6815180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 65,
        "selector": "L65-L66",
        "symbol": "Ceil.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "34d3b7c7-de1b-45c7-b845-b32f8edbb962",
  "subject_name": "django/db/models/functions/math::Ceil.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
