# Fact 67d646af

Store id: d0f42fe1-5eae-4fbd-b0db-bd30d3b32583

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
- posted_at: `2026-11-09T23:44:53.7417180+00:00`

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
  "id": "d0f42fe1-5eae-4fbd-b0db-bd30d3b32583",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7417180+00:00"
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
  "subject_id": "cb77ac15-4e10-459c-a4fa-b76aa20ca145",
  "subject_name": "django/db/models/functions/math::Pi.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
