# Fact a114aa80

Store id: 416446e1-979e-4254-8f94-2bd282001779

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
- posted_at: `2026-11-09T23:31:53.5334010+00:00`

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
  "id": "416446e1-979e-4254-8f94-2bd282001779",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5334010+00:00"
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
  "subject_id": "fe1c47cb-4823-4923-aaaa-256a5f9c9a15",
  "subject_name": "django/db/models/aggregates::Aggregate.default_alias",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def default_alias(self)"
}
```
