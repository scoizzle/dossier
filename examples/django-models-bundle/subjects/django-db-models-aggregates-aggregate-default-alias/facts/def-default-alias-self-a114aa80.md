# Fact a114aa80

Store id: 216c2994-430e-40bc-9cfc-e64b0e719c40

## Text

```text
def default_alias(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:40.0364200+00:00`

## Data

```json
{
  "end_line": 169,
  "entity_kind": "method",
  "parent": "Aggregate",
  "start_line": 162,
  "symbol": "Aggregate.default_alias"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":162,"selector":"L162-L169","symbol":"Aggregate.default_alias"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Aggregate.default_alias](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 169,
    "entity_kind": "method",
    "parent": "Aggregate",
    "start_line": 162,
    "symbol": "Aggregate.default_alias"
  },
  "id": "216c2994-430e-40bc-9cfc-e64b0e719c40",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0364200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 162,
        "selector": "L162-L169",
        "symbol": "Aggregate.default_alias"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "016688ec-f439-41a6-8d4c-8caf97bf12f4",
  "subject_name": "django/db/models/aggregates::Aggregate.default_alias",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def default_alias(self)"
}
```
