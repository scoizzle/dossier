# Fact 67d646af

Store id: 7a7f94c8-bf4f-46b5-9520-8d493dafc74d

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
- posted_at: `2026-11-09T22:39:46.6360150+00:00`

## Data

```json
{
  "end_line": 138,
  "entity_kind": "method",
  "parent": "Pi",
  "start_line": 135,
  "symbol": "Pi.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":135,"selector":"L135-L138","symbol":"Pi.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Pi.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 138,
    "entity_kind": "method",
    "parent": "Pi",
    "start_line": 135,
    "symbol": "Pi.as_oracle"
  },
  "id": "7a7f94c8-bf4f-46b5-9520-8d493dafc74d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6360150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 135,
        "selector": "L135-L138",
        "symbol": "Pi.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "cee063b6-e9e0-4d23-b41d-a3fae4467423",
  "subject_name": "django/db/models/functions/math::Pi.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
