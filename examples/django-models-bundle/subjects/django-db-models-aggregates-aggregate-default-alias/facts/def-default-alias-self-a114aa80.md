# Fact a114aa80

Store id: 97fb21d7-a3f3-4aba-af92-43f996991308

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
- posted_at: `2026-11-09T23:44:48.3965310+00:00`

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
  "id": "97fb21d7-a3f3-4aba-af92-43f996991308",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3965310+00:00"
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
  "subject_id": "c7ed3347-4dd0-4c74-a552-a27c0677cd6b",
  "subject_name": "django/db/models/aggregates::Aggregate.default_alias",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def default_alias(self)"
}
```
