# Fact 7f08d090

Store id: 3c418f94-74c4-4368-9e8e-ba32415df10c

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
- posted_at: `2026-11-09T22:39:46.6110150+00:00`

## Data

```json
{
  "end_line": 94,
  "entity_kind": "method",
  "parent": "Degrees",
  "start_line": 88,
  "symbol": "Degrees.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":88,"selector":"L88-L94","symbol":"Degrees.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Degrees.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 94,
    "entity_kind": "method",
    "parent": "Degrees",
    "start_line": 88,
    "symbol": "Degrees.as_oracle"
  },
  "id": "3c418f94-74c4-4368-9e8e-ba32415df10c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6110150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 88,
        "selector": "L88-L94",
        "symbol": "Degrees.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "af54a1b7-1343-46e9-87d9-dcacda770ec0",
  "subject_name": "django/db/models/functions/math::Degrees.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
