# Fact 2d637b55

Store id: b298b410-0ddf-48a9-b600-9b221102e086

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
- posted_at: `2026-11-09T22:39:46.6470360+00:00`

## Data

```json
{
  "end_line": 156,
  "entity_kind": "method",
  "parent": "Radians",
  "start_line": 150,
  "symbol": "Radians.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":150,"selector":"L150-L156","symbol":"Radians.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Radians.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 156,
    "entity_kind": "method",
    "parent": "Radians",
    "start_line": 150,
    "symbol": "Radians.as_oracle"
  },
  "id": "b298b410-0ddf-48a9-b600-9b221102e086",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6470360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 150,
        "selector": "L150-L156",
        "symbol": "Radians.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "95ac4d35-17eb-4a11-a042-11d089835d25",
  "subject_name": "django/db/models/functions/math::Radians.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
