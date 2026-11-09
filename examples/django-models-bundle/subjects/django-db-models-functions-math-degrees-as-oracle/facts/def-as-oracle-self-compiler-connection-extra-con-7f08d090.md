# Fact 7f08d090

Store id: bba24a62-4278-43d7-8d1d-08b2fa2f249b

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
- posted_at: `2026-11-09T23:44:53.7232020+00:00`

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
  "id": "bba24a62-4278-43d7-8d1d-08b2fa2f249b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7232020+00:00"
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
  "subject_id": "a36b4334-5cbb-400e-ade8-0e6db264ea24",
  "subject_name": "django/db/models/functions/math::Degrees.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
